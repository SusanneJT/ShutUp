using ShutUp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShutUp.Client.Services.StateContainers
{
    public class UserStateContainer
    {
        public User User { get; set; } = new User();

        public event Action OnChange;

        public void SetProperty(User _user)
        {
            User = _user;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
