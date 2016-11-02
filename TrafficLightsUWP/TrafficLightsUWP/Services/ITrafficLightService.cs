using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrafficLightsUWP.Models;

namespace TrafficLightsUWP.Services
{
    public interface ITrafficLightService
    {
        
        IEnumerable<TrafficLight> GetAllTrafficLights();

        TrafficLight GetTrafficLightById(Guid id);

        TrafficLight AddTrafficLight(TrafficLight TrafficLight);

        void SaveTrafficLight(TrafficLight TrafficLight);

        void DeleteTrafficLight(TrafficLight TrafficLight);
}
}
