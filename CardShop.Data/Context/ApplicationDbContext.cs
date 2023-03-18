using System.ComponentModel.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardShop.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CardShop.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CardSet> CardSets { get; set; }
        public DbSet<CardSingle> CardSingles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    CategoryName = "Football"
                },
                new Category
                {
                    Id = 2,
                    CategoryName = "Basketball"
                },
                new Category
                {
                    Id = 3,
                    CategoryName = "Baseball"
                },
                new Category
                {
                    Id = 4,
                    CategoryName = "Soccer"
                },
                new Category
                {
                    Id = 5,
                    CategoryName = "TCG"
                }
            );

            modelBuilder.Entity<CardSet>().HasData(
                new CardSet
                {
                    Id = 1,
                    BrandName = "Topps",
                    SetName = "Series 1",
                    Year = 2023,
                    Format = "Hobby",
                    CategoryId = 3,
                }
            );
        }
    }
}