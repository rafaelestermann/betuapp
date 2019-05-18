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
        public int number { get; set; }
        private readonly IAuthorizeApi _authorizeApi;
        private readonly IJSRuntime _jsRuntime;
        private UserInfo userInfo;

        public AuthenticationState(IAuthorizeApi authorizeApi, IJSRuntime jsRuntime)
        {
            _authorizeApi = authorizeApi;
            _jsRuntime = jsRuntime;
        }

        public Task<bool> IsLoggedIn()
        {
            return new Task<bool>(() => false);
            //return _jsRuntime.InvokeAsync<bool>("Authorization_LoginCookieExists");
        }

        public async Task Login(LoginParameters loginParameters)
        {
            number++;
               userInfo = await _authorizeApi.Login(loginParameters);
        }

        public async Task Register(RegisterParameters registerParameters)
        {
            userInfo = await _authorizeApi.Register(registerParameters);
        }

        public async Task Logout()
        {
            await _authorizeApi.Logout();
            userInfo = null;
        }

        public async Task<UserInfo> GetUserInfo()
        {
            if (userInfo != null) return userInfo;
            userInfo = await _authorizeApi.GetUserInfo();
            return userInfo;
        }

    }
}
