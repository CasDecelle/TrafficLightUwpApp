using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrafficLightsUWP.Models;

namespace TrafficLightsUWP.ViewModels
{
    public class DetailTrafficLightViewModel : BaseViewModel
    {
        private TrafficLight _trafficLight;

        public TrafficLight TrafficLight
        {
            get { return _trafficLight; }
            set { Set(ref _trafficLight, value); }
        }

    }
}
