using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;
using ShutUp.Shared;

namespace ShutUp.Client.Pages
{
    public partial class Pinned
    {
        private HubConnection hubConnection;
        private Message message;
        private string messageInput;
        private string subMessageInput;
        private bool loading = true;


        protected override async Task OnInitializedAsync()
        {
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

            await hubConnection.StartAsync();
            _messageState.OnChange += StateHasChanged;
        }

        public Task Send()
        {
            message = new Message();
            message.User = _userState.User;
            message.MessageText = messageInput;
            message.Date = DateTime.Now;
            messageInput = "";
            return hubConnection.SendAsync("SendMessage", message);
        }
        public Task Send(int id)
        {
            SubMessage subMessage = new SubMessage();
            subMessage.User = _userState.User;
            subMessage.MessageText = subMessageInput;
            subMessage.MessageId = id;
            subMessage.Date = DateTime.Now;
            subMessageInput = "";
            return hubConnection.SendAsync("SendSubMessage", subMessage);
        }


        public bool IsConnected =>
            hubConnection.State == HubConnectionState.Connected;

        public void Dispose()
        {
            _ = hubConnection.DisposeAsync();
        }
    }
}
