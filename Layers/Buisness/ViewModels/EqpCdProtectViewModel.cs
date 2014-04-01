using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpCdProtectViewModel : ViewModelBase<EqpCdProtect>
    {
        public EqpCdProtectViewModel(EqpCdProtect model) : base(model)
        {
            this.EqpDscSvs = new  ObservableCollection<EqpDscSvViewModel>();
            
        }
        public override void Read()
        {
            this.Protect=this.Model.Protect;
        }
        public override void Write()
        {
            this.Model.Protect=this.Protect;
        }
        public virtual ObservableCollection<EqpDscSvViewModel> EqpDscSvs { get; set; }
        
        private String _protect;
        [DisplayName("Protection")]
        public String Protect
        {
            get
            {
                return this._protect;
            }
            set
            {
                this._protect = value;
                RaisePropertyChange("Protect");
            }
        }
    }
}
