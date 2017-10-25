using Microsoft.EntityFrameworkCore;

namespace SPVT.Models
{
    public class ViolationsContext : DbContext
    {
        public ViolationsContext (DbContextOptions<ViolationsContext> options) : base(options)
        {

        }

        public DbSet<SPVT.Models.Automobile> Automobile { get; set;}
    }
}