using betuapp.Client.Services.Contracts;
using betuapp.Shared;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace betuapp.Client.States
{
    public class AuthenticationState
    {
        private readonly IAuthorizeApi _authorizeApi;
        private readonly IJSRuntime _jsRuntime;
        public Account loggedInAccount;
        public Account JustRegisteredAccount;

        public AuthenticationState(IAuthorizeApi authorizeApi, IJSRuntime jsRuntime)
        {
            _authorizeApi = authorizeApi;
            _jsRuntime = jsRuntime;
        }

        public Task<bool> IsLoggedIn()
        {
            if(loggedInAccount != null)
            {
                return Task.FromResult(true);
            }
            else
            {
                return Task.FromResult(false);
            }
        }

        public async Task Login(LoginParameters loginParameters)
        {
            loggedInAccount = await _authorizeApi.Login(loginParameters);            
        }

        public async Task Register(RegisterParameters registerParameters)
        {
            JustRegisteredAccount = await _authorizeApi.Register(registerParameters);         
        }

        public async Task Logout()
        {
            await _authorizeApi.Logout();
            loggedInAccount = null;
        }
    }
}
