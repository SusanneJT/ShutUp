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

        protected override async Task OnInitializedAsync()
        {
            hubConnection = new HubConnectionBuilder()
                .WithUrl(NavigationManager.ToAbsoluteUri("/chathub"))
                .Build();

            hubConnection.On<Message>("ReceiveMessage", (message) =>
            {
                MessageState.Messages.Add(message);
                StateHasChanged();
            });

            await hubConnection.StartAsync();
            MessageState.OnChange += StateHasChanged;
        }

        Task Send()
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