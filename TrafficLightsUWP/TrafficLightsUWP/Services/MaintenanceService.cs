using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrafficLightsUWP.Models;

namespace TrafficLightsUWP.Services
{
    public class MaintenanceService
    {
        private List<Maintenance> fakeMaintenances = new List<Maintenance>()
        {
            new Maintenance
            {
                 Id = new Guid("7b1911aa-933f-48ce-b431-5bbff70c4090"),
                Price = 1000M,
                Description = "Cleaning of the trafficlight",
                Reason = "Trafficlight was vandalised by a prostitute from de Zwarte kat",
                TrafficLight = new TrafficLight
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

                   }
            },

            new Maintenance
            {
                 Id = new Guid("7b1911aa-933f-48ce-b431-5bbff70c4091"),
                Price = 1000000M,
                Description = "Replacing the trafficlight",
                Reason = "Trafficlight was destroyed by a terrorist who blew himself up in the swimming pool",
                TrafficLight = new TrafficLight
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

                    }
            }

        };


        public IEnumerable<Maintenance> GetAllMaintenances()
        {
            return fakeMaintenances;
        }

        public Maintenance GetMaintenanceById(Guid id)
        {
            return fakeMaintenances
                .Where(l => l.Id == id)
                .FirstOrDefault();
        }

        public Maintenance AddMaintenance(Maintenance Maintenance)
        {
            Maintenance.Id = Guid.NewGuid();
            fakeMaintenances.Add(Maintenance);
            return Maintenance;
        }

        public void SaveMaintenance(Maintenance Maintenance)
        {
            Maintenance oldMaintenance = fakeMaintenances.
                Where(l => l.Id == Maintenance.Id)
                .FirstOrDefault();

            if (oldMaintenance == null)
            {
                AddMaintenance(Maintenance);
                return;
            }

            oldMaintenance.Price = Maintenance.Price;
            oldMaintenance.Description = Maintenance.Description;
            oldMaintenance.Reason = Maintenance.Reason;
        }

        public void DeleteMaintenance(Maintenance Maintenance)
        {
            fakeMaintenances.Remove(Maintenance);
        }


    }
}
