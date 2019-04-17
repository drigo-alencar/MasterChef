using MasterChef.Core.TypeConfigurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasterChef.Core
{
    public class MasterChefContext : DbContext
    {
        public MasterChefContext(DbContextOptions options) : base(options) { }

        public virtual DbSet<Category> Categories { get; set; }

        public virtual DbSet<Recipe> Recipes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new RecipeEntityTypeConfiguration());
        }
    }
}
