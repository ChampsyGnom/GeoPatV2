using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GmsCdMeteoViewModel : ViewModelBase<GmsCdMeteo>
    {
        public GmsCdMeteoViewModel(GmsCdMeteo model) : base(model)
        {
            this.GmsInsps = new  ObservableCollection<GmsInspViewModel>();
            
            this.GmsInspTmps = new  ObservableCollection<GmsInspTmpViewModel>();
            
        }
        public override void Read()
        {
            this.Meteo=this.Model.Meteo;
        }
        public override void Write()
        {
            this.Model.Meteo=this.Meteo;
        }
        public virtual ObservableCollection<GmsInspViewModel> GmsInsps { get; set; }
        
        public virtual ObservableCollection<GmsInspTmpViewModel> GmsInspTmps { get; set; }
        
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
