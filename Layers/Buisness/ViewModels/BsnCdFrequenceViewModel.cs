using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnCdFrequenceViewModel : ViewModelBase
    {
        public BsnCdFrequence Model {get; set;}
        public BsnCdFrequenceViewModel(BsnCdFrequence model)
        {
            this.BsnDscs = new  ObservableCollection<BsnDscViewModel>();
            
            this.BsnDscTemps = new  ObservableCollection<BsnDscTempViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.Freq=this.Model.Freq;
        }
        public override void Write()
        {
            this.Model.Freq=this.Freq;
        }
        public virtual ObservableCollection<BsnDscViewModel> BsnDscs { get; set; }
        
        public virtual ObservableCollection<BsnDscTempViewModel> BsnDscTemps { get; set; }
        
        private String _freq;
        [DisplayName("Fréquence")]
        public String Freq
        {
            get
            {
                return this._freq;
            }
            set
            {
                this._freq = value;
                RaisePropertyChange("Freq");
            }
        }
    }
}
