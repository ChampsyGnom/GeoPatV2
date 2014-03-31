using Microsoft.Practices.Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Emash.GeoPat.Modules.Data.Models;
using System.Reflection;
namespace Emash.GeoPat.Modules.Data.ViewModels
{
    public class ConfigurationDatabaseViewModel
    {
        public String DisplayName { get;  set; }
        private ConfigurationProviderType _selectedProviderType;

        public ConfigurationProviderType SelectedProviderType
        {
            get { return _selectedProviderType; }
            set { _selectedProviderType = value; }
        }
        public ObservableCollection<ConfigurationProviderType> ProviderTypes { get; private set; }

        public ConfigurationDatabaseViewModel()
        {
            this.ProviderTypes = new ObservableCollection<ConfigurationProviderType>();
            Assembly assembly = Assembly.Load("Oracle.DataAccess");
            if (assembly != null)
            { this.ProviderTypes.Add(new ConfigurationProviderTypeOracle()); }
            this.ProviderTypes.Add(new ConfigurationProviderTypePostgre());
            this.ProviderTypes.Add(new ConfigurationProviderTypeMysql());
        }
    }
}
