using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;
using ShutUp.Shared;
using ShutUp.Client.Components;
using Microsoft.AspNetCore.Components;


namespace ShutUp.Client.Pages
{
    public partial class Chat
    {
        private EditMessageModal editMessageModal { get; set; } = new EditMessageModal();
        private WriteMessageBar writeMessageBar { get; set; } = new WriteMessageBar();
        private AnswerMessage answerMessage { get; set; } = new AnswerMessage();
        private ListSubMessages listSubMessages { get; set; } = new ListSubMessages();

        private HubConnection hubConnection;
        private string messageInput;
        private bool pinned;

        SubMessage subMessage = new SubMessage();

        private bool loading = true;
        private string liClass;
        private string classes = "list-group-item border";
        private string classesPinned = "list-group-item border border-danger";


        protected override async Task OnInitializedAsync()
        {
            //Should be removed when/if mockdatabase is added
            if(_messageState.Messages.Count() == 0)
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
            return hubConnection.SendAsync("SendMessage", message);
        }
        public Task SendSubMessage(SubMessage subMessage)
        {
            //SubMessage subMessage = new SubMessage();
            subMessage.User = _userState.User;
            //subMessage.MessageId = id;
            subMessage.Date = DateTime.Now;
            //subMessageInput = "";
            return hubConnection.SendAsync("SendSubMessage", subMessage);
        }

        public async void Edit(Message message)
        {
            //editMessageModal.Show(message);
            if (message.Pinned)
                message.Pinned = false;
            else
                message.Pinned = true;

            await hubConnection.SendAsync("ChangeMessage", message);
        }

        public async Task EditMessageModalClose(Message message)
        {
            await hubConnection.SendAsync("ChangeMessage", message);
        }


        public bool IsConnected =>
            hubConnection.State == HubConnectionState.Connected;

        public void Dispose()
        {
            _ = hubConnection.DisposeAsync();
        }
    }
}