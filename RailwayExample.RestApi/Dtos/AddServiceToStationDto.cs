using RailwayExample.Core.Models;

namespace RailwayExample.RestApi.Dtos
{
    public class AddServiceToStationDto
    {
        public TrainService Service { get; set; }
        public int Platform { get; set; }
    }
}