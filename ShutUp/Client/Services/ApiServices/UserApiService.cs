using ShutUp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ShutUp.Client.Services.ApiServices
{
    public class UserApiService
    {
        private readonly HttpClient _httpClient;

        public UserApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<User>> GetAllRegisteredUsers()
        {
            return await _httpClient.GetFromJsonAsync<List<User>>("api/User");

        }
    }
}
