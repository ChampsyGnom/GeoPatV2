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
    public class ConfigurationProviderTypeOracle : ConfigurationProviderType
    {
        public ConfigurationProviderTypeOracle()
            : base()
        {
            this.AddParameter("SID : ", "SID");
        }
        public override string DisplayName
        {
            get { return "Oracle"; }
        }

       

        public override DbConnection CreateConnection(ConfigurationDatabase configurationDatabase, string login, string password)
        {
            Assembly assembly = Assembly.Load("Oracle.DataAccess");
            if (assembly != null)
            {
                Type connectionType = assembly.GetType("Oracle.DataAccess.Client.OracleConnection");
                if (connectionType != null)
                {
                    DbConnection connection = Activator.CreateInstance(connectionType) as DbConnection;
                    String sid = (from p in configurationDatabase.Parameters where p.Key.Equals ("SID") select p.Value).FirstOrDefault();
                    if (sid != null)
                    {
                        connection.ConnectionString = "Data Source=" + sid + ";User Id=" + login + ";Password=" + password + ";";
                        return connection;      
                    }
                                     
                }
            }
            return null;
        }
    }
}
