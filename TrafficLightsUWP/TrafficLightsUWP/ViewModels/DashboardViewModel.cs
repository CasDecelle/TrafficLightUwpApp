using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrafficLightsUWP.Models;
using TrafficLightsUWP.Services;

namespace TrafficLightsUWP.ViewModels
{
    public class DashboardViewModel : BaseViewModel
    {
        private ITrafficLightService _trafficLightService;

        private TrafficLight _selectedTrafficLight;

        public TrafficLight SelectedTrafficLight
        {
            get
            {
                return _selectedTrafficLight;
            }
            set
            {
                if (value != null)
                    NavigateToDetailTrafficLight(value);
            }
        }

        public ObservableCollection<TrafficLight> ActiveTrafficLights { get; set; }
        public ObservableCollection<TrafficLight> InactiveTrafficLights { get; set; }
        public ObservableCollection<TrafficLight> DefectiveTrafficLights { get; set; }

        public DashboardViewModel(ITrafficLightService trafficLightService)
        {
            _trafficLightService = trafficLightService;
            Title = "Dashboard";
            GetData();
        }

        private void GetData()
        {
            var trafficLights = _trafficLightService.GetAllTrafficLights();
            ActiveTrafficLights = new ObservableCollection<TrafficLight>(trafficLights.Where(t => t.Status == TrafficLightStatus.Active));
            InactiveTrafficLights = new ObservableCollection<TrafficLight>(trafficLights.Where(t => t.Status == TrafficLightStatus.Inactive));
            DefectiveTrafficLights = new ObservableCollection<TrafficLight>(trafficLights.Where(t => t.Status == TrafficLightStatus.Defective));
        }
    }
}
