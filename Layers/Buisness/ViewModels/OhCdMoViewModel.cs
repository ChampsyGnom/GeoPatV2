using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhCdMoViewModel : ViewModelBase<OhCdMo>
    {
        public OhCdMoViewModel(OhCdMo model) : base(model)
        {
            this.OhDscs = new  ObservableCollection<OhDscViewModel>();
            
            this.OhDscTemps = new  ObservableCollection<OhDscTempViewModel>();
            
        }
        public override void Read()
        {
            this.Mo=this.Model.Mo;
        }
        public override void Write()
        {
            this.Model.Mo=this.Mo;
        }
        public virtual ObservableCollection<OhDscViewModel> OhDscs { get; set; }
        
        public virtual ObservableCollection<OhDscTempViewModel> OhDscTemps { get; set; }
        
        private String _mo;
        [DisplayName("Maitre d'ouvrage")]
        public String Mo
        {
            get
            {
                return this._mo;
            }
            set
            {
                this._mo = value;
                RaisePropertyChange("Mo");
            }
        }
    }
}
