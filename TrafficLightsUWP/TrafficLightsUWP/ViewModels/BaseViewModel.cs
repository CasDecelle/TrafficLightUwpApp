using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public RelayCommand AddTrafficLightCommand { get { return new RelayCommand(NavigateToAddTraficLight); } }
        public RelayCommand EditTrafficLightCommand { get { return new RelayCommand(NavigateToEditTraficLight); } }
        public RelayCommand AddMaintenanceCommand { get { return new RelayCommand(NavigateToAddMaintenance); } }

        private void NavigateToAddMaintenance()
        {
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(AddMaintenanceView));
            Window.Current.Activate();
        }

        private void NavigateToHome()
        {
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(DashboardView));
            Window.Current.Activate();
        }

        private void NavigateToAddTraficLight()
        {
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(DashboardView));
            Window.Current.Activate();
        }

        private void NavigateToEditTraficLight()
        {
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(EditTrafficLightView));
            Window.Current.Activate();
        }
    }
}
