using GalaSoft.MvvmLight;
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
    public class AddTrafficLigtViewModel : ViewModelBase
    {
        public TrafficLightService tlservice = new TrafficLightService();
        LocationService locationservice = new LocationService();
        public ObservableCollection<TrafficLight> NewTrafficLightList { get; set; }
        public TrafficLight NewTrafficLight{ get; set; }

        
        private IEnumerable<Location> _placesList;
        public IEnumerable<Location> PlacesList
        {
            get { return _placesList; }
            set
            {

                Set("PlacesList", ref _placesList, value);


            }
        }


        private Object _location;
        public Object Location
        {
            get { return _location; }
            set
            {

                Set("Location", ref _location, value);


            }
        }

        


        private ObservableCollection<TrafficLightDirection> _TrafficLightDirection;
        public ObservableCollection<TrafficLightDirection> TrafficLightDirection
        {
            get { return _TrafficLightDirection; }
            set
            {
             
              Set("TrafficLightDirection", ref _TrafficLightDirection, value);


            }
        }

        private int _amount;
        public int Amount
        {
            get { return _amount; }
            set {
                NewTrafficLightList.Clear();
                for (int i = 0; i < value; i++)
                {
                    NewTrafficLight = new TrafficLight();
                    NewTrafficLightList.Add(NewTrafficLight);
                }
                Set("Amount", ref _amount, value);

                
            }
        }


        public Dictionary<int, string> Dict { get; set; } = new Dictionary<int, string>();

        


        public AddTrafficLigtViewModel()
        {
            NewTrafficLightList = new ObservableCollection<TrafficLight>();
            TrafficLightDirection = new ObservableCollection<TrafficLightDirection>();
            PlacesList = new ObservableCollection<Location>();
            //PlacesList

            PlacesList= locationservice.GetAllLocations();


            foreach (TrafficLightDirection direction in Enum.GetValues(typeof(TrafficLightDirection)))
            {
                Dict.Add((int)direction, direction.ToString());
            }

        }

        public void Save()
        {
            foreach (var light in NewTrafficLightList)
            {
                light.Location = (Location)Location;
                tlservice.AddTrafficLight(light);
            }
          
           
        }




    }
}
