using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hiking_Adventure.Models;

namespace Hiking_Adventures.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext (DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Hiking_Adventure.Models.Ruta> Ruta { get; set; }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Ruta>().ToTable("Rute");
         
        }

    }
}
