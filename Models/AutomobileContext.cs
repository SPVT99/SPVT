using Microsoft.EntityFrameworkCore;

namespace SPVT.Models
{
    public class AutomobileContext : DbContext
    {
        public AutomobileContext (DbContextOptions<AutomobileContext> options) : base(options)
        {

        }

        public DbSet<SPVT.Models.Cars> Cars { get; set;}
    }
}