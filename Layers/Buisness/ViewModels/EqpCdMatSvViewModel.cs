using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpCdMatSvViewModel : ViewModelBase<EqpCdMatSv>
    {
        public EqpCdMatSvViewModel(EqpCdMatSv model) : base(model)
        {
            this.EqpPanneaus = new  ObservableCollection<EqpPanneauViewModel>();
            
        }
        public override void Read()
        {
            this.Materiaux=this.Model.Materiaux;
            this.Garantie=this.Model.Garantie;
            this.Dvt=this.Model.Dvt;
        }
        public override void Write()
        {
            this.Model.Materiaux=this.Materiaux;
            this.Model.Garantie=this.Garantie;
            this.Model.Dvt=this.Dvt;
        }
        public virtual ObservableCollection<EqpPanneauViewModel> EqpPanneaus { get; set; }
        
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
        private Nullable<Int64> _garantie;
        [DisplayName("Garantie (mois)")]
        public Nullable<Int64> Garantie
        {
            get
            {
                return this._garantie;
            }
            set
            {
                this._garantie = value;
                RaisePropertyChange("Garantie");
            }
        }
        
        private Nullable<Int64> _dvt;
        [DisplayName("Durée de vie (mois)")]
        public Nullable<Int64> Dvt
        {
            get
            {
                return this._dvt;
            }
            set
            {
                this._dvt = value;
                RaisePropertyChange("Dvt");
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
                if (this["Garantie"] != null)
                {
                    errors.Add("Garantie (mois) : "+this["Garantie"]);
                }
                if (this["Dvt"] != null)
                {
                    errors.Add("Durée de vie (mois) : "+this["Dvt"]);
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
                if (columnName.Equals("Garantie"))
                {
                }
                if (columnName.Equals("Dvt"))
                {
                }
                return null;
            }
        }
    }
}
