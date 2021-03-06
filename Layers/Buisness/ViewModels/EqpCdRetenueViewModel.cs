using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpCdRetenueViewModel : ViewModelBase<EqpCdRetenue>
    {
        public EqpCdRetenueViewModel(EqpCdRetenue model) : base(model)
        {
            this.EqpDscEss = new  ObservableCollection<EqpDscEsViewModel>();
            
        }
        public override void Read()
        {
            this.EqpCdMateriau=new EqpCdMateriauViewModel( this.Model.EqpCdMateriau);
            this.Dispositif=this.Model.Dispositif;
            this.Libelle=this.Model.Libelle;
            this.Garantie=this.Model.Garantie;
            this.Dvt=this.Model.Dvt;
        }
        public override void Write()
        {
            this.Model.EqpCdMateriau=this. EqpCdMateriau.Model;
            this.Model.Dispositif=this.Dispositif;
            this.Model.Libelle=this.Libelle;
            this.Model.Garantie=this.Garantie;
            this.Model.Dvt=this.Dvt;
        }
        private EqpCdMateriauViewModel _eqpCdMateriau;
        [DisplayName("Type de Matériaux")]
        public virtual EqpCdMateriauViewModel EqpCdMateriau
        {
            get
            {
                return this._eqpCdMateriau;
            }
            set
            {
                this._eqpCdMateriau = value;
                RaisePropertyChange("EqpCdMateriau");
            }
        }
        
        public virtual ObservableCollection<EqpDscEsViewModel> EqpDscEss { get; set; }
        
        private String _dispositif;
        [DisplayName("Type de Dispositif")]
        public String Dispositif
        {
            get
            {
                return this._dispositif;
            }
            set
            {
                this._dispositif = value;
                RaisePropertyChange("Dispositif");
            }
        }
        private String _libelle;
        [DisplayName("Libellé")]
        public String Libelle
        {
            get
            {
                return this._libelle;
            }
            set
            {
                this._libelle = value;
                RaisePropertyChange("Libelle");
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
                if (this["Dispositif"] != null)
                {
                    errors.Add("Type de Dispositif : "+this["Dispositif"]);
                }
                if (this["Libelle"] != null)
                {
                    errors.Add("Libellé : "+this["Libelle"]);
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
                if (columnName.Equals("Dispositif"))
                {
                    if (String.IsNullOrEmpty(this.Dispositif))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("Libelle"))
                {
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
