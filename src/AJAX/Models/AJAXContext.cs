using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AJAX.Models
{
    public class AJAXContext : DbContext
    {
        public AJAXContext() { }

        public virtual DbSet<Destination> Destinations { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=AJAX;integrated security = True");
        }

        public AJAXContext(DbContextOptions<AJAXContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
