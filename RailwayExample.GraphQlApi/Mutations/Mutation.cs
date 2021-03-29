using System.Linq;
using RailwayExample.Core;
using RailwayExample.GraphQlApi.Dtos;

namespace RailwayExample.GraphQlApi.Mutations
{
    public class Mutation
    {
        public MutationResult AddService(AddServiceToStationDto dto)
        {
            var station = Data.Stations.FirstOrDefault(x => x.Id == dto.StationId);
            if (station is null) return new MutationResult
            {
                Error = "No such station"
            };

            var platform = station.Platforms.FirstOrDefault(x => x.Number == dto.PlatformNo);
            if (platform is null) return new MutationResult
            {
                Error = "No such platform"
            };

            platform.Service = dto.Service;

            return new MutationResult();
        }
    }
}