using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotCdGeoViewModel : ViewModelBase
    {
        public GotCdGeo Model {get; set;}
        public GotCdGeoViewModel(GotCdGeo model)
        {
            this.GotDscs = new  ObservableCollection<GotDscViewModel>();
            
            this.GotDscTemps = new  ObservableCollection<GotDscTempViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.Geologie=this.Model.Geologie;
        }
        public override void Write()
        {
            this.Model.Geologie=this.Geologie;
        }
        public virtual ObservableCollection<GotDscViewModel> GotDscs { get; set; }
        
        public virtual ObservableCollection<GotDscTempViewModel> GotDscTemps { get; set; }
        
        private String _geologie;
        [DisplayName("Géologie")]
        public String Geologie
        {
            get
            {
                return this._geologie;
            }
            set
            {
                this._geologie = value;
                RaisePropertyChange("Geologie");
            }
        }
    }
}
