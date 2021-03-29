using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using RailwayExample.Core;
using RailwayExample.Core.Models;

namespace RailwayExample.GraphQlApi.Queries
{
    public class Query
    {
        public Train GetTrain([Required] string id)
        {
            return Data.Trains.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Train> GetTrains()
        {
            return Data.Trains;
        }

        public Station GetStation([Required] string id)
        {
            return Data.Stations.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Station> GetStations()
        {
            return Data.Stations;
        }
    }
}