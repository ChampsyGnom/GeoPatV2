using Emash.GeoPat.Layers.Shared.Events;
using Emash.GeoPat.Layers.Shared.Services;
using Emash.GeoPat.Modules.Data.Models;
using Emash.GeoPat.Modules.Data.Services;
using Emash.GeoPat.Modules.Data.ViewModels;
using Emash.GeoPat.Modules.Data.Views;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emash.GeoPat.Modules.Data
{
    [Module(ModuleName = "Data")]   
    public class ModuleData : IModule
    {
        private IEventAggregator _eventAggregator;
        private IUnityContainer _container;
        private IRegionManager _regionManager;

        public ModuleData(IEventAggregator eventAggregator, IUnityContainer container, IRegionManager regionManager)
        {
            this._eventAggregator = eventAggregator;                   
            this._container = container;
            this._regionManager = regionManager;
        }
        public void Initialize()
        {
            this._eventAggregator.GetEvent<SplashEvent>().Publish("Initialisation du module Data ...");
            this._container.RegisterType<IDataService, DataService>(new ContainerControlledLifetimeManager());
            this._container.RegisterType<Configuration>(new ContainerControlledLifetimeManager());          
            this._container.RegisterType<ConfigurationDatabaseViewModel>();
            this._container.RegisterType<ConfigurationViewModel>();
            this._container.RegisterType<LoginDataBaseViewModel>();
            this._container.RegisterType<SelectDatabaseDialog>();
            this._container.RegisterType<AddDatabaseDialog>();
            this._container.RegisterType<LoginDatabaseDialog>();
        }
    }
}
