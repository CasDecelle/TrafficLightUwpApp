using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLightsUWP.Models
{

    public class TrafficLight
    {
        public Guid Id { get; set; }
        public Location Location { get; set; }
        public DateTimeOffset PlacementDate { get; set; }
        public TrafficLightStatus Status { get; set; }
        public bool IsPlaced { get; set; }
        public int NumberOfSecsGreen { get; set; }
        public int NumberOfSecsOrange { get; set; }
        public int NumberOfSecsRed { get; set; }
        public TrafficLightDirection Direction { get; set; }
        public DateTime ActiveSince { get; set; }
    }
    public enum TrafficLightStatus
    {
        Active,
        Inactive,
        Defective
    }

    public enum TrafficLightDirection
    {
        N,
        NE,
        E,
        SE,
        S,
        SW,
        W,
        NW
    }
}
