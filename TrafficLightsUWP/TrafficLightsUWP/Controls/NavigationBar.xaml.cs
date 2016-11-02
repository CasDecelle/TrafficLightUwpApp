using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace TrafficLightsUWP.Controls
{
    public sealed partial class NavigationBar : UserControl
    {

        public RelayCommand AddTrafficLightCommand
        {
            get
            {
                return (RelayCommand)GetValue(AddTrafficLightCommandProperty);
            }

            set
            {
                SetValue(AddTrafficLightCommandProperty, value);
            }
        }

        public static readonly DependencyProperty AddTrafficLightCommandProperty = DependencyProperty.Register(
          "AddTrafficLightCommand",
          typeof(RelayCommand),
          typeof(NavigationBar),
          new PropertyMetadata(null)
        );

        public RelayCommand HomeCommand
        {
            get
            {
                return (RelayCommand)GetValue(HomeCommandProperty);
            }

            set
            {
                SetValue(HomeCommandProperty, value);
            }
        }

        public static readonly DependencyProperty HomeCommandProperty = DependencyProperty.Register(
          "HomeCommand",
          typeof(RelayCommand),
          typeof(NavigationBar),
          new PropertyMetadata(null)
        );

        public string Title
        {
            get
            {
                return (string)GetValue(TitleProperty);
            }

            set
            {
                SetValue(TitleProperty, value);
            }
        }

        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register(
          "Title",
          typeof(string),
          typeof(NavigationBar),
          new PropertyMetadata(null)
        );

        public NavigationBar()
        {
            this.InitializeComponent();
        }
    }
}
