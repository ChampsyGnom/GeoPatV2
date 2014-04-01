using Emash.GeoPat.Layers.Shared.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emash.GeoPat.Modules.Data.Models
{
    public abstract class ConfigurationProviderType
    {
        public abstract String DisplayName { get; }
        public List<ConfigurationProviderParameter> Parameters { get; protected set; }
        public bool TryConnect(ConfigurationDatabase configurationDatabase, string login, string password)
        {
            Boolean success = false;
            DbConnection connection = this.CreateConnection(configurationDatabase, login, password);
            if (connection != null)
            {
                try
                {
                   
                    connection.Open();
                    success = connection.State == System.Data.ConnectionState.Open;
                    

                }
                catch (Exception ex)
                { }
                finally
                {
                    connection.Close();
                    connection.Dispose();
                }

            }


            return success;

        }
        public ConfigurationProviderType()
        {
            this.Parameters = new List<ConfigurationProviderParameter>();
        }

        public void AddParameter(String displayName, String code)
        {
            ConfigurationProviderParameter parameter = new ConfigurationProviderParameter();
            parameter.DisplayName = displayName;
            parameter.Code = code;
        
            this.Parameters.Add(parameter);
        }


        public abstract DbConnection CreateConnection(ConfigurationDatabase configurationDatabase, string login, string password);
    }
}
