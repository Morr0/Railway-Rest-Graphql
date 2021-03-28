using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RailwayExample.Core;
using RailwayExample.RestApi.Dtos;

namespace RailwayExample.RestApi.Controllers
{
    [ApiController]
    [Route("rest/station")]
    public class StationController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetStations()
        {
            var stations = Data.Stations;
            return Ok(stations);
        }

        [HttpGet("{id}")]
        public IActionResult GetStation([FromRoute] string id)
        {
            var station = Data.Stations.FirstOrDefault(x => x.Id == id);

            return station is null ? NotFound() : Ok(station);
        }

        [HttpPut("{stationId}")]
        public IActionResult AddService([FromRoute] string stationId, [FromBody] AddServiceToStationDto dto)
        {
            var station = Data.Stations.FirstOrDefault(x => x.Id == stationId);
            if (station is null) return BadRequest(new
            {
                Error = "Station does not exist"
            });

            var platform = station.Platforms.FirstOrDefault(x => x.Number == dto.Platform);
            if (platform is null) return NotFound(new
            {
                Error = "Platform does not exist"
            });
            
            platform.Service = dto.Service;

            return Ok();
        }

        [HttpGet("{stationId}/{platformNo:int}")]
        public IActionResult GetService([FromRoute] string stationId, [FromRoute] int platformNo)
        {
            var station = Data.Stations.FirstOrDefault(x => x.Id == stationId);
            if (station is null) return BadRequest(new
            {
                Error = "Station does not exist"
            });

            var platform = station.Platforms.FirstOrDefault(x => x.Number == platformNo);
            if (platform is null) return NotFound(new
            {
                Error = "Platform does not exist"
            });

            return Ok(platform.Service);
        }
    }
}