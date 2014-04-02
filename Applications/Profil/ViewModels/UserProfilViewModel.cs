using Emash.GeoPat.Layers.Data.Models;
using Emash.GeoPat.Layers.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emash.GeoPat.Applications.Profil.ViewModels
{
    public class UserProfilViewModel
    {
        private PrivilegeLevel _privilegeLevel;

        public PrivilegeLevel PrivilegeLevel
        {
            get { return _privilegeLevel; }
            set { _privilegeLevel = value; }
        }
        public PrfBmSchema Schema { get; set; }
        public List<PrivilegeLevel> PrivilegeLevels { get;private  set; }

        public UserProfilViewModel()
        {
            this.PrivilegeLevels = new List<PrivilegeLevel>();
            this.PrivilegeLevels.Add(PrivilegeLevel.Consultant);
            this.PrivilegeLevels.Add(PrivilegeLevel.Valideur);
            this.PrivilegeLevels.Add(PrivilegeLevel.Administrateur);
        }
    } 
}
