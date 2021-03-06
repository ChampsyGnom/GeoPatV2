using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaCdChapitreViewModel : ViewModelBase<OaCdChapitre>
    {
        public OaCdChapitreViewModel(OaCdChapitre model) : base(model)
        {
            this.OaCdLignes = new  ObservableCollection<OaCdLigneViewModel>();
            
        }
        public override void Read()
        {
            this.IdChap=this.Model.IdChap;
            this.Libelle=this.Model.Libelle;
            this.OrdreChap=this.Model.OrdreChap;
            this.Ponderation=this.Model.Ponderation;
        }
        public override void Write()
        {
            this.Model.IdChap=this.IdChap;
            this.Model.Libelle=this.Libelle;
            this.Model.OrdreChap=this.OrdreChap;
            this.Model.Ponderation=this.Ponderation;
        }
        public virtual ObservableCollection<OaCdLigneViewModel> OaCdLignes { get; set; }
        
        private Int64 _idChap;
        [DisplayName("Identifiant chapitre")]
        public Int64 IdChap
        {
            get
            {
                return this._idChap;
            }
            set
            {
                this._idChap = value;
                RaisePropertyChange("IdChap");
            }
        }
        
        private String _libelle;
        [DisplayName("Libellé chapitre")]
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
        private Int64 _ordreChap;
        [DisplayName("N° ordre chapitre")]
        public Int64 OrdreChap
        {
            get
            {
                return this._ordreChap;
            }
            set
            {
                this._ordreChap = value;
                RaisePropertyChange("OrdreChap");
            }
        }
        
        private Nullable<Int64> _ponderation;
        [DisplayName("Pondération")]
        public Nullable<Int64> Ponderation
        {
            get
            {
                return this._ponderation;
            }
            set
            {
                this._ponderation = value;
                RaisePropertyChange("Ponderation");
            }
        }
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["IdChap"] != null)
                {
                    errors.Add("Identifiant chapitre : "+this["IdChap"]);
                }
                if (this["Libelle"] != null)
                {
                    errors.Add("Libellé chapitre : "+this["Libelle"]);
                }
                if (this["OrdreChap"] != null)
                {
                    errors.Add("N° ordre chapitre : "+this["OrdreChap"]);
                }
                if (this["Ponderation"] != null)
                {
                    errors.Add("Pondération : "+this["Ponderation"]);
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
                if (columnName.Equals("IdChap"))
                {
                }
                if (columnName.Equals("Libelle"))
                {
                    if (String.IsNullOrEmpty(this.Libelle))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("OrdreChap"))
                {
                }
                if (columnName.Equals("Ponderation"))
                {
                }
                return null;
            }
        }
    }
}
