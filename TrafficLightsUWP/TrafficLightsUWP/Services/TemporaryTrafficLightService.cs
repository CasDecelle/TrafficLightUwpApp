using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrafficLightsUWP.Models;

namespace TrafficLightsUWP.Services
{
    public class TemporaryTrafficLightService
    {
        private List<TemporaryTrafficLight> fakeTemporaryTrafficLights = new List<TemporaryTrafficLight>()
        {
           new TemporaryTrafficLight
           {
               Id = new Guid("7b1911aa-933f-48ce-b431-5bbff70c4010"),
               ActiveSince = DateTime.Now,
               Direction = TrafficLightDirection.E,
               IsPlaced = true,
               PlacementDate = DateTime.Now,
               Status = TrafficLightStatus.Active,
               NumberOfSecsGreen = 30,
               NumberOfSecsOrange= 7,
               NumberOfSecsRed = 1000,
               Location = new Location { Id = new Guid("7b1911aa-933f-48ce-b431-5bbff70c4070"), Name = "Zwarte kat Halle", Coordinates = null },
               EndDate = DateTime.Now.AddDays(10),
               Reason = "Werken"

           },
           new TemporaryTrafficLight
           {
               Id = new Guid("7b1911aa-933f-48ce-b431-5bbff70c4011"),
               ActiveSince = DateTime.Now,
               Direction = TrafficLightDirection.N,
               IsPlaced = false,
               Status = TrafficLightStatus.Inactive,
               NumberOfSecsGreen = 30,
               NumberOfSecsOrange= 7,
               NumberOfSecsRed = 1000,
               Location = new Location { Id = new Guid("7b1911aa-933f-48ce-b431-5bbff70c4071"), Name = "Zwembad Halle", Coordinates = null },
               EndDate = DateTime.Now.AddDays(10),
               Reason = "Werken",
               Extended = true,
               ExtendReason = "Niet af"

           }
        };


        public IEnumerable<TemporaryTrafficLight> GetAllTemporaryTrafficLights()
        {
            return fakeTemporaryTrafficLights;
        }

        public TemporaryTrafficLight GetTemporaryTrafficLightById(Guid id)
        {
            return fakeTemporaryTrafficLights
                .Where(l => l.Id == id)
                .FirstOrDefault();
        }

        public TemporaryTrafficLight AddTemporaryTrafficLight(TemporaryTrafficLight TemporaryTrafficLight)
        {
            TemporaryTrafficLight.Id = Guid.NewGuid();
            fakeTemporaryTrafficLights.Add(TemporaryTrafficLight);
            return TemporaryTrafficLight;
        }

        public void SaveTemporaryTrafficLight(TemporaryTrafficLight TemporaryTrafficLight)
        {
            TemporaryTrafficLight oldTemporaryTrafficLight = fakeTemporaryTrafficLights.
                Where(l => l.Id == TemporaryTrafficLight.Id)
                .FirstOrDefault();

            if (oldTemporaryTrafficLight == null)
            {
                AddTemporaryTrafficLight(TemporaryTrafficLight);
                return;
            }

            oldTemporaryTrafficLight.ActiveSince = TemporaryTrafficLight.ActiveSince;
            oldTemporaryTrafficLight.Direction = TemporaryTrafficLight.Direction;
            oldTemporaryTrafficLight.IsPlaced = TemporaryTrafficLight.IsPlaced;
            oldTemporaryTrafficLight.Location = TemporaryTrafficLight.Location;
            oldTemporaryTrafficLight.NumberOfSecsGreen = TemporaryTrafficLight.NumberOfSecsGreen;
            oldTemporaryTrafficLight.NumberOfSecsOrange = TemporaryTrafficLight.NumberOfSecsOrange;
            oldTemporaryTrafficLight.NumberOfSecsRed = TemporaryTrafficLight.NumberOfSecsRed;
            oldTemporaryTrafficLight.PlacementDate = TemporaryTrafficLight.PlacementDate;
            oldTemporaryTrafficLight.Status = TemporaryTrafficLight.Status;

            oldTemporaryTrafficLight.Extended = TemporaryTrafficLight.Extended;
            oldTemporaryTrafficLight.ExtendReason = TemporaryTrafficLight.ExtendReason;
            oldTemporaryTrafficLight.Reason = TemporaryTrafficLight.Reason ;
            oldTemporaryTrafficLight.EndDate = TemporaryTrafficLight.EndDate;
        }

        public void DeleteTemporaryTrafficLight(TemporaryTrafficLight TemporaryTrafficLight)
        {
            fakeTemporaryTrafficLights.Remove(TemporaryTrafficLight);
        }
    }
}
