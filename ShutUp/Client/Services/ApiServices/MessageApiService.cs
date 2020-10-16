using ShutUp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ShutUp.Client.Services.ApiServices
{
    public class MessageApiService
    {
        private readonly HttpClient _httpClient;

        public MessageApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Message>> GetAllMessages()
        {
            return await _httpClient.GetFromJsonAsync<List<Message>>("api/Message");

        }
    }
}
