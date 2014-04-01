using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpNatureTravViewModel : ViewModelBase
    {
        public EqpNatureTrav Model {get; set;}
        public EqpNatureTravViewModel(EqpNatureTrav model)
        {
            this.EqpTravauxs = new  ObservableCollection<EqpTravauxViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.EqpCdTravaux=new EqpCdTravauxViewModel( this.Model.EqpCdTravaux);
            this.Nature=this.Model.Nature;
        }
        public override void Write()
        {
            this.Model.EqpCdTravaux=this. EqpCdTravaux.Model;
            this.Model.Nature=this.Nature;
        }
        private EqpCdTravauxViewModel _eqpCdTravaux;
        [DisplayName("Code travaux")]
        public virtual EqpCdTravauxViewModel EqpCdTravaux
        {
            get
            {
                return this._eqpCdTravaux;
            }
            set
            {
                this._eqpCdTravaux = value;
                RaisePropertyChange("EqpCdTravaux");
            }
        }
        
        public virtual ObservableCollection<EqpTravauxViewModel> EqpTravauxs { get; set; }
        
        private String _nature;
        [DisplayName("Nature travaux")]
        public String Nature
        {
            get
            {
                return this._nature;
            }
            set
            {
                this._nature = value;
                RaisePropertyChange("Nature");
            }
        }
    }
}
