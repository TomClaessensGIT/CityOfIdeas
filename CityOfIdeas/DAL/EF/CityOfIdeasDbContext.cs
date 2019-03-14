using Microsoft.EntityFrameworkCore;
using CID.BL.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Logging;

namespace CID.DAL.EF
{
    internal class CityOfIdeasDbContext : DbContext
    {
        public CityOfIdeasDbContext()
        {
            CityOfIdeasDbInitializer.Initialize(this, true);
        }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Ideation> Ideations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=CityOfIdeas_EFCodeFirst.db");

            // configure lazy-loading: requires ALL navigation-properties to be 'virtual'!!
            //optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
