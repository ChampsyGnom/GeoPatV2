using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhCdEcoulViewModel : ViewModelBase<OhCdEcoul>
    {
        public OhCdEcoulViewModel(OhCdEcoul model) : base(model)
        {
            this.OhDscs = new  ObservableCollection<OhDscViewModel>();
            
            this.OhDscTemps = new  ObservableCollection<OhDscTempViewModel>();
            
        }
        public override void Read()
        {
            this.Ecoul=this.Model.Ecoul;
        }
        public override void Write()
        {
            this.Model.Ecoul=this.Ecoul;
        }
        public virtual ObservableCollection<OhDscViewModel> OhDscs { get; set; }
        
        public virtual ObservableCollection<OhDscTempViewModel> OhDscTemps { get; set; }
        
        private String _ecoul;
        [DisplayName("Ecoulement")]
        public String Ecoul
        {
            get
            {
                return this._ecoul;
            }
            set
            {
                this._ecoul = value;
                RaisePropertyChange("Ecoul");
            }
        }
    }
}
