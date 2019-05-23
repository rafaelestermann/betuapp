using betuapp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace betuapp.Client.Services.Contracts
{
    public interface IAuthorizeApi
    {
        Task<Account> Login(LoginParameters loginParameters);
        Task<Account> Register(RegisterParameters registerParameters);
    }
}
