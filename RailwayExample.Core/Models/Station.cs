using System.Collections.Generic;

namespace RailwayExample.Core.Models
{
    public class Station
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool Open { get; set; }
        public List<StationPlatform> Platforms { get; set; }
    }
}