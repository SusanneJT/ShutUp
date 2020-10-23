using ShutUp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ShutUp.Client.Pages
{
    public partial class Index
    {
        List<User> registeredUsers = new List<User>();
        public bool loading = true;
        public User user;

        protected override async Task OnParametersSetAsync()
        {
            registeredUsers = await _userApi.GetAllRegisteredUsers();
            if (registeredUsers != null)
                loading = false;
        }

        protected override async Task OnInitializedAsync()
        {
            if(_userState.User.LoggedIn)
            {
                loading = false;
            }

            _userState.OnChange += StateHasChanged;
        }

        protected async void SelectUser(int userId)
        {
            user = registeredUsers.Find(x => userId == x.UserId);
            user.LoggedIn = true;
            _userState.SetProperty(user);
            await _localStore.SetItemAsync("UserKey", user);
            _navigationManager.NavigateTo("/pinned");
            Dispose();
        }

        public void Dispose()
        {
            _userState.OnChange -= StateHasChanged;
        }
        public void RedirectToPinned()
        {
            _navigationManager.NavigateTo("/pinned");
        }
    }
}
