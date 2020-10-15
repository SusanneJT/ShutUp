﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using ShutUp.Server.Models;
using ShutUp.Shared;

namespace ShutUp.Server.Hubs
{
    public class ChatHub : Hub
    {
        private readonly IMessageRepository _messageRepository;

        public ChatHub(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }

        public async Task SendMessage(Message message)
        {
            _messageRepository.NewMessage(message);
            await Clients.All.SendAsync("ReceiveMessage", message);
        }
    }
}
