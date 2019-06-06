using betuapp.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace betuapp.Server.DataAccess
{
    public class BetContext : DbContext
    {
        public virtual DbSet<Bet> Bet { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=tcp:betuserver.database.windows.net,1433;Initial Catalog=betudatabase;Persist Security Info=False;User ID=admin123;Password=Waldweg123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }
    }
}