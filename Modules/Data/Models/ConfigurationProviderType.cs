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

        public abstract bool TryConnect(ConfigurationDatabase configurationDatabase, string login, string password);

        public abstract DbConnection CreateConnection(ConfigurationDatabase configurationDatabase, string login, string password);
    }
}
