﻿// <auto-generated />
using HotelListingApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HotelListingApi.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20211206061050_SeedingData")]
    partial class SeedingData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("HotelListingApi.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "India",
                            ShortName = "IND"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Australia",
                            ShortName = "AUS"
                        },
                        new
                        {
                            Id = 3,
                            Name = "United States of America",
                            ShortName = "USA"
                        },
                        new
                        {
                            Id = 4,
                            Name = "United Emirates",
                            ShortName = "UAE"
                        });
                });

            modelBuilder.Entity("HotelListingApi.Models.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Mumbai",
                            CountryId = 1,
                            Name = "Hotel Taj",
                            Rating = 5.0
                        },
                        new
                        {
                            Id = 2,
                            Address = "Dhanbad",
                            CountryId = 1,
                            Name = "Sonotel Hotel and Resorts",
                            Rating = 3.0
                        },
                        new
                        {
                            Id = 3,
                            Address = "Capetown",
                            CountryId = 2,
                            Name = "CapeTown Sea View Hotel",
                            Rating = 4.0
                        },
                        new
                        {
                            Id = 4,
                            Address = "New York",
                            CountryId = 3,
                            Name = "Trump Tower",
                            Rating = 4.2999999999999998
                        },
                        new
                        {
                            Id = 5,
                            Address = "Dubai",
                            CountryId = 4,
                            Name = "Burj Khalifa",
                            Rating = 5.0
                        });
                });

            modelBuilder.Entity("HotelListingApi.Models.Hotel", b =>
                {
                    b.HasOne("HotelListingApi.Models.Country", "Country")
                        .WithMany("Hotels")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("HotelListingApi.Models.Country", b =>
                {
                    b.Navigation("Hotels");
                });
#pragma warning restore 612, 618
        }
    }
}
