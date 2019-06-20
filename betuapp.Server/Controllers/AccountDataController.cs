using betuapp.Shared;
using BlazorCrud.Server.DataAccess;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace betuapp.Server.Controllers
{
    [Route("api/[controller]")]
    public class AccountDataController : Controller
    {
        AccountDataService dataservice = new AccountDataService();
        BetDataService betDataService = new BetDataService();

        [HttpGet("[action]")]
        public IEnumerable<Account> Accounts()
        {
            return dataservice.GetAllAccounts();
        }

        [HttpGet("[action]/{id}")]
        public IEnumerable<Account> GetAllPartnerAccountsByAccountId(long id)
        {
            List<Account> resultList = new List<Account>();
            var bets = betDataService.GetAllBets().Where(x => x.ChallengedId == id || x.ChallengerId == id).ToList();
            var accounts = dataservice.GetAllAccounts();
            foreach (var bet in bets)
            {
                if(bet.ChallengerId == id)
                {
                    resultList.Add(accounts.Where(x => x.Id == bet.ChallengedId).First());
                }
                else
                {
                    resultList.Add(accounts.Where(x => x.Id == bet.ChallengerId).First());
                }
            }

            return resultList.Distinct();
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
