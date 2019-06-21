using betuapp.Shared;
using Microsoft.EntityFrameworkCore;

namespace betuapp.Server.DataAccess
{
    public class AcceptanceCritereaContext : DbContext
    {
        public virtual DbSet<AcceptanceCriterea> AcceptanceCriterea { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=tcp:betuserveer.database.windows.net,1433;Initial Catalog=betudatabase;Persist Security Info=False;User ID=admin123;Password=Waldweg13;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }
    }
}