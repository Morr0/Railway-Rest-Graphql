namespace RailwayExample.Core.Models
{
    public class Train
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Carriages { get; set; }
        public bool Diesel { get; set; }
        public double Length { get; set; }
        public bool Usable { get; set; }
        public bool IsPedestrian { get; set; }
    }
}