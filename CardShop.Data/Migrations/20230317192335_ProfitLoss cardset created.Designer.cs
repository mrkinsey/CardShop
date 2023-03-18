﻿// <auto-generated />
using CardShop.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CardShop.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230317192335_ProfitLoss cardset created")]
    partial class ProfitLosscardsetcreated
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CardShop.Data.Entities.CardSet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Format")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PurchasePrice")
                        .HasColumnType("float");

                    b.Property<int>("QuantityAvailable")
                        .HasColumnType("int");

                    b.Property<int>("QuantityPurchased")
                        .HasColumnType("int");

                    b.Property<double>("SalePrice")
                        .HasColumnType("float");

                    b.Property<string>("SetName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("CardSets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandName = "Topps",
                            CategoryId = 3,
                            Format = "Hobby",
                            PurchasePrice = 0.0,
                            QuantityAvailable = 0,
                            QuantityPurchased = 0,
                            SalePrice = 0.0,
                            SetName = "Series 1",
                            Value = 0.0,
                            Year = 2023
                        });
                });

            modelBuilder.Entity("CardShop.Data.Entities.CardSingle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CardName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CardSetId")
                        .HasColumnType("int");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Parallel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CardSetId");

                    b.ToTable("CardSingles");
                });

            modelBuilder.Entity("CardShop.Data.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Football"
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Basketball"
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Baseball"
                        },
                        new
                        {
                            Id = 4,
                            CategoryName = "Soccer"
                        },
                        new
                        {
                            Id = 5,
                            CategoryName = "TCG"
                        });
                });

            modelBuilder.Entity("CardShop.Data.Entities.CardSet", b =>
                {
                    b.HasOne("CardShop.Data.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("CardShop.Data.Entities.CardSingle", b =>
                {
                    b.HasOne("CardShop.Data.Entities.CardSet", "CardSet")
                        .WithMany()
                        .HasForeignKey("CardSetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CardSet");
                });
#pragma warning restore 612, 618
        }
    }
}
