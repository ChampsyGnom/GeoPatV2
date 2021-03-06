using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpNatureTravViewModel : ViewModelBase<EqpNatureTrav>
    {
        public EqpNatureTravViewModel(EqpNatureTrav model) : base(model)
        {
            this.EqpTravauxs = new  ObservableCollection<EqpTravauxViewModel>();
            
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
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Nature"] != null)
                {
                    errors.Add("Nature travaux : "+this["Nature"]);
                }
                if (errors.Count > 0)
                {
                    return String.Join("\r\n",errors);
                }
                else return null;
            }
        }
        public override string this[string columnName]
        {
            get
            {
                if (columnName.Equals("Nature"))
                {
                    if (String.IsNullOrEmpty(this.Nature))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
