using betuapp.Server.DataAccess;
using betuapp.Shared;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BlazorCrud.Server.DataAccess
{
    public class AccountDataService
    {
        AccountContext db = new AccountContext();

        //To Get all Accounts details   
        public IEnumerable<Account> GetAllAccounts()
        {
            try
            {
                return db.Account.ToList();
            }
            catch
            {
                throw;
            }
        }

        //To Add new Account record     
        public void AddAccount(Account Account)
        {
            db.Account.Add(Account);
            db.SaveChanges();
        }

        //To Update the records of a particluar Account    
        public void UpdateAccount(Account Account)
        {
            try
            {
                db.Entry(Account).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a particular Account    
        public Account GetAccountData(int id)
        {
            try
            {
                Account Account = db.Account.Find(id);
                return Account;
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record of a particular Account    
        public void DeleteAccount(long id)
        {
            try
            {
                Account emp = db.Account.Find(id);
                db.Account.Remove(emp);
                db.SaveChanges();
            }
            catch
            {
            }
        }
    }
}