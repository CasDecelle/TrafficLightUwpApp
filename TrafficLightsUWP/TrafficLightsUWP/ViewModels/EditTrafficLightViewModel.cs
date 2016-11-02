using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrafficLightsUWP.Models;
using TrafficLightsUWP.Services;
using Windows.UI.Popups;

namespace TrafficLightsUWP.ViewModels
{
    public class EditTrafficLightViewModel : BaseViewModel
    {
        private TrafficLight trafficLight;
        private ITrafficLightService _trafficLightService;

        public TrafficLight TrafficLight
        {
            get { return trafficLight; }
            set
            {
                trafficLight = value;
                RaisePropertyChanged(nameof(TrafficLight));
            }
        }


        #region Directions
        private Dictionary<int, string> directionsValues;

        public Dictionary<int, string> DirectionsValues
        {
            get { return directionsValues; }
            set { directionsValues = value; RaisePropertyChanged(nameof(DirectionsValues)); }
        }

        private object _selectedDictValue;
        public object SelectedDirectionDictValue
        {
            get
            {
                return (int) trafficLight.Direction;
            }
            set
            {
                if (value != null)
                   trafficLight.Direction = (TrafficLightDirection)value;

               // Set("SelectedDictValue", ref _selectedDictValue, value);


            }
        }
        #endregion


        public object SelectedStatusDictValue
        {
            get
            {
                return (int)trafficLight.Status;
            }
            set
            {
                if (value != null)
                    trafficLight.Status = (TrafficLightStatus)value;

                // Set("SelectedDictValue", ref _selectedDictValue, value);


            }
        }

        private Dictionary<int, string> statusValues;

        public Dictionary<int, string> StatusValues
        {
            get { return statusValues; }
            set { statusValues = value; }
        }


        public EditTrafficLightViewModel(ITrafficLightService trafficLightService)
        {
            this.TrafficLight = new TrafficLight
            {
                NumberOfSecsGreen = 30,
                NumberOfSecsOrange = 31,
                NumberOfSecsRed = 32,
                ActiveSince = DateTime.Now.AddDays(5),
                PlacementDate = DateTime.Now.AddDays(4),
                Direction = TrafficLightDirection.NE,
                Status = TrafficLightStatus.Defective,
                IsPlaced = true
            };

            _trafficLightService = trafficLightService;

            Array values = Enum.GetValues(typeof(TrafficLightDirection));

            DirectionsValues = new Dictionary<int, string>();
            foreach (TrafficLightDirection direction in Enum.GetValues(typeof(TrafficLightDirection)))
            {
                DirectionsValues.Add((int)direction, direction.ToString());
            }

            StatusValues = new Dictionary<int, string>();
            foreach (TrafficLightStatus status in Enum.GetValues(typeof(TrafficLightStatus)))
            {
                StatusValues.Add((int)status, status.ToString());
            }


        }

        public async void SaveTrafficLight()
        {
            _trafficLightService.SaveTrafficLight(trafficLight);
            await new MessageDialog("The trafficlight has been saved!!! ?. ?. ?.").ShowAsync();
        }





    }
}
