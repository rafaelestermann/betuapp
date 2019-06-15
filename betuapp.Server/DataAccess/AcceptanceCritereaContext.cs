using betuapp.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace betuapp.Server.DataAccess
{
    public class AcceptanceCritereaContext : DbContext
    {
        public virtual DbSet<AcceptanceCriterea> AcceptanceCriterea { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-DMNQJI0\SQLEXPRESS;Initial Catalog=betudatabase;Integrated Security=True;");
            }
        }
    }
}