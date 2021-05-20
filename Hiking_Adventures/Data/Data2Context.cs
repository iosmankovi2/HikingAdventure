using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hiking_Adventures.Models;

namespace Hiking_Adventures.Data
{
    public class Data2Context : DbContext
    {
        public Data2Context (DbContextOptions<Data2Context> options)
            : base(options)
        {
        }

        public DbSet<Hiking_Adventures.Models.PrijavaRute> PrijavaRute { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<PrijavaRute>().ToTable("PrijaveRuta");

        }
    }
}
