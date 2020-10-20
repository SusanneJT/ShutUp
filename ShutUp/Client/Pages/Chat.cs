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
        private HubConnection hubConnection;
        private Message Message = new Message();
        private string messageInput;
        private bool pinned;
        private string subMessageInput;
        private bool loading = true;
        private string liClass;
        private string classes = "list-group-item";
        private string classesPinned = "list-group-item list-group-item-danger";


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

        public Task Send()
        {
            Message.User = _userState.User;
            Message.Date = DateTime.Now;
            Message.MessageId = _messageState.Messages.Count + 1;
            return hubConnection.SendAsync("SendMessage", Message);
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

        public void Edit(Message message)
        {
            editMessageModal.Show(message);
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