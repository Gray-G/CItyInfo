using CityInfo.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public static class CityInfoContextExtensions
    {
        public static void EnsureSeedDataForContext(this CityInfoContext context)
        {
            if (context.Cities.Any())
            {
                return;
            }

            // Initalize seed data
            var cities = new List<City>()
            {
                new City()
                {
                    Name = "New York City",
                    Description = "The big apple.",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Name = "Central Park",
                            Description = "The most visited urban park in the U.S."
                        },
                        new PointOfInterest()
                        {
                            Name = "Empire State Building",
                            Description = "A 102-story skyscraper located in Miwn Manhattan."
                        },
                    }
                },
                new City()
                {
                    Name = "Antwerp",
                    Description = "Has a cathedral.",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Name = "Central Park",
                            Description = "The most visited urban park in the U.S."
                        },
                        new PointOfInterest()
                        {
                            Name = "Empire State Building",
                            Description = "A 102-story skyscraper located in Miwn Manhattan."
                        },
                    }
                },
                new City()
                {
                    Name = "Paris",
                    Description = "Eiffel tower.",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Name = "Central Park",
                            Description = "The most visited urban park in the U.S."
                        },
                        new PointOfInterest()
                        {
                            Name = "Empire State Building",
                            Description = "A 102-story skyscraper located in Miwn Manhattan."
                        },
                    }
                }
            };

            context.Cities.AddRange(cities);
            context.SaveChanges();

        }
    }
}
