using betuapp.Server.DataAccess;
using betuapp.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrud.Server.DataAccess
{
    public class BetDataService
    {
        BetContext db = new BetContext();

        //To Get all Bets details   
        public IEnumerable<Bet> GetAllBets()
        {
            try
            {
                return db.Bet.ToList();
            }
            catch
            {
                throw;
            }
        }

        //To Add new Bet record     
        public void AddBet(Bet Bet)
        {
            try
            {
                db.Bet.Add(Bet);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar Bet    
        public void UpdateBet(Bet Bet)
        {
            try
            {
                db.Entry(Bet).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a particular Bet    
        public Bet GetBetData(int id)
        {
            try
            {
                Bet Bet = db.Bet.Find(id);
                return Bet;
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record of a particular Bet    
        public void DeleteBet(int id)
        {
            try
            {
                Bet emp = db.Bet.Find(id);
                db.Bet.Remove(emp);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}