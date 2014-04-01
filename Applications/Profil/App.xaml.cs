using Emash.GeoPat.Applications.Profil.ViewModels;
using Emash.GeoPat.Applications.Profil.Views;
using Emash.GeoPat.Layers.Data;
using Emash.GeoPat.Layers.Engine;
using Emash.GeoPat.Layers.Engine.Views;
using Emash.GeoPat.Layers.Shared.Events;
using Emash.GeoPat.Layers.Shared.Services;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Emash.GeoPat.Applications.Profil
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
       
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Bootstrapper<MainViewModel, MainView> bootstrapper = new Bootstrapper<MainViewModel, MainView>();
            bootstrapper.Run();
           
        }
    }
}
