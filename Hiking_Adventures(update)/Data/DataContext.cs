using Hiking_Adventure.Models;
using Hiking_Adventures.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hiking_Adventures_update_.Data
{
    public class DataContext : IdentityDbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Hiking_Adventure.Models.Ruta> Ruta { get; set; }
        public DbSet<Hiking_Adventures.Models.PrijavaRute> PrijavaRute { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Ruta>().ToTable("Rute");
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PrijavaRute>().ToTable("PrijaveRuta");
            base.OnModelCreating(modelBuilder);

        }

      


   
    }
}
