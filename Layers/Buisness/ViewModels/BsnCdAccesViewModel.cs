using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnCdAccesViewModel : ViewModelBase<BsnCdAcces>
    {
        public BsnCdAccesViewModel(BsnCdAcces model) : base(model)
        {
            this.BsnDscs = new  ObservableCollection<BsnDscViewModel>();
            
            this.BsnDscTemps = new  ObservableCollection<BsnDscTempViewModel>();
            
        }
        public override void Read()
        {
            this.Vacces=this.Model.Vacces;
        }
        public override void Write()
        {
            this.Model.Vacces=this.Vacces;
        }
        public virtual ObservableCollection<BsnDscViewModel> BsnDscs { get; set; }
        
        public virtual ObservableCollection<BsnDscTempViewModel> BsnDscTemps { get; set; }
        
        private String _vacces;
        [DisplayName("Voie d'accès")]
        public String Vacces
        {
            get
            {
                return this._vacces;
            }
            set
            {
                this._vacces = value;
                RaisePropertyChange("Vacces");
            }
        }
    }
}
