using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using SPVT.Models;
using System.Web;


namespace SPVT.Models
{
    public class SPVTDbContext : DbContext 
    {
        public SPVTDbContext(DbContextOptions<SPVTDbContext> options)   : base(options)
        {

        }
        public DbSet<Automobile> Automobile { get; set;}

    }
}