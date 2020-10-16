using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;
using ShutUp.Shared;


namespace ShutUp.Client.Pages
{
    public partial class Chat
    {

        private HubConnection hubConnection;
        private Message message;
        private string userInput;
        private string messageInput;
        private bool loading = true;

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

            await hubConnection.StartAsync();
            _messageState.OnChange += StateHasChanged;
        }

        public Task Send()
        {
            message = new Message();
            message.Name = userInput;
            message.MessageText = messageInput;
            message.Date = DateTime.Now;
            return hubConnection.SendAsync("SendMessage", message);
        }


        public bool IsConnected =>
            hubConnection.State == HubConnectionState.Connected;

        public void Dispose()
        {
            _ = hubConnection.DisposeAsync();
        }
    }
}