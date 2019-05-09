using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using betuapp.Shared;
using Blazored.LocalStorage;
using Microsoft.JSInterop;
//using System.IdentityModel.Tokens.Jwt;
using Newtonsoft.Json.Linq;

namespace betuapp.Client.Service
{
    public class AppState
    {
        private readonly HttpClient _httpClient;
        private readonly ILocalStorageService _localStorage;

        public bool IsLoggedIn { get; private set; }
        public string storage { get; set; }

        public AppState(HttpClient httpClient,
                        ILocalStorageService localStorage)
        {
            _httpClient = httpClient;
            _localStorage = localStorage;
        }
    
        public async Task Login(LoginDetails loginDetails)
        {
            var response =  await _httpClient.PostAsync("api/LoginData/Login", new StringContent(Json.Serialize(loginDetails), Encoding.UTF8, "application/json"));

            if (response.IsSuccessStatusCode)
            {
                await SaveToken(response);
                await SetAuthorizationHeader();
                IsLoggedIn = true;
            }
        }

        public async Task Logout()
        {
            await _localStorage.RemoveItemAsync("authToken");
            IsLoggedIn = false;
        }

        private async Task SaveToken(HttpResponseMessage response)
        {
            var responseContent = await response.Content.ReadAsStringAsync();
            //var jwt = Json.Deserialize<JwtSecurityToken>(responseContent);

            //await _localStorage.SetItemAsync("authToken", jwt);
        }

        private async Task SetAuthorizationHeader()
        {
            if (!_httpClient.DefaultRequestHeaders.Contains("Authorization"))
            {
                var token = await _localStorage.GetItemAsync<string>("authToken");
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
        }
    }
}
