using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnCdSousTypeViewModel : ViewModelBase
    {
        public BsnCdSousType Model {get; set;}
        public BsnCdSousTypeViewModel(BsnCdSousType model)
        {
            this.BsnDscs = new  ObservableCollection<BsnDscViewModel>();
            
            this.BsnDscTemps = new  ObservableCollection<BsnDscTempViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.NatSensib=this.Model.NatSensib;
        }
        public override void Write()
        {
            this.Model.NatSensib=this.NatSensib;
        }
        public virtual ObservableCollection<BsnDscViewModel> BsnDscs { get; set; }
        
        public virtual ObservableCollection<BsnDscTempViewModel> BsnDscTemps { get; set; }
        
        private String _natSensib;
        [DisplayName("Nature sensibilité")]
        public String NatSensib
        {
            get
            {
                return this._natSensib;
            }
            set
            {
                this._natSensib = value;
                RaisePropertyChange("NatSensib");
            }
        }
    }
}
