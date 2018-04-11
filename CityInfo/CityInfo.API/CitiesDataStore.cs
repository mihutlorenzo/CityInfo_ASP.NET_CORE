using CityInfo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            

            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id=1,
                    Name="New York City",
                    Description="The one that big park.",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id=1,
                            Name="New York City",
                            Description="The one that big park.",
                        },
                        new PointOfInterestDto()
                        {
                            Id=2,
                            Name="New York City",
                            Description="The one that big park.",
                        }
                    }
                },
                 new CityDto()
                {
                    Id=2,
                    Name="Antwerp",
                    Description="The one with the cathedral was never really finished.",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id=1,
                            Name="New York City",
                            Description="The one that big park.",
                        }
                        
                    }
                },
                  new CityDto()
                {
                    Id=3,
                    Name="Paris",
                    Description="The tourn Eiffel is wonderfull."
                }
            };
        }
    }
}
