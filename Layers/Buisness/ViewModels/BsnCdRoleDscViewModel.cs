using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnCdRoleDscViewModel : ViewModelBase<BsnCdRoleDsc>
    {
        public BsnCdRoleDscViewModel(BsnCdRoleDsc model) : base(model)
        {
        }
        public override void Read()
        {
            this.BsnDsc=new BsnDscViewModel( this.Model.BsnDsc);
            this.BsnCdRole=new BsnCdRoleViewModel( this.Model.BsnCdRole);
        }
        public override void Write()
        {
            this.Model.BsnDsc=this. BsnDsc.Model;
            this.Model.BsnCdRole=this. BsnCdRole.Model;
        }
        private BsnDscViewModel _bsnDsc;
        [DisplayName("Bassin")]
        public virtual BsnDscViewModel BsnDsc
        {
            get
            {
                return this._bsnDsc;
            }
            set
            {
                this._bsnDsc = value;
                RaisePropertyChange("BsnDsc");
            }
        }
        
        private BsnCdRoleViewModel _bsnCdRole;
        [DisplayName("Rôle du bassin")]
        public virtual BsnCdRoleViewModel BsnCdRole
        {
            get
            {
                return this._bsnCdRole;
            }
            set
            {
                this._bsnCdRole = value;
                RaisePropertyChange("BsnCdRole");
            }
        }
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (errors.Count > 0)
                {
                    return String.Join("\r\n",errors);
                }
                else return null;
            }
        }
        public override string this[string columnName]
        {
            get
            {
                return null;
            }
        }
    }
}
