﻿using HotelListingApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListingApi.Configurations.Entities
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
                new Hotel { Id = 1, Name = "Hotel Taj", Address = "Mumbai", Rating = 5.0, CountryId = 1 },
                new Hotel { Id = 2, Name = "Sonotel Hotel and Resorts", Address = "Dhanbad", Rating = 3.0, CountryId = 1 },
                new Hotel { Id = 3, Name = "CapeTown Sea View Hotel", Address = "Capetown", Rating = 4.0, CountryId = 2 },
                new Hotel { Id = 4, Name = "Trump Tower", Address = "New York", Rating = 4.3, CountryId = 3 },
                new Hotel { Id = 5, Name = "Burj Khalifa", Address = "Dubai", Rating = 5.0, CountryId = 4 }
                );
        }
    }
}
