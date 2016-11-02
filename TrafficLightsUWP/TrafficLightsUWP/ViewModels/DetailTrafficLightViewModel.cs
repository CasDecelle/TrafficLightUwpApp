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
    public class DetailTrafficLightViewModel : BaseViewModel
    {
        private IMaintenanceService _maintenanceService;
        private TrafficLight _trafficLight;

        public TrafficLight TrafficLight
        {
            get { return _trafficLight; }
            set { Set(ref _trafficLight, value); }
        }

        public ObservableCollection<Maintenance> Maintenances {
            get
            {
                var allMaintenances = _maintenanceService.GetAllMaintenances();
                return new ObservableCollection<Maintenance>(allMaintenances.Where(m => m.TrafficLight.Id.Equals(_trafficLight.Id)));
            }
        }


        public DetailTrafficLightViewModel(IMaintenanceService maintenanceService)
        {
            _maintenanceService = maintenanceService;
        }
    }
}
