﻿// <auto-generated />
using FoodAPI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FoodAPI.Migrations
{
    [DbContext(typeof(FoodDbContext))]
    [Migration("20210228153808_initial_migration")]
    partial class initial_migration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FoodDataApp.Core.Food", b =>
                {
                    b.Property<int>("FoodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Calories")
                        .HasColumnType("float");

                    b.Property<double>("Carbohydrates")
                        .HasColumnType("float");

                    b.Property<double>("Cholestrol")
                        .HasColumnType("float");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("Fat")
                        .HasColumnType("float");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("Potassium")
                        .HasColumnType("float");

                    b.Property<double>("Protein")
                        .HasColumnType("float");

                    b.Property<double>("Sodium")
                        .HasColumnType("float");

                    b.Property<string>("Vitamin")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FoodId");

                    b.ToTable("Foods");

                    b.HasData(
                        new
                        {
                            FoodId = 1,
                            Calories = 95.0,
                            Carbohydrates = 25.0,
                            Cholestrol = 0.0,
                            Description = "This is an apple",
                            Fat = 0.29999999999999999,
                            Image = "https://www.busybeecandles.co.uk/wp-content/uploads/2013/08/apple-benefits32.jpg",
                            Name = "APPLE",
                            Potassium = 195.0,
                            Protein = 0.5,
                            Sodium = 1.8,
                            Vitamin = "A"
                        },
                        new
                        {
                            FoodId = 2,
                            Calories = 95.0,
                            Carbohydrates = 25.0,
                            Cholestrol = 0.0,
                            Description = "This is an apple",
                            Fat = 0.29999999999999999,
                            Image = "https://assets.vogue.com/photos/5deec371e52fbd00086eb68b/16:9/w_2959,h_1664,c_limit/promo-banana.jpg",
                            Name = "BANANA",
                            Potassium = 195.0,
                            Protein = 0.5,
                            Sodium = 1.8,
                            Vitamin = "B"
                        },
                        new
                        {
                            FoodId = 3,
                            Calories = 95.0,
                            Carbohydrates = 25.0,
                            Cholestrol = 0.0,
                            Description = "This is an apple",
                            Fat = 0.29999999999999999,
                            Image = "https://5.imimg.com/data5/KA/KH/MY-22541476/stark-crimson-pears-500x500.jpg",
                            Name = "PEAR",
                            Potassium = 195.0,
                            Protein = 0.5,
                            Sodium = 1.8,
                            Vitamin = "C"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
