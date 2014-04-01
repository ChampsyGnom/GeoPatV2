using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnCdFameqpViewModel : ViewModelBase
    {
        public BsnCdFameqp Model {get; set;}
        public BsnCdFameqpViewModel(BsnCdFameqp model)
        {
            this.BsnCdTypeqps = new  ObservableCollection<BsnCdTypeqpViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.Fam=this.Model.Fam;
        }
        public override void Write()
        {
            this.Model.Fam=this.Fam;
        }
        public virtual ObservableCollection<BsnCdTypeqpViewModel> BsnCdTypeqps { get; set; }
        
        private String _fam;
        [DisplayName("Famille EQP")]
        public String Fam
        {
            get
            {
                return this._fam;
            }
            set
            {
                this._fam = value;
                RaisePropertyChange("Fam");
            }
        }
    }
}
