using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpCdMateriauViewModel : ViewModelBase
    {
        public EqpCdMateriau Model {get; set;}
        public EqpCdMateriauViewModel(EqpCdMateriau model)
        {
            this.EqpCdRetenues = new  ObservableCollection<EqpCdRetenueViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.Materiaux=this.Model.Materiaux;
        }
        public override void Write()
        {
            this.Model.Materiaux=this.Materiaux;
        }
        public virtual ObservableCollection<EqpCdRetenueViewModel> EqpCdRetenues { get; set; }
        
        private String _materiaux;
        [DisplayName("Matériaux")]
        public String Materiaux
        {
            get
            {
                return this._materiaux;
            }
            set
            {
                this._materiaux = value;
                RaisePropertyChange("Materiaux");
            }
        }
    }
}
