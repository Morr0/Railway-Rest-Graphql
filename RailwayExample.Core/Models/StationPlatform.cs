namespace RailwayExample.Core.Models
{
    public class StationPlatform
    {
        public int Number { get; set; }
        public TrainService Service { get; set; }
        public bool Occupied { get; set; }
        public int Capacity { get; set; }
    }
}