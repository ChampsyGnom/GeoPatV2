using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaCdTablierViewModel : ViewModelBase
    {
        public OaCdTablier Model {get; set;}
        public OaCdTablierViewModel(OaCdTablier model)
        {
            this.OaDscs = new  ObservableCollection<OaDscViewModel>();
            
            this.OaDscTemps = new  ObservableCollection<OaDscTempViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.Tablier=this.Model.Tablier;
        }
        public override void Write()
        {
            this.Model.Tablier=this.Tablier;
        }
        public virtual ObservableCollection<OaDscViewModel> OaDscs { get; set; }
        
        public virtual ObservableCollection<OaDscTempViewModel> OaDscTemps { get; set; }
        
        private String _tablier;
        [DisplayName("Type tablier")]
        public String Tablier
        {
            get
            {
                return this._tablier;
            }
            set
            {
                this._tablier = value;
                RaisePropertyChange("Tablier");
            }
        }
    }
}
