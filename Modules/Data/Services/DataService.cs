using Emash.GeoPat.Layers.Shared.Models;
using Emash.GeoPat.Layers.Shared.Services;
using Emash.GeoPat.Modules.Data.Models;
using Emash.GeoPat.Modules.Data.ViewModels;
using Emash.GeoPat.Modules.Data.Views;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Emash.GeoPat.Modules.Data.Services
{
    public class DataService : IDataService
    {
        private IEventAggregator _eventAggregator;
        private IUnityContainer _container;
        private IRegionManager _regionManager;        

        public DbConnection Connection { get; private set; }
        public DataService(IEventAggregator eventAggregator, IUnityContainer container, IRegionManager regionManager)
        {
            this._eventAggregator = eventAggregator;                   
            this._container = container;
            this._regionManager = regionManager;

           
           
        }
        public ConfigurationDatabase ShowSelectDatabaseDialog()
        {
            ConfigurationViewModel vm = this._container.Resolve<ConfigurationViewModel>();
            SelectDatabaseDialog dialog = new SelectDatabaseDialog(vm);
             Nullable<Boolean> result = dialog.ShowDialog();
            if (result.HasValue && result.Value == true)
            { return vm.SelectedDatabase; }
            else return null;
        }


        public void LoadConfiguration()
        {
            this._container.Resolve<Configuration>().Load();
        }


        public ConfigurationDatabase GetDefaultDatabase()
        {
            return (from i in this._container.Resolve<Configuration>().Databases where i.IsDefault == true select i).FirstOrDefault();
        }





        public string ShowInputPasswordDialog(ConfigurationDatabase database,string needestLogin)
        {
            LoginDataBaseViewModel viewModel = new LoginDataBaseViewModel();
            viewModel.Login = needestLogin;
            viewModel.Database = database;
            LoginDatabaseDialog dialog = new LoginDatabaseDialog(viewModel);
            Nullable<Boolean> result = dialog.ShowDialog();
            if (result.HasValue && result.Value == true)
            { return viewModel.Password; }
            return null;
        }



        public bool TryConnect(ConfigurationDatabase database, string login, string password)
        {
            if (database != null)
            {
                Type providerType = this.GetType().Assembly.GetType(database.ProviderTypeFullName);
               if (providerType != null)
               {
                   ConfigurationProviderType configurationProviderType = Activator.CreateInstance(providerType) as ConfigurationProviderType;
                   if (configurationProviderType != null)
                   { return configurationProviderType.TryConnect(database, login, password); }
               } 
            }
            return false;
        }





        public void CreateConnection(ConfigurationDatabase database, string login, string password)
        {
            if (database != null)
            {

                Type providerType = this.GetType().Assembly.GetType(database.ProviderTypeFullName);
                if (providerType != null)
                {
                     ConfigurationProviderType configurationProviderType = Activator.CreateInstance(providerType) as ConfigurationProviderType;
                     if (configurationProviderType != null)
                     {
                         this.Connection = configurationProviderType.CreateConnection(database, login, password);
                        
                     }
                    
                }
            }
           
        }

        public string GetPasswordForLogin(ConfigurationDatabase database, string login)
        {
            return this._container.Resolve<Configuration>().GetPasswordForLogin(database, login);
           
        }



        public void SetPasswordForLogin(ConfigurationDatabase database, string login, string password)
        {
            this._container.Resolve<Configuration>().SetPasswordForLogin(database, login, password);
           
   
        }

        public void SetDefaultDatabase(ConfigurationDatabase selectedDatabase)
        {
             this._container.Resolve<Configuration>().SetDefaultDatabase(selectedDatabase);
           
        
        }
    }
}
