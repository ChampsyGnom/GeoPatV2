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
        public static DataContextPrf DataContextPrf { get; private set; }
        public static DataContextInf DataContextInf { get; private set; }
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Bootstrapper<MainViewModel, MainView> bootstrapper = new Bootstrapper<MainViewModel, MainView>();
            bootstrapper.Run();
            if (ServiceLocator.Current.GetInstance<IDataService>().Connection != null)
            {
                ServiceLocator.Current.GetInstance<IEventAggregator>().GetEvent<SplashEvent>().Publish("Initialisation de la base de donnée ...");

                Database.SetInitializer<DataContextPrf>(null);
                Database.SetInitializer<DataContextInf>(null);

                ServiceLocator.Current.GetInstance<IEventAggregator>().GetEvent<SplashEvent>().Publish("Initialisation du schéma PRF ...");
                App.DataContextPrf = new Layers.Data.DataContextPrf(ServiceLocator.Current.GetInstance<IDataService>().Connection);
                App.DataContextPrf.Database.Initialize(false);

                ServiceLocator.Current.GetInstance<IEventAggregator>().GetEvent<SplashEvent>().Publish("Initialisation du schéma INF ...");
                App.DataContextInf = new Layers.Data.DataContextInf(ServiceLocator.Current.GetInstance<IDataService>().Connection);
                App.DataContextInf.Database.Initialize(false);

                ServiceLocator.Current.GetInstance<ISplashService>().CloseSplash();
                ServiceLocator.Current.GetInstance<IMainView>().Show();
            }
            
        }
    }
}
