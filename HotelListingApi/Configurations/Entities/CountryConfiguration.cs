using HotelListingApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListingApi.Configurations.Entities
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
                new Country { Id = 1, Name = "India", ShortName = "IND" },
                new Country { Id = 2, Name = "Australia", ShortName = "AUS" },
                new Country { Id = 3, Name = "United States of America", ShortName = "USA" },
                new Country { Id = 4, Name = "United Emirates", ShortName = "UAE" }
                );
        }
    }
}
