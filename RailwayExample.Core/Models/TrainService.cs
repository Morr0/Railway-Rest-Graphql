namespace RailwayExample.Core.Models
{
    public class TrainService
    {
        public string Id { get; set; }
        public Train Train { get; set; }
        public double CurrentSpeed { get; set; }
        public int CurrentPassengers { get; set; }
        public string DriverId { get; set; }
    }
}