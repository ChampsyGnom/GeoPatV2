using Emash.GeoPat.Layers.Shared.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emash.GeoPat.Layers.Shared.Services
{
    public interface IDataService
    {
        ConfigurationDatabase ShowSelectDatabaseDialog();

        void LoadConfiguration();

        Models.ConfigurationDatabase GetDefaultDatabase();

        string GetPasswordForLogin(ConfigurationDatabase database,string needestLogin);

        string ShowInputPasswordDialog(ConfigurationDatabase database,string needestLogin);

        bool TryConnect(ConfigurationDatabase database,string needestLogin, string password);
        
        void CreateConnection(ConfigurationDatabase database,string login, string password);
        DbConnection Connection { get; }

        void SetPasswordForLogin(ConfigurationDatabase database, string login, string password);

        void SetDefaultDatabase(ConfigurationDatabase selectedDatabase);
    }
}
