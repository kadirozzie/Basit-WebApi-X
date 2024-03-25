using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace Futbolcular
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Database=Footballer; Trusted_Connection=True; MultipleActiveResultSets=true");
            
        }
        public DbSet<Footballer> Footballers { get; set; }
    }
}
