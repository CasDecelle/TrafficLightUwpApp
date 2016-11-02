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
        public RelayCommand HomeCommand { get { return new RelayCommand(NavigateToHome); } }
        public RelayCommand AddCommand { get { return new RelayCommand(NavigateToAddTraficLight); } }
        public RelayCommand EditCommand { get { return new RelayCommand(NavigateToEditTraficLight); } }

        public void NavigateToHome()
        {
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(DashboardView));
            Window.Current.Activate();
        }

        public void NavigateToAddTraficLight()
        {
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(DashboardView));
            Window.Current.Activate();
        }

        public void NavigateToEditTraficLight()
        {
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(EditTrafficLightView));
            Window.Current.Activate();
        }
    }
}
