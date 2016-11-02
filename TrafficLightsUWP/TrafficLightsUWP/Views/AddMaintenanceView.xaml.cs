using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using TrafficLightsUWP.Models;
using TrafficLightsUWP.ViewModels;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace TrafficLightsUWP.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddMaintenanceView : Page
    {
        public AddMaintenanceViewModel VM { get; set; }
        public AddMaintenanceView()
        {
            this.InitializeComponent();
            VM = DataContext as AddMaintenanceViewModel;
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            VM.NewMaintenance.TrafficLight = e.Parameter as TrafficLight;
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            VM.SaveMaintenance();
        }
    }
}
