using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;

namespace TrafficLightsUWP.Models
{
    public class Location
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Geocoordinate Coordinates { get; set; }
    }
}
