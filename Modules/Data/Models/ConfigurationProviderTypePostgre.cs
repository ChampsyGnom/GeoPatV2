using Emash.GeoPat.Layers.Shared.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection;
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


        public override System.Data.Common.DbConnection CreateConnection(ConfigurationDatabase configurationDatabase, string login, string password)
        {
            
            string host = (from p in configurationDatabase.Parameters where p.Key.Equals("HOST") select p.Value).FirstOrDefault();
            string port = (from p in configurationDatabase.Parameters where p.Key.Equals("PORT") select p.Value).FirstOrDefault();
            string database = (from p in configurationDatabase.Parameters where p.Key.Equals("DATABASE") select p.Value).FirstOrDefault();
            Assembly assembly = Assembly.Load("Npgsql");
            if (assembly != null)
            {
                Type connectionType = assembly.GetType("Npgsql.NpgsqlConnection");
                if (connectionType != null)
                {
                    DbConnection connection = Activator.CreateInstance(connectionType) as DbConnection;
                    if (host != null && port != null && database != null)
                    {
                        connection.ConnectionString = "HOST=" + host + ";PORT=" + port + ";DATABASE=" + database + ";USER ID=" + login.ToLower () + ";PASSWORD=" + password.ToLower () + ";PRELOADREADER=true;";
                        return connection;
                    }

                }
            }
            return null;
        }
    }
}
