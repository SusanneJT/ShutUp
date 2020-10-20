using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using ShutUp.Shared;

namespace ShutUp.Client.Components
{
    public partial class EditMessageModal
    {
        [Parameter]
        public EventCallback<Message> CloseEventCallback { get; set; }
        private Message Message = new Message();
        public bool ShowModal = false;
        public string name;

        public void Show(Message message)
        {
            Message = message;
            ShowModal = true;
            StateHasChanged();
        }

        public async Task Close()
        {
            ShowModal = false;
            await CloseEventCallback.InvokeAsync(Message);
            StateHasChanged();
        }

    }
}
