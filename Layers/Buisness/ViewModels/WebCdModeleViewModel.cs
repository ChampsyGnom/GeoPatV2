using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class WebCdModeleViewModel : ViewModelBase<WebCdModele>
    {
        public WebCdModeleViewModel(WebCdModele model) : base(model)
        {
            this.WebModeles = new  ObservableCollection<WebModeleViewModel>();
            
        }
        public override void Read()
        {
            this.Code=this.Model.Code;
            this.Libelle=this.Model.Libelle;
        }
        public override void Write()
        {
            this.Model.Code=this.Code;
            this.Model.Libelle=this.Libelle;
        }
        public virtual ObservableCollection<WebModeleViewModel> WebModeles { get; set; }
        
        private String _code;
        [DisplayName("Code du type de modèle (SIG_REF_DETAIL SIG_REF_SCHEMA)")]
        public String Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
                RaisePropertyChange("Code");
            }
        }
        private String _libelle;
        [DisplayName("Nom du type de modele (detail synoptique schématique)")]
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
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Code"] != null)
                {
                    errors.Add("Code du type de modèle (SIG_REF_DETAIL SIG_REF_SCHEMA) : "+this["Code"]);
                }
                if (this["Libelle"] != null)
                {
                    errors.Add("Nom du type de modele (detail synoptique schématique) : "+this["Libelle"]);
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
                if (columnName.Equals("Code"))
                {
                    if (String.IsNullOrEmpty(this.Code))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("Libelle"))
                {
                    if (String.IsNullOrEmpty(this.Libelle))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
