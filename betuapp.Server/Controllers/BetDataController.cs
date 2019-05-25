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

        [HttpGet("[action]")]
        public IEnumerable<ExtentedBet> Bets()
        {
            return dataservice.GetAllBets();
        }

        [HttpPost("[action]")]
        public ExtentedBet CreateBet([FromBody]ExtentedBet bet)
        {
            dataservice.AddBet(bet);
            return bet;
        }

        [HttpPost("[action]")]
        public ExtentedBet UpdateBet([FromBody]ExtentedBet bet)
        {
            dataservice.UpdateBet(bet);
            return bet;
        }

        [HttpGet("[action]")]
        public List<ExtentedBet> GetBetsByAccount([FromBody]long accountId)
        {
            return dataservice.GetAllBets().Where(x => x.Challenged.Id == accountId || x.Challenger.Id == accountId).ToList();
        }
    }
}
