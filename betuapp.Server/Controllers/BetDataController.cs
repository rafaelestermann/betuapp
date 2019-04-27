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
        public IEnumerable<Bet> Bets()
        {
            return dataservice.GetAllBets();
        }
    }
}
