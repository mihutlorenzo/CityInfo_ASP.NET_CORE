﻿using CityInfo.API.Entities;
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
            if(context.Cities.Any())
            {
                return;
            }

            var cities = new List<City>()
            {
                new City()
                {
                    Name = "New York City",
                    Description = "The one with that big park",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Name = "Central Park",
                            Description = "The most visited urban park in the United States."
                        },
                        new PointOfInterest()
                        {
                            Name = "Empire State Building",
                            Description ="A 102-story skyscraper located in Midtown Manhattan."
                        }
                    }
                },
                new City()
                {
                    Name = "Paris",
                    Description = "The one with that big tower",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Name = "Eiffel Tower",
                            Description = "The most visited urban park in the United States."
                        },
                        new PointOfInterest()
                        {
                            Name = "The Louvre",
                            Description ="The worl's largest museum."
                        }
                    }
                }
            };
            context.Cities.AddRange(cities);
            context.SaveChanges();
        }
    }
}
