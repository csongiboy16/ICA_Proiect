﻿// <auto-generated />
using System;
using Ienei_Csongor_Attila_Proiect_ASP_NET.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ienei_Csongor_Attila_Proiect_ASP_NET.Migrations
{
    [DbContext(typeof(Ienei_Csongor_Attila_Proiect_ASP_NETContext))]
    [Migration("20220114194134_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ienei_Csongor_Attila_Proiect_ASP_NET.Models.CarDealership", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarID");

                    b.Property<int?>("CarsID");

                    b.Property<int>("DealershipID");

                    b.HasKey("ID");

                    b.HasIndex("CarsID");

                    b.HasIndex("DealershipID");

                    b.ToTable("CarDealership");
                });

            modelBuilder.Entity("Ienei_Csongor_Attila_Proiect_ASP_NET.Models.Cars", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Make");

                    b.Property<string>("Model");

                    b.Property<int>("SalesID");

                    b.Property<decimal>("Year")
                        .HasColumnType("decimal(6, 4)");

                    b.HasKey("ID");

                    b.HasIndex("SalesID");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("Ienei_Csongor_Attila_Proiect_ASP_NET.Models.Dealership", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CarsID");

                    b.Property<string>("DealershipName");

                    b.HasKey("ID");

                    b.HasIndex("CarsID");

                    b.ToTable("Dealership");
                });

            modelBuilder.Entity("Ienei_Csongor_Attila_Proiect_ASP_NET.Models.Sales", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SalesName");

                    b.HasKey("ID");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("Ienei_Csongor_Attila_Proiect_ASP_NET.Models.CarDealership", b =>
                {
                    b.HasOne("Ienei_Csongor_Attila_Proiect_ASP_NET.Models.Cars", "Cars")
                        .WithMany()
                        .HasForeignKey("CarsID");

                    b.HasOne("Ienei_Csongor_Attila_Proiect_ASP_NET.Models.Dealership", "Dealership")
                        .WithMany("CarDealership")
                        .HasForeignKey("DealershipID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ienei_Csongor_Attila_Proiect_ASP_NET.Models.Cars", b =>
                {
                    b.HasOne("Ienei_Csongor_Attila_Proiect_ASP_NET.Models.Sales", "Sales")
                        .WithMany("Cars")
                        .HasForeignKey("SalesID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ienei_Csongor_Attila_Proiect_ASP_NET.Models.Dealership", b =>
                {
                    b.HasOne("Ienei_Csongor_Attila_Proiect_ASP_NET.Models.Cars")
                        .WithMany("Dealership")
                        .HasForeignKey("CarsID");
                });
#pragma warning restore 612, 618
        }
    }
}
