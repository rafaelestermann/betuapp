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
        AcceptanceCritereaService acceptanceCritereaService = new AcceptanceCritereaService();

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

        [HttpGet("[action]")]
        public List<AcceptanceCriterea> AcceptanceCritereas()
        {
            var list = acceptanceCritereaService.GetAllAcceptanceCriteras().ToList();
            return list;
        }        

        [HttpPost("[action]")]
        public Bet CreateBet([FromBody]Bet bet)
        {
            dataservice.AddBet(bet);
            return bet;
        }

        [HttpPost("[action]")]
        public List<AcceptanceCriterea> CreateAcceptanceCritereas([FromBody]List<AcceptanceCriterea> critereas)
        {
            foreach(var criterea in critereas)
            {
                acceptanceCritereaService.AddAcceptanceCriterea(criterea);
            }
            return critereas;
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
                ChallengerWonChallenged = extentedBet.ChallengerWonChallenged,
                ChallengerWonChallenger = extentedBet.ChallengerWonChallenger,
                Description = extentedBet.Description,
                DueDate = extentedBet.DueDate,
                Evidence = extentedBet.Evidence,
                IstAbgeschlossen = extentedBet.IstAbgeschlossen,
                Name = extentedBet.Name,
                Tip = extentedBet.Tip,
                ChallengedId = extentedBet.Challenged.Id,
                ChallengerId = extentedBet.Challenger.Id,
                ConsentChallengerGiven = extentedBet.ConsentChallengerGiven,
                ConsentChallengedGiven = extentedBet.ConsentChallengedGiven,
                ChallengerWon = extentedBet.ChallengerWon                
            };

            return bet;
        }

        private ExtentedBet CreateExtentedBetByBet(Bet bet, IEnumerable<Account> accounts)
        {
            var extendetBet = new ExtentedBet
            {
                Id = bet.Id,
                ChallengerWonChallenger = bet.ChallengerWonChallenger,
                ChallengerWonChallenged = bet.ChallengerWonChallenged,
                Description = bet.Description,
                DueDate = bet.DueDate,
                Evidence = bet.Evidence,
                IstAbgeschlossen = bet.IstAbgeschlossen,
                Name = bet.Name,
                Tip = bet.Tip,
                ConsentChallengedGiven = bet.ConsentChallengedGiven,
                ConsentChallengerGiven = bet.ConsentChallengerGiven,
                ChallengerWon = bet.ChallengerWon
            };

            extendetBet.Challenger = accounts.Where(x => x.Id == bet.ChallengerId).First();
            extendetBet.Challenged = accounts.Where(x => x.Id == bet.ChallengedId).First();
            return extendetBet;
        }
    }
}
