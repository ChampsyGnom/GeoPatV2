using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaCdLigneViewModel : ViewModelBase<OaCdLigne>
    {
        public OaCdLigneViewModel(OaCdLigne model) : base(model)
        {
            this.OaSprtVsts = new  ObservableCollection<OaSprtVstViewModel>();
            
        }
        public override void Read()
        {
            this.OaCdChapitre=new OaCdChapitreViewModel( this.Model.OaCdChapitre);
            this.IdLigne=this.Model.IdLigne;
            this.Libelle=this.Model.Libelle;
            this.OrdreLigne=this.Model.OrdreLigne;
        }
        public override void Write()
        {
            this.Model.OaCdChapitre=this. OaCdChapitre.Model;
            this.Model.IdLigne=this.IdLigne;
            this.Model.Libelle=this.Libelle;
            this.Model.OrdreLigne=this.OrdreLigne;
        }
        private OaCdChapitreViewModel _oaCdChapitre;
        [DisplayName("Chapitre")]
        public virtual OaCdChapitreViewModel OaCdChapitre
        {
            get
            {
                return this._oaCdChapitre;
            }
            set
            {
                this._oaCdChapitre = value;
                RaisePropertyChange("OaCdChapitre");
            }
        }
        
        public virtual ObservableCollection<OaSprtVstViewModel> OaSprtVsts { get; set; }
        
        private Int64 _idLigne;
        [DisplayName("Identifiant ligne")]
        public Int64 IdLigne
        {
            get
            {
                return this._idLigne;
            }
            set
            {
                this._idLigne = value;
                RaisePropertyChange("IdLigne");
            }
        }
        
        private String _libelle;
        [DisplayName("Libellé Ligne")]
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
        private Int64 _ordreLigne;
        [DisplayName("N° ordre ligne")]
        public Int64 OrdreLigne
        {
            get
            {
                return this._ordreLigne;
            }
            set
            {
                this._ordreLigne = value;
                RaisePropertyChange("OrdreLigne");
            }
        }
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["IdLigne"] != null)
                {
                    errors.Add("Identifiant ligne : "+this["IdLigne"]);
                }
                if (this["Libelle"] != null)
                {
                    errors.Add("Libellé Ligne : "+this["Libelle"]);
                }
                if (this["OrdreLigne"] != null)
                {
                    errors.Add("N° ordre ligne : "+this["OrdreLigne"]);
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
                if (columnName.Equals("IdLigne"))
                {
                }
                if (columnName.Equals("Libelle"))
                {
                    if (String.IsNullOrEmpty(this.Libelle))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("OrdreLigne"))
                {
                }
                return null;
            }
        }
    }
}
