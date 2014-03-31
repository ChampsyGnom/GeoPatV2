using Emash.GeoPat.Layers.Shared.Models;
using Emash.GeoPat.Modules.Data.Models;
using Emash.GeoPat.Modules.Data.Views;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Collections.ObjectModel;
using Emash.GeoPat.Layers.Shared.Services;
namespace Emash.GeoPat.Modules.Data.ViewModels
{
    public class ConfigurationViewModel
    {
         public DelegateCommand AddDatabaseCommand { get; private set; }
         public DelegateCommand<ConfigurationDatabase> RemoveDatabaseCommand { get; private set; }
         public DelegateCommand<ConfigurationDatabase> SelectDatabaseCommand { get; private set; }
         public ObservableCollection<ConfigurationDatabase> Databases { get; private set; }
         public ConfigurationDatabase SelectedDatabase { get; private set; }
        private IEventAggregator _eventAggregator;
        private IUnityContainer _container;
        private IRegionManager _regionManager;

       


        public ConfigurationViewModel(IEventAggregator eventAggregator, IUnityContainer container, IRegionManager regionManager)
        {
              this._eventAggregator = eventAggregator;                   
            this._container = container;
            this._regionManager = regionManager;
            this.AddDatabaseCommand = new DelegateCommand(AddDatabaseCommandExecute);
            this.RemoveDatabaseCommand = new DelegateCommand<ConfigurationDatabase>(RemoveDatabaseCommandExecute);
            this.SelectDatabaseCommand = new DelegateCommand<ConfigurationDatabase>(SelectDatabaseCommandExecute);
            this.Databases = new ObservableCollection<ConfigurationDatabase>();
            foreach (ConfigurationDatabase database in this._container.Resolve<Configuration>().Databases)
            {
                this.Databases.Add(database);
            }
        }
        private void SelectDatabaseCommandExecute(ConfigurationDatabase database)
        {
            this.SelectedDatabase = database;
            Window Window = Application.Current.Windows.Cast<Window>().SingleOrDefault(x => x.IsActive);
            Window.DialogResult = true;
            Window.Close();
           
        }
        private void RemoveDatabaseCommandExecute(ConfigurationDatabase database)
        {
            this._container.Resolve<Configuration>().Databases.Remove(database);
            this.Databases.Remove(database);
            this._container.Resolve<Configuration>().Save();
        }
        private void AddDatabaseCommandExecute()
        {
            AddDatabaseDialog dialog = this._container.Resolve<AddDatabaseDialog>();
            dialog.Owner = Application.Current.Windows.Cast<Window>().SingleOrDefault(x => x.IsActive);
            Nullable<Boolean> result = dialog.ShowDialog();
            if (result.HasValue && result.Value == true)
            {
                ConfigurationDatabaseViewModel vm = dialog.ViewModel;
                ConfigurationDatabase model = new ConfigurationDatabase();
                model.ProviderTypeFullName = vm.SelectedProviderType.GetType().FullName;
                model.DisplayName = vm.DisplayName;
                foreach (ConfigurationProviderParameter param in vm.SelectedProviderType.Parameters)
                {model.Parameters.Add(param.Code, param.Value);}
                this._container.Resolve<Configuration>().AddDatabase(model);
                this.Databases.Add(model);
            }
        }
    }
}
