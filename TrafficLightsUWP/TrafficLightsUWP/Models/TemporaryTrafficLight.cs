using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLightsUWP.Models
{
    public class TemporaryTrafficLight : TrafficLight
    {
        public string Reason { get; set; }
        public DateTime EndDate { get; set; }
        public bool Extended { get; set; }
        public string ExtendReason { get; set; }
    }
}
