using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnCdRoleViewModel : ViewModelBase
    {
        public BsnCdRole Model {get; set;}
        public BsnCdRoleViewModel(BsnCdRole model)
        {
            this.BsnCdRoleDscs = new  ObservableCollection<BsnCdRoleDscViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.Role=this.Model.Role;
        }
        public override void Write()
        {
            this.Model.Role=this.Role;
        }
        public virtual ObservableCollection<BsnCdRoleDscViewModel> BsnCdRoleDscs { get; set; }
        
        private String _role;
        [DisplayName("Rôle")]
        public String Role
        {
            get
            {
                return this._role;
            }
            set
            {
                this._role = value;
                RaisePropertyChange("Role");
            }
        }
    }
}
