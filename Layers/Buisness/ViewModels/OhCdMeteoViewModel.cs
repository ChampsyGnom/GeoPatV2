using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhCdMeteoViewModel : ViewModelBase<OhCdMeteo>
    {
        public OhCdMeteoViewModel(OhCdMeteo model) : base(model)
        {
            this.OhInsps = new  ObservableCollection<OhInspViewModel>();
            
            this.OhInspTmps = new  ObservableCollection<OhInspTmpViewModel>();
            
        }
        public override void Read()
        {
            this.Meteo=this.Model.Meteo;
        }
        public override void Write()
        {
            this.Model.Meteo=this.Meteo;
        }
        public virtual ObservableCollection<OhInspViewModel> OhInsps { get; set; }
        
        public virtual ObservableCollection<OhInspTmpViewModel> OhInspTmps { get; set; }
        
        private String _meteo;
        [DisplayName("Météo")]
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
