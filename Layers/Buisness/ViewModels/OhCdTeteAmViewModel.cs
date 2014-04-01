using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhCdTeteAmViewModel : ViewModelBase
    {
        public OhCdTeteAm Model {get; set;}
        public OhCdTeteAmViewModel(OhCdTeteAm model)
        {
            this.OhDscs = new  ObservableCollection<OhDscViewModel>();
            
            this.OhDscTemps = new  ObservableCollection<OhDscTempViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.TeteAm=this.Model.TeteAm;
        }
        public override void Write()
        {
            this.Model.TeteAm=this.TeteAm;
        }
        public virtual ObservableCollection<OhDscViewModel> OhDscs { get; set; }
        
        public virtual ObservableCollection<OhDscTempViewModel> OhDscTemps { get; set; }
        
        private String _teteAm;
        [DisplayName("Tête amont")]
        public String TeteAm
        {
            get
            {
                return this._teteAm;
            }
            set
            {
                this._teteAm = value;
                RaisePropertyChange("TeteAm");
            }
        }
    }
}
