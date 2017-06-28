using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Models
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }
        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public CitiesDataStore()
        {
            // Initialize dummy data
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The big apple."
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Antwerp",
                    Description = "Has a cathedral."
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Paris",
                    Description = "Eiffel tower."
                }
            };
        }
    }
}
