using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnCdRoleViewModel : ViewModelBase<BsnCdRole>
    {
        public BsnCdRoleViewModel(BsnCdRole model) : base(model)
        {
            this.BsnCdRoleDscs = new  ObservableCollection<BsnCdRoleDscViewModel>();
            
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
