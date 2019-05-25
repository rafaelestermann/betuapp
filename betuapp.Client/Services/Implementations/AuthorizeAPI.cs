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
        public AuthorizeAPI(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Account> Login(LoginParameters loginParameters)
        {
            var result = await _httpClient.SendJsonAsync<Account>(HttpMethod.Post, "api/AccountData/Login", loginParameters);            
            return result;
        }

        public async Task<Account> Register(RegisterParameters registerParameters)
        {
            //VALIDATION
            if (registerParameters.Password != registerParameters.PasswordConfirmation)
            {
                return new Account();
            }

            var account = new Account()
            {
                Email = registerParameters.Email,
                Firstname = registerParameters.Firstname,
                Lastname = registerParameters.Lastname,
                Password = registerParameters.Password,
                Username = registerParameters.UserName,
                OwnedCash = 0
            };

            var result = await _httpClient.SendJsonAsync<Account>(HttpMethod.Post, "api/AccountData/CreateAccount", account);
            return result;
        }
    }
}
