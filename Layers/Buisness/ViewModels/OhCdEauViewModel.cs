using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhCdEauViewModel : ViewModelBase
    {
        public OhCdEau Model {get; set;}
        public OhCdEauViewModel(OhCdEau model)
        {
            this.OhDscs = new  ObservableCollection<OhDscViewModel>();
            
            this.OhDscTemps = new  ObservableCollection<OhDscTempViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.Eau=this.Model.Eau;
        }
        public override void Write()
        {
            this.Model.Eau=this.Eau;
        }
        public virtual ObservableCollection<OhDscViewModel> OhDscs { get; set; }
        
        public virtual ObservableCollection<OhDscTempViewModel> OhDscTemps { get; set; }
        
        private String _eau;
        [DisplayName("Eaux collectées")]
        public String Eau
        {
            get
            {
                return this._eau;
            }
            set
            {
                this._eau = value;
                RaisePropertyChange("Eau");
            }
        }
    }
}
