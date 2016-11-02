using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLightsUWP.Models
{
    public class Maintenance
    {
        public Guid Id { get; set; }
        public TrafficLight TrafficLight { get; set; }
        public string Reason { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
