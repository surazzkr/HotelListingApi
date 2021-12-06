
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

//DTO (Data transfer Object): It acts as a middleware in interaction from user and prevent user from directly accessing the Models classes.
namespace HotelListingApi.DTO
{
    public class CreateCountryDTO
    {
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Country Name is too long")]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 3, ErrorMessage = "Short Country Name is too long")]
        public string ShortName { get; set; }
    }
    public class CountryDTO: CreateCountryDTO
    {
        public int Id { get; set; }
        public IList<HotelDTO> Hotels { get; set; }

    }
}
