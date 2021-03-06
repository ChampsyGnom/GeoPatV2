using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpCdMateriauViewModel : ViewModelBase<EqpCdMateriau>
    {
        public EqpCdMateriauViewModel(EqpCdMateriau model) : base(model)
        {
            this.EqpCdRetenues = new  ObservableCollection<EqpCdRetenueViewModel>();
            
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
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Materiaux"] != null)
                {
                    errors.Add("Matériaux : "+this["Materiaux"]);
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
                if (columnName.Equals("Materiaux"))
                {
                    if (String.IsNullOrEmpty(this.Materiaux))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
