using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class WebCdModeleViewModel : ViewModelBase
    {
        public WebCdModele Model {get; set;}
        public WebCdModeleViewModel(WebCdModele model)
        {
            this.WebModeles = new  ObservableCollection<WebModeleViewModel>();
            
            this.Model = model;
            this.Read();
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
    }
}
