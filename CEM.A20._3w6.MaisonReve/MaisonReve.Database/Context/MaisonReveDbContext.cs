using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text;
using MaisonReve.Database.Models;

namespace MaisonReve.Database.Context
{
    class MaisonReveDbContext : DbContext
    {
        public DbSet<Building> Buildings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
