using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaCdChargeViewModel : ViewModelBase<OaCdCharge>
    {
        public OaCdChargeViewModel(OaCdCharge model) : base(model)
        {
            this.OaDscs = new  ObservableCollection<OaDscViewModel>();
            
            this.OaDscTemps = new  ObservableCollection<OaDscTempViewModel>();
            
        }
        public override void Read()
        {
            this.Surcharge=this.Model.Surcharge;
        }
        public override void Write()
        {
            this.Model.Surcharge=this.Surcharge;
        }
        public virtual ObservableCollection<OaDscViewModel> OaDscs { get; set; }
        
        public virtual ObservableCollection<OaDscTempViewModel> OaDscTemps { get; set; }
        
        private String _surcharge;
        [DisplayName("Surcharge")]
        public String Surcharge
        {
            get
            {
                return this._surcharge;
            }
            set
            {
                this._surcharge = value;
                RaisePropertyChange("Surcharge");
            }
        }
    }
}
