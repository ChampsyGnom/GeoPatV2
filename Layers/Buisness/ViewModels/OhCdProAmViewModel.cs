using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhCdProAmViewModel : ViewModelBase
    {
        public OhCdProAm Model {get; set;}
        public OhCdProAmViewModel(OhCdProAm model)
        {
            this.OhDscs = new  ObservableCollection<OhDscViewModel>();
            
            this.OhDscTemps = new  ObservableCollection<OhDscTempViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.Protect=this.Model.Protect;
        }
        public override void Write()
        {
            this.Model.Protect=this.Protect;
        }
        public virtual ObservableCollection<OhDscViewModel> OhDscs { get; set; }
        
        public virtual ObservableCollection<OhDscTempViewModel> OhDscTemps { get; set; }
        
        private String _protect;
        [DisplayName("Protection Amont")]
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
