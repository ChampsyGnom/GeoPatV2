using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhCdTeteAvViewModel : ViewModelBase
    {
        public OhCdTeteAv Model {get; set;}
        public OhCdTeteAvViewModel(OhCdTeteAv model)
        {
            this.OhDscs = new  ObservableCollection<OhDscViewModel>();
            
            this.OhDscTemps = new  ObservableCollection<OhDscTempViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.TeteAv=this.Model.TeteAv;
        }
        public override void Write()
        {
            this.Model.TeteAv=this.TeteAv;
        }
        public virtual ObservableCollection<OhDscViewModel> OhDscs { get; set; }
        
        public virtual ObservableCollection<OhDscTempViewModel> OhDscTemps { get; set; }
        
        private String _teteAv;
        [DisplayName("Tête aval")]
        public String TeteAv
        {
            get
            {
                return this._teteAv;
            }
            set
            {
                this._teteAv = value;
                RaisePropertyChange("TeteAv");
            }
        }
    }
}
