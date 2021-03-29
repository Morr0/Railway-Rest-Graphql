using RailwayExample.Core.Models;

namespace RailwayExample.GraphQlApi.Dtos
{
    public class AddServiceToStationDto
    {
        public string StationId { get; set; }
        public int PlatformNo { get; set; }
        public TrainService Service { get; set; }
    }
}