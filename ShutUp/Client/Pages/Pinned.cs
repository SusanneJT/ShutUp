using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;
using ShutUp.Shared;
using ShutUp.Client.Components;

namespace ShutUp.Client.Pages
{
    public partial class Pinned
    {
        private AnswerMessage answerMessage { get; set; } = new AnswerMessage();
        private WriteMessageBar writeMessageBar { get; set; } = new WriteMessageBar();
        private ListSubMessagesPinned listSubMessages { get; set; } = new ListSubMessagesPinned();
        private HubConnection hubConnection;
        private Message message;
        private string messageInput;
        private string subMessageInput;
        private bool loading = true;
        private bool showWriteMessageBar;


        protected override async Task OnInitializedAsync()
        {
            showWriteMessageBar = false;
            if (_messageState.Messages.Count() == 0)
                _messageState.Messages = await _messageApi.GetAllMessages();

            if (_messageState.Messages.Count() != 0)
                loading = false;


            hubConnection = new HubConnectionBuilder()
                .WithUrl(_navigationManager.ToAbsoluteUri("/chathub"))
                .Build();

            hubConnection.On<Message>("ReceiveMessage", (message) =>
            {
                _messageState.Messages.Add(message);
                StateHasChanged();
            });

            hubConnection.On<SubMessage>("ReceiveSubMessage", (subMessage) =>
            {
                Message findMessage = _messageState.Messages.Find(x => subMessage.MessageId == x.MessageId);
                if (findMessage.SubMessages == null)
                    findMessage.SubMessages = new List<SubMessage>();
                findMessage.SubMessages.Add(subMessage);
                StateHasChanged();
            });


            hubConnection.On<Message>("ReceiveChangedMessage", (message) =>
            {
                _messageState.ChangeProperty(message);
                StateHasChanged();
            });

            await hubConnection.StartAsync();
            _messageState.OnChange += StateHasChanged;
        }

        public Task Send(Message message)
        {
            message.User = _userState.User;
            message.Date = DateTime.Now;
            message.MessageId = _messageState.Messages.Count + 1;
            showWriteMessageBar = false;
            return hubConnection.SendAsync("SendMessage", message);
        }

        public Task SendSubMessage(SubMessage subMessage)
        {
            subMessage.User = _userState.User;
            subMessage.Date = DateTime.Now;
            return hubConnection.SendAsync("SendSubMessage", subMessage);
        }

        public async void Edit(Message message)
        {
            if (message.Pinned)
                message.Pinned = false;
            else
                message.Pinned = true;

            await hubConnection.SendAsync("ChangeMessage", message);
        }
        public void ShowWriteMessageBar()
        {
            showWriteMessageBar = true;
        }
        public void Hide()
        {
            showWriteMessageBar = false;
        }


        public bool IsConnected =>
            hubConnection.State == HubConnectionState.Connected;

        public void Dispose()
        {
            _ = hubConnection.DisposeAsync();
        }
    }
}
