using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpCdExtAmViewModel : ViewModelBase
    {
        public EqpCdExtAm Model {get; set;}
        public EqpCdExtAmViewModel(EqpCdExtAm model)
        {
            this.EqpDscEss = new  ObservableCollection<EqpDscEsViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.ExtDeb=this.Model.ExtDeb;
        }
        public override void Write()
        {
            this.Model.ExtDeb=this.ExtDeb;
        }
        public virtual ObservableCollection<EqpDscEsViewModel> EqpDscEss { get; set; }
        
        private String _extDeb;
        [DisplayName("Extrémité début")]
        public String ExtDeb
        {
            get
            {
                return this._extDeb;
            }
            set
            {
                this._extDeb = value;
                RaisePropertyChange("ExtDeb");
            }
        }
    }
}
