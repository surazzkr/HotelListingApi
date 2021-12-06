using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListingApi.Models
{

    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country { Id = 1, Name = "India", ShortName = "IND" },
                new Country { Id = 2, Name = "Australia", ShortName = "AUS" },
                new Country { Id = 3, Name = "United States of America", ShortName = "USA" },
                new Country { Id = 4, Name = "United Emirates", ShortName = "UAE" }
                );
            builder.Entity<Hotel>().HasData(
                new Hotel { Id = 1, Name = "Hotel Taj", Address = "Mumbai", Rating = 5.0, CountryId = 1 },
                new Hotel { Id = 2, Name = "Sonotel Hotel and Resorts", Address = "Dhanbad", Rating = 3.0, CountryId = 1 },
                new Hotel { Id = 3, Name = "CapeTown Sea View Hotel", Address = "Capetown", Rating = 4.0, CountryId = 2 },
                new Hotel { Id = 4, Name = "Trump Tower", Address = "New York", Rating = 4.3, CountryId = 3 },
                new Hotel { Id = 5, Name = "Burj Khalifa", Address = "Dubai", Rating = 5.0, CountryId = 4 }
                );
        }
    }
}
