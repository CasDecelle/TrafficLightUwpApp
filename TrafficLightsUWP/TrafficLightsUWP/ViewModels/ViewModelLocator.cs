﻿using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrafficLightsUWP.Services;

namespace TrafficLightsUWP.ViewModels
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary> 
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            if (ViewModelBase.IsInDesignModeStatic)
            {
                // Create design time view services and models
            }
            else
            {
                // Create run time view services and models
            }

            //Register your services used here
            SimpleIoc.Default.Register<INavigationService, NavigationService>();
            SimpleIoc.Default.Register<IMaintenanceService, FakeMaintenanceService>();
            SimpleIoc.Default.Register<ITrafficLightService, FakeTrafficLightService>();
            SimpleIoc.Default.Register<DashboardViewModel>();
            SimpleIoc.Default.Register<EditTrafficLightViewModel>();
            SimpleIoc.Default.Register<AddMaintenanceViewModel>();
            SimpleIoc.Default.Register<DetailTrafficLightViewModel>();

        }


        // <summary>
        // Gets the StartPage view model.
        // </summary>
        // <value>
        // The StartPage view model.
        // </value>
        
        public DashboardViewModel DashboardViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<DashboardViewModel>();
            }
        }
        public EditTrafficLightViewModel EditTrafficLightViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<EditTrafficLightViewModel>();
            }
        }    
        public AddMaintenanceViewModel AddMaintenanceViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<AddMaintenanceViewModel>();
            }
        }
        public DetailTrafficLightViewModel DetailTrafficLightViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<DetailTrafficLightViewModel>();
            }
        }

        // <summary>
        // The cleanup.
        // </summary>
        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }

}