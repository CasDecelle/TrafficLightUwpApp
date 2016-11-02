using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrafficLightsUWP.Models;
using Windows.Devices.Geolocation;

namespace TrafficLightsUWP.Services
{
    
    

    public class LocationService
    {
        private List<Location> fakeLocations = new List<Location>()
        {
            new Location { Id = new Guid("7b1911aa-933f-48ce-b431-5bbff70c4070"), Name = "Zwarte kat Halle", Coordinates = null },
            new Location { Id = new Guid("7b1911aa-933f-48ce-b431-5bbff70c4071"), Name = "Zwembad Halle", Coordinates = null },
            new Location { Id = new Guid("7b1911aa-933f-48ce-b431-5bbff70c4072"), Name = "McDo Halle", Coordinates = null },
            new Location { Id = new Guid("7b1911aa-933f-48ce-b431-5bbff70c4073"), Name = "Stroppen Halle", Coordinates = null },
            new Location { Id = new Guid("7b1911aa-933f-48ce-b431-5bbff70c4074"), Name = "Station Halle", Coordinates = null },
            new Location { Id = new Guid("7b1911aa-933f-48ce-b431-5bbff70c4075"), Name = "Don Bosco Halle", Coordinates = null },
            new Location { Id = new Guid("7b1911aa-933f-48ce-b431-5bbff70c4076"), Name = "Heilig Hart Halle", Coordinates = null },
            new Location { Id = new Guid("7b1911aa-933f-48ce-b431-5bbff70c4077"), Name = "Atheneneum Halle", Coordinates = null },

        };

        public IEnumerable<Location> GetAllLocations()
        {
            return fakeLocations;
        }

        public Location GetLocationById(Guid id)
        {
            return fakeLocations
                .Where(l => l.Id == id)
                .FirstOrDefault();
        }

        public Location AddLocation(Location location)
        {
            location.Id = Guid.NewGuid();
            fakeLocations.Add(location);
            return location;
        }

        public void SaveLocation(Location location)
        {
            Location oldLocation = fakeLocations.
                Where(l => l.Id == location.Id)
                .FirstOrDefault();

            if (oldLocation == null)
            {
                AddLocation(location);
                return;
            }

            oldLocation.Name = location.Name;
            oldLocation.Coordinates = location.Coordinates;                 
        }

        public void DeleteLocation(Location location)
        {
            fakeLocations.Remove(location);
        }
    }
}
