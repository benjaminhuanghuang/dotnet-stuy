﻿using Microsoft.EntityFrameworkCore;
using SuperHeroAPI.Models;

namespace SuperHeroAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=SuperHeroDB;Trusted_Connection=True;TrustServerCertificate=True");
        }

        public DbSet<SuperHero> SuperHeros { get; set; }
    }
}
