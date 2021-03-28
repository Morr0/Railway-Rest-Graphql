using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RailwayExample.Core;

namespace RailwayExample.RestApi.Controllers
{
    [ApiController]
    [Route("rest/train")]
    public class TrainController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetTrains()
        {
            var trains = Data.Trains;
            return Ok(trains);
        }

        [HttpGet("{id}")]
        public IActionResult GetTrain([FromRoute] string id)
        {
            var train = Data.Trains.Where(x => x.Id == id)
                .FirstOrDefault();

            return train is null ? NotFound() : Ok(train);
        }
    }
}