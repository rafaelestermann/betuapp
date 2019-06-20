using betuapp.Shared;
using Microsoft.EntityFrameworkCore;

namespace betuapp.Server.DataAccess
{
    public class BetContext : DbContext
    {
        public virtual DbSet<Bet> Bet { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-DMNQJI0\SQLEXPRESS;Initial Catalog=betudatabase;Integrated Security=True;");
            }
        }
    }
}