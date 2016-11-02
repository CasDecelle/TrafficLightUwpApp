using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrafficLightsUWP.Models;
using TrafficLightsUWP.Views;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace TrafficLightsUWP.ViewModels
{
    public class BaseViewModel : ViewModelBase
    {
        private string _title;

        public string Title
        {
            get { return _title; }
            set { Set(ref _title, value); }
        }

        public RelayCommand HomeCommand { get { return new RelayCommand(NavigateToHome); } }
        public RelayCommand AddTrafficLightCommand { get { return new RelayCommand(NavigateToAddTrafficLight); } }
        public RelayCommand<TrafficLight> EditTrafficLightCommand { get { return new RelayCommand<TrafficLight>((param) => NavigateToEditTrafficLight(param)); } }
        public RelayCommand<TrafficLight> AddMaintenanceCommand { get { return new RelayCommand<TrafficLight>((param) => NavigateToAddMaintenance(param)); } }
        public RelayCommand<TrafficLight> DetailTrafficLightCommand { get { return new RelayCommand<TrafficLight>((param) => NavigateToDetailTrafficLight(param)); } }

        protected void NavigateToAddMaintenance(TrafficLight trafficLight)
        {
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(AddMaintenanceView), trafficLight);
            Window.Current.Activate();
        }

        protected void NavigateToHome()
        {
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(DashboardView));
            Window.Current.Activate();
        }

        protected void NavigateToAddTrafficLight()
        {
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(DashboardView));
            Window.Current.Activate();
        }

        protected void NavigateToEditTrafficLight(TrafficLight trafficLight)
        {
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(EditTrafficLightView), trafficLight);
            Window.Current.Activate();
        }

        protected void NavigateToDetailTrafficLight(TrafficLight trafficLight)
        {
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(DetailTrafficLightView), trafficLight);
            Window.Current.Activate();
        }
    }
}
