using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotCdMeteoViewModel : ViewModelBase
    {
        public GotCdMeteo Model {get; set;}
        public GotCdMeteoViewModel(GotCdMeteo model)
        {
            this.GotInsps = new  ObservableCollection<GotInspViewModel>();
            
            this.GotInspTmps = new  ObservableCollection<GotInspTmpViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.Meteo=this.Model.Meteo;
        }
        public override void Write()
        {
            this.Model.Meteo=this.Meteo;
        }
        public virtual ObservableCollection<GotInspViewModel> GotInsps { get; set; }
        
        public virtual ObservableCollection<GotInspTmpViewModel> GotInspTmps { get; set; }
        
        private String _meteo;
        [DisplayName("Condition météo")]
        public String Meteo
        {
            get
            {
                return this._meteo;
            }
            set
            {
                this._meteo = value;
                RaisePropertyChange("Meteo");
            }
        }
    }
}
