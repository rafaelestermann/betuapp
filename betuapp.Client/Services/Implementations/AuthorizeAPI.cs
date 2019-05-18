using System;
using System.Collections.Generic;
//using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using betuapp.Shared;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using betuapp.Client.Services.Contracts;

namespace betuapp.Client.Services.Implementations
{
    public class AuthorizeAPI : IAuthorizeApi
    {
        private readonly HttpClient _httpClient;
        public int number {get; set;}
        public AuthorizeAPI(HttpClient httpClient)
        {
            _httpClient = httpClient;   
        }

        public async Task<UserInfo> Login(LoginParameters loginParameters)
        {
            number++;
            var stringContent = new StringContent(Json.Serialize(loginParameters), Encoding.UTF8, "application/json");
            var result = await _httpClient.PostAsync("api/AuthorizeData/Login", stringContent);
            if (result.StatusCode == System.Net.HttpStatusCode.BadRequest) throw new Exception(await result.Content.ReadAsStringAsync());
            result.EnsureSuccessStatusCode();

            return Json.Deserialize<UserInfo>(await result.Content.ReadAsStringAsync());
        }

        public async Task Logout()
        {
            var result = await _httpClient.PostAsync("api/Authorize/Logout", null);
            result.EnsureSuccessStatusCode();
        }

        public async Task<UserInfo> Register(RegisterParameters registerParameters)
        {
            var stringContent = new StringContent(Json.Serialize(registerParameters), Encoding.UTF8, "application/json");
            var result = await _httpClient.PostAsync("api/Authorize/Register", stringContent);
            if (result.StatusCode == System.Net.HttpStatusCode.BadRequest) throw new Exception(await result.Content.ReadAsStringAsync());
            result.EnsureSuccessStatusCode();

            return Json.Deserialize<UserInfo>(await result.Content.ReadAsStringAsync());
        }

        public async Task<UserInfo> GetUserInfo()
        {
            var result = await _httpClient.GetJsonAsync<UserInfo>("api/Authorize/UserInfo");
            return result;
        }
    }
}
