using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrafficLightsUWP.Models;
using Windows.UI.Xaml.Navigation;

namespace TrafficLightsUWP.ViewModels
{
    public class AddMaintenanceViewModel : BaseViewModel
    {
        private Maintenance _newMaintenance;

        public Maintenance NewMaintenance
        {
            get { return _newMaintenance; }
            set { Set(ref _newMaintenance, value); }
        }

        public AddMaintenanceViewModel()
        {
            Title = "Add Maintenance";
            _newMaintenance = new Maintenance();
        }

        internal void SaveMaintenance()
        {
            //save maintenance
        }
    }
}
