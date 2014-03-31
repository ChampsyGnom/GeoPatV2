using Emash.GeoPat.Layers.Data;
using Emash.GeoPat.Layers.Engine.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emash.GeoPat.Applications.Profil.ViewModels
{
    public class MainViewModel : IMainViewModel
    {
        public String Login { get; private set; }

        public MainViewModel()
        {
            this.Login = "PRF_ADMIN";
            
        }
        
    }
}
