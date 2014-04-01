using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnCdMeteoViewModel : ViewModelBase<BsnCdMeteo>
    {
        public BsnCdMeteoViewModel(BsnCdMeteo model) : base(model)
        {
            this.BsnInsps = new  ObservableCollection<BsnInspViewModel>();
            
            this.BsnInspTmps = new  ObservableCollection<BsnInspTmpViewModel>();
            
        }
        public override void Read()
        {
            this.Meteo=this.Model.Meteo;
        }
        public override void Write()
        {
            this.Model.Meteo=this.Meteo;
        }
        public virtual ObservableCollection<BsnInspViewModel> BsnInsps { get; set; }
        
        public virtual ObservableCollection<BsnInspTmpViewModel> BsnInspTmps { get; set; }
        
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
