using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpCdExtAvViewModel : ViewModelBase
    {
        public EqpCdExtAv Model {get; set;}
        public EqpCdExtAvViewModel(EqpCdExtAv model)
        {
            this.EqpDscEss = new  ObservableCollection<EqpDscEsViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.ExtFin=this.Model.ExtFin;
        }
        public override void Write()
        {
            this.Model.ExtFin=this.ExtFin;
        }
        public virtual ObservableCollection<EqpDscEsViewModel> EqpDscEss { get; set; }
        
        private String _extFin;
        [DisplayName("Extrémité fin")]
        public String ExtFin
        {
            get
            {
                return this._extFin;
            }
            set
            {
                this._extFin = value;
                RaisePropertyChange("ExtFin");
            }
        }
    }
}
