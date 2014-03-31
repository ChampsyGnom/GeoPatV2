using Emash.GeoPat.Layers.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emash.GeoPat.Modules.Data.ViewModels
{
    public class LoginDataBaseViewModel
    {
        public String Login { get; set; }
        public String Password { get; set; }
        public ConfigurationDatabase Database { get; set; }
    }
}
