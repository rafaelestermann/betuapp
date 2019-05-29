using betuapp.Shared;
using BlazorCrud.Server.DataAccess;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace betuapp.Server.Controllers
{
    [Route("api/[controller]")]
    public class BetDataController : Controller
    {
        BetDataService dataservice = new BetDataService();
        AccountDataService accountSevice = new AccountDataService();

        [HttpGet("[action]")]
        public IEnumerable<ExtentedBet> Bets()
        {
            var bets = dataservice.GetAllBets();
            var accounts = accountSevice.GetAllAccounts();
            List<ExtentedBet> extendetBets = new List<ExtentedBet>();
            foreach(var bet in bets)
            {
                extendetBets.Add(CreateExtentedBetByBet(bet, accounts));             
            }
            return extendetBets;
        }

        [HttpPost("[action]")]
        public ExtentedBet CreateBet([FromBody]ExtentedBet bet)
        {
            dataservice.AddBet(CreateBetByExtentedBet(bet));
            return bet;
        }

        [HttpPost("[action]")]
        public ExtentedBet UpdateBet([FromBody]ExtentedBet bet)
        {
            dataservice.UpdateBet(CreateBetByExtentedBet(bet));
            return bet;
        }

        [HttpGet("[action]/{id}")]
        public List<ExtentedBet> GetBetsByAccount(long id)
        {     
            var bets = dataservice.GetAllBets().Where(x => x.ChallengedId == id || x.ChallengerId == id).ToList();
            var accounts = accountSevice.GetAllAccounts();
            List<ExtentedBet> extendetBets = new List<ExtentedBet>();
            foreach (var bet in bets)
            {
                extendetBets.Add(CreateExtentedBetByBet(bet, accounts));
            }
            return extendetBets;
        }
        private Bet CreateBetByExtentedBet(ExtentedBet extentedBet)
        {
            var bet = new Bet
            {
                Id = extentedBet.Id,
                ChallengerWon = extentedBet.ChallengerWon,
                ConsentChallenged = extentedBet.ConsentChallenged,
                ConsentChallenger = extentedBet.ConsentChallenger,
                Description = extentedBet.Description,
                DueDate = extentedBet.DueDate,
                Evidence = extentedBet.Evidence,
                IstAbgeschlossen = extentedBet.IstAbgeschlossen,
                Name = extentedBet.Name,
                Tip = extentedBet.Tip,
                ChallengedId = extentedBet.Challenged.Id,
                ChallengerId = extentedBet.Challenger.Id
            };

            return bet;
        }

        private ExtentedBet CreateExtentedBetByBet(Bet bet, IEnumerable<Account> accounts)
        {
            var extendetBet = new ExtentedBet
            {
                Id = bet.Id,
                ChallengerWon = bet.ChallengerWon,
                ConsentChallenged = bet.ConsentChallenged,
                ConsentChallenger = bet.ConsentChallenger,
                Description = bet.Description,
                DueDate = bet.DueDate,
                Evidence = bet.Evidence,
                IstAbgeschlossen = bet.IstAbgeschlossen,
                Name = bet.Name,
                Tip = bet.Tip
            };

            extendetBet.Challenger = accounts.Where(x => x.Id == bet.ChallengerId).First();
            extendetBet.Challenged = accounts.Where(x => x.Id == bet.ChallengedId).First();
            return extendetBet;
        }
    }
}
