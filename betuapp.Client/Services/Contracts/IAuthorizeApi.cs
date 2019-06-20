using betuapp.Shared;
using System.Threading.Tasks;

namespace betuapp.Client.Services.Contracts
{
    public interface IAuthorizeApi
    {
        Task<Account> Login(LoginParameters loginParameters);
        Task<Account> Register(RegisterParameters registerParameters);
    }
}
