using betuapp.Shared;
using BlazorCrud.Server.DataAccess;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace betuapp.Server.Controllers
{
    [Route("api/[controller]")]
    public class AccountDataController : Controller
    {
        AccountDataService dataservice = new AccountDataService();

        [HttpGet("[action]")]
        public IEnumerable<Account> Accounts()
        {
            return dataservice.GetAllAccounts();
        }

        [HttpGet("[action]/{username}&{password}")]
        public ReducedAccount Account(string username, string password)
        {
           var acc = Accounts().Where(acco => acco.Username == username && acco.Password == password).FirstOrDefault();
        

            return new ReducedAccount()
            {
                Email = acc.Email,
                Firstname = acc.Firstname,
                Lastname = acc.Lastname,
                OwnedCash = acc.OwnedCash,
                Username = acc.Username
            };
        }

        [HttpPost("[action]")]
        public Account CreateAccount([FromBody]Account account)
        {
            dataservice.AddAccount(account);
            return new Account();
        }

        [HttpPost("[action]")]
        public Account DeleteAccount([FromBody]long id)
        {
            dataservice.DeleteAccount(id);
            return new Account();
        }
    }
}
