using System.Collections.Generic;
using RailwayExample.Core.Models;

namespace RailwayExample.Core
{
    public static class Data
    {
        public static List<Train> Trains = new List<Train>()
        {
            new Train
            {
                Id = "1a",
                Carriages = 7,
                Diesel = false,
                Length = 130,
                Name = "White Shark",
                Usable = true,
                IsPedestrian = true
            },
            new Train
            {
                Id = "1b",
                Carriages = 7,
                Diesel = true,
                Length = 130,
                Name = "White Fish",
                Usable = true,
                IsPedestrian = true
            },
        };

        public static List<Station> Stations = new List<Station>()
        {
            new Station
            {
                Id = "123",
                Name = "Sydney",
                Open = true,
                Platforms = new List<StationPlatform>()
                {
                    new StationPlatform
                    {
                        Number = 1,
                        Capacity = 8,
                        Occupied = false,
                        Service = null
                    },
                    new StationPlatform
                    {
                        Number = 2,
                        Capacity = 8,
                        Occupied = false,
                        Service = null
                    },
                    new StationPlatform
                    {
                        Number = 3,
                        Capacity = 12,
                        Occupied = false,
                        Service = null
                    }
                }
            },
            new Station
            {
                Id = "1222",
                Name = "Dubai",
                Open = false,
                Platforms = new List<StationPlatform>()
                {
                    new StationPlatform
                    {
                        Number = 1,
                        Capacity = 12,
                        Occupied = false,
                        Service = null
                    },
                    new StationPlatform
                    {
                        Number = 2,
                        Capacity = 12,
                        Occupied = false,
                        Service = null
                    }
                }
            }
        };
    }
}