using Emash.GeoPat.Layers.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emash.GeoPat.Modules.Data.Models
{
    public  class ConfigurationProviderTypePostgre : ConfigurationProviderType
    {
        public ConfigurationProviderTypePostgre() : base()
        {
            this.AddParameter("Adresse : ", "HOST");
            this.AddParameter("Port : ", "PORT");
            this.AddParameter("Nom de la base de donnée : ", "DATABASE");
            
        }
        public override string DisplayName
        {
            get { return "Postgre"; }
        }

        public override bool TryConnect(Layers.Shared.Models.ConfigurationDatabase configurationDatabase, string login, string password)
        {
            throw new NotImplementedException();
        }

        public override System.Data.Common.DbConnection CreateConnection(ConfigurationDatabase configurationDatabase, string login, string password)
        {
            throw new NotImplementedException();
        }
    }
}
