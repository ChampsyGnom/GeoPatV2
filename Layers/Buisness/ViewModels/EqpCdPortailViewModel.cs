using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpCdPortailViewModel : ViewModelBase<EqpCdPortail>
    {
        public EqpCdPortailViewModel(EqpCdPortail model) : base(model)
        {
            this.EqpDscPos = new  ObservableCollection<EqpDscPoViewModel>();
            
        }
        public override void Read()
        {
            this.Portail=this.Model.Portail;
            this.Garantie=this.Model.Garantie;
            this.Dvt=this.Model.Dvt;
        }
        public override void Write()
        {
            this.Model.Portail=this.Portail;
            this.Model.Garantie=this.Garantie;
            this.Model.Dvt=this.Dvt;
        }
        public virtual ObservableCollection<EqpDscPoViewModel> EqpDscPos { get; set; }
        
        private String _portail;
        [DisplayName("Portail")]
        public String Portail
        {
            get
            {
                return this._portail;
            }
            set
            {
                this._portail = value;
                RaisePropertyChange("Portail");
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
                if (this["Portail"] != null)
                {
                    errors.Add("Portail : "+this["Portail"]);
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
                if (columnName.Equals("Portail"))
                {
                    if (String.IsNullOrEmpty(this.Portail))
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
