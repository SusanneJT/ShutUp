using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShutUp.Client.Services.StateContainers
{
    public class StateContainerConnection
    {
        public bool Connection { get; set; } 

        public event Action OnChange;

        public void SetProperty(bool _connection)
        {
            Connection = _connection;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
