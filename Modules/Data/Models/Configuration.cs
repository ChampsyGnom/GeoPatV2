using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using Emash.GeoPat.Layers.Shared.Models;
namespace Emash.GeoPat.Modules.Data.Models
{
    public class Configuration
    {
        public List<ConfigurationDatabase> Databases { get; set; }

        public Configuration()
        {
            this.Databases = new List<ConfigurationDatabase>();
        }

        internal void AddDatabase(ConfigurationDatabase model)
        {
            this.Databases.Add(model);
            this.Save();
        }
        public void Load()
        {
            this.Databases.Clear();
            RegistryKey companyKey = Registry.LocalMachine.OpenOrCreateCompanyKey();
            RegistryKey geoPatKey = companyKey.OpenOrCreateKey("GeoPatV2");
            RegistryKey configKey = geoPatKey.OpenOrCreateKey("Configuration");
            RegistryKey providersKey = configKey.OpenOrCreateKey("Providers");
            String[] providersKeyNames = providersKey.GetSubKeyNames();
            foreach (String providerKeyName in providersKeyNames)
            {
                RegistryKey providerKey = providersKey.OpenOrCreateKey(providerKeyName);
                String providerTypeFullName = providerKey.GetValue("ProviderTypeFullName").ToString();
                ConfigurationProviderType configurationProviderType = null;
                if (providerTypeFullName.Equals(typeof(ConfigurationProviderTypeMysql).FullName))
                {
                    configurationProviderType = new ConfigurationProviderTypeMysql();
                    
                }
                else if (providerTypeFullName.Equals(typeof(ConfigurationProviderTypeOracle).FullName))
                {
                    configurationProviderType = new ConfigurationProviderTypeMysql();

                }
                else if (providerTypeFullName.Equals(typeof(ConfigurationProviderTypePostgre).FullName))
                {
                    configurationProviderType = new ConfigurationProviderTypeMysql();

                }
                if (configurationProviderType != null)
                {
                    ConfigurationDatabase item = new ConfigurationDatabase();
                    item.DisplayName = providerKey.GetValue("DisplayName").ToString();
                    item.IsDefault = providerKey.GetValue("IsDefault").ToString().ToUpper().Equals("TRUE");
                    item.ProviderTypeFullName = providerTypeFullName;
                    RegistryKey parametersKey = providerKey.OpenOrCreateKey("Parameters");
                    String[] parametersKeyNames = parametersKey.GetSubKeyNames();
                    foreach (String parametersKeyName in parametersKeyNames)
                    {
                        RegistryKey parameterKey = parametersKey.OpenOrCreateKey(parametersKeyName);
                        item.Parameters.Add ( parameterKey.GetValue("Code").ToString(), parameterKey.GetValue("Value").ToString());


                    }
                    this.Databases.Add(item);
                }
            }
        }

        public void Save()
        {
            RegistryKey companyKey = Registry.LocalMachine.OpenOrCreateCompanyKey();
            RegistryKey geoPatKey = companyKey.OpenOrCreateKey("GeoPatV2");
            RegistryKey configKey = geoPatKey.OpenOrCreateKey("Configuration");
            RegistryKey providersKey = configKey.OpenOrCreateKey("Providers");
            providersKey.Clear();
            for (int i = 0; i < this.Databases.Count; i++)
            {
                String keyName = "Provider_" + (i + 1).ToString();
                RegistryKey providerKey = providersKey.OpenOrCreateKey(keyName);
                providerKey.SetValue("DisplayName", Databases[i].DisplayName);
                providerKey.SetValue("ProviderTypeFullName", Databases[i].ProviderTypeFullName);
                providerKey.SetValue("IsDefault", Databases[i].IsDefault.ToString().ToUpper());
                RegistryKey paramsKey = providerKey.OpenOrCreateKey("Parameters");
                int parameterIndex = 0;
                foreach (String key in Databases[i].Parameters.Keys)
                {
                    String keyNameParam = "Parameter_" + (parameterIndex).ToString();
                    RegistryKey paramKey = paramsKey.OpenOrCreateKey(keyNameParam);
                    paramKey.SetValue("Code", key);
                    paramKey.SetValue("Value", Databases[i].Parameters[key]);
                    parameterIndex++;
                }
               

            }
        }

        internal void SetPasswordForLogin(ConfigurationDatabase database,string login, string password)
        {
            RegistryKey companyKey = Registry.CurrentUser.OpenOrCreateCompanyKey();
            RegistryKey geoPatKey = companyKey.OpenOrCreateKey("GeoPat");
            RegistryKey configKey = geoPatKey.OpenOrCreateKey("Configuration");
            RegistryKey providersKey = configKey.OpenOrCreateKey("Providers");
            String providerKeyName = database.GetHash();
            RegistryKey keyProvider = providersKey.OpenOrCreateKey(providerKeyName);
            keyProvider.SetValue(login, password);
        }

        internal void SetDefaultDatabase(ConfigurationDatabase selectedDatabase)
        {
            foreach (ConfigurationDatabase db in this.Databases)
            {db.IsDefault = false;}
            selectedDatabase.IsDefault = true;
            this.Save();
        }

        internal string GetPasswordForLogin(ConfigurationDatabase configurationDatabase, string login)
        {
            RegistryKey companyKey = Registry.CurrentUser.OpenOrCreateCompanyKey();
            RegistryKey geoPatKey = companyKey.OpenOrCreateKey("GeoPat");
            RegistryKey configKey = geoPatKey.OpenOrCreateKey("Configuration");
            RegistryKey providersKey = configKey.OpenOrCreateKey("Providers");
            String providerKeyName = configurationDatabase.GetHash();
            RegistryKey keyProvider = providersKey.OpenOrCreateKey(providerKeyName);
            if (keyProvider.GetValueNames().Contains(login))
            { return keyProvider.GetValue(login).ToString(); }
            return null;
        }
    }
}
