using betuapp.Server.DataAccess;
using betuapp.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrud.Server.DataAccess
{
    public class AcceptanceCritereaService  
    {
        AcceptanceCritereaContext db = new AcceptanceCritereaContext();

        //To Get all Bets details   
        public IEnumerable<AcceptanceCriterea> GetAllAcceptanceCriterasByBetID(long id)
        {
            try
            {
                return db.AcceptanceCriterea.Where(x => x.BetId == id).ToList();
            }
            catch
            {
                throw;
            }
        }

        //To Add new Bet record     
        public void AddAcceptanceCriterea(AcceptanceCriterea acceptanceCriterea)
        {
            if(acceptanceCriterea.Text == null)
            {
                acceptanceCriterea.Text = "";
            }
            try
            {
                db.AcceptanceCriterea.Add(acceptanceCriterea);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar Bet    
        public void UpdateAcceptanceCriterea(AcceptanceCriterea acceptanceCriterea)
        {
            try
            {
                db.Entry(acceptanceCriterea).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        internal IEnumerable<AcceptanceCriterea> GetAllAcceptanceCriteras()
        {
            return db.AcceptanceCriterea.ToList();
        }


        //To Delete the record of a particular Bet    
        public void DeleteAcceptanceCriterea(int id)
        {
            try
            {
                AcceptanceCriterea emp = db.AcceptanceCriterea.Find(id);
                db.AcceptanceCriterea.Remove(emp);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}