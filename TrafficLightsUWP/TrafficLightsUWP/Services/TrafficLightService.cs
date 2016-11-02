using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrafficLightsUWP.Models;

namespace TrafficLightsUWP.Services
{
    public class TrafficLightService
    {

        private List<TrafficLight> fakeTrafficLights = new List<TrafficLight>()
        {
           new TrafficLight
           {
               Id = new Guid("7b1911aa-933f-48ce-b431-5bbff70c4080"),
               ActiveSince = DateTime.Now,
               Direction = TrafficLightDirection.E,
               IsPlaced = true,
               PlacementDate = DateTime.Now,
               Status = TrafficLightStatus.Active,
               NumberOfSecsGreen = 30,
               NumberOfSecsOrange= 7,
               NumberOfSecsRed = 1000,
               Location = new Location { Id = new Guid("7b1911aa-933f-48ce-b431-5bbff70c4070"), Name = "Zwarte kat Halle", Coordinates = null }

           },
           new TrafficLight
           {
               Id = new Guid("7b1911aa-933f-48ce-b431-5bbff70c4081"),
               ActiveSince = DateTime.Now,
               Direction = TrafficLightDirection.N,
               IsPlaced = false,
               Status = TrafficLightStatus.Inactive,
               NumberOfSecsGreen = 30,
               NumberOfSecsOrange= 7,
               NumberOfSecsRed = 1000,
               Location = new Location { Id = new Guid("7b1911aa-933f-48ce-b431-5bbff70c4071"), Name = "Zwembad Halle", Coordinates = null }

           },
           new TrafficLight
           {
               Id = new Guid("7b1911aa-933f-48ce-b431-5bbff70c4082"),
               ActiveSince = DateTime.Now,
               Direction = TrafficLightDirection.S,
               IsPlaced = true,
               PlacementDate = DateTime.Now,
               Status = TrafficLightStatus.Defective,
               NumberOfSecsGreen = 30,
               NumberOfSecsOrange= 7,
               NumberOfSecsRed = 1000,
               Location =  new Location { Id = new Guid("7b1911aa-933f-48ce-b431-5bbff70c4072"), Name = "McDo Halle", Coordinates = null }

           }
        };


        public IEnumerable<TrafficLight> GetAllTrafficLights()
        {
            return fakeTrafficLights;
        }

        public TrafficLight GetTrafficLightById(Guid id)
        {
            return fakeTrafficLights
                .Where(l => l.Id == id)
                .FirstOrDefault();
        }

        public TrafficLight AddTrafficLight(TrafficLight TrafficLight)
        {
            TrafficLight.Id = Guid.NewGuid();
            fakeTrafficLights.Add(TrafficLight);
            return TrafficLight;
        }

        public void SaveTrafficLight(TrafficLight TrafficLight)
        {
            TrafficLight oldTrafficLight = fakeTrafficLights.
                Where(l => l.Id == TrafficLight.Id)
                .FirstOrDefault();

            if (oldTrafficLight == null)
            {
                AddTrafficLight(TrafficLight);
                return;
            }

            oldTrafficLight.ActiveSince = TrafficLight.ActiveSince;
            oldTrafficLight.Direction = TrafficLight.Direction;
            oldTrafficLight.IsPlaced = TrafficLight.IsPlaced;
            oldTrafficLight.Location = TrafficLight.Location;
            oldTrafficLight.NumberOfSecsGreen = TrafficLight.NumberOfSecsGreen;
            oldTrafficLight.NumberOfSecsOrange = TrafficLight.NumberOfSecsOrange;
            oldTrafficLight.NumberOfSecsRed = TrafficLight.NumberOfSecsRed;
            oldTrafficLight.PlacementDate = TrafficLight.PlacementDate;
            oldTrafficLight.Status = TrafficLight.Status;
        }

        public void DeleteTrafficLight(TrafficLight TrafficLight)
        {
            fakeTrafficLights.Remove(TrafficLight);
        }
    }
}
