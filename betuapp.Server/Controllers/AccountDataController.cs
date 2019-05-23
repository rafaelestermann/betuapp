using betuapp.Server.Models;
using betuapp.Shared;
using BlazorCrud.Server.DataAccess;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

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
        public Account Account(string username, string password)
        {
            return Accounts().Where(acco => acco.Username == username && acco.Password == password).FirstOrDefault();
        }

        [HttpPost("[action]")]
        public Account CreateAccount([FromBody]Account account)
        {
            dataservice.AddAccount(account);
            return account;
        }

        [HttpPost("[action]")]
        public Account Login([FromBody]LoginParameters parameters)
        {
            var accounts = dataservice.GetAllAccounts();
            if(!accounts.Any(x => x.Username == parameters.UserName && x.Password == parameters.Password))
            {
                return new Account();
            }
            else
            {
                return accounts.Where(x => x.Username == parameters.UserName && x.Password == parameters.Password).First();
            }
        }
    }
}
