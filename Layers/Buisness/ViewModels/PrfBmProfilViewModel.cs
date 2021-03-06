using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class PrfBmProfilViewModel : ViewModelBase<PrfBmProfil>
    {
        public PrfBmProfilViewModel(PrfBmProfil model) : base(model)
        {
            this.PrfBmProfilTables = new  ObservableCollection<PrfBmProfilTableViewModel>();
            
            this.PrfBmUserProfils = new  ObservableCollection<PrfBmUserProfilViewModel>();
            
        }
        public override void Read()
        {
            this.PrfBmSchema=new PrfBmSchemaViewModel( this.Model.PrfBmSchema);
            this.Profil=this.Model.Profil;
            this.Libelle=this.Model.Libelle;
        }
        public override void Write()
        {
            this.Model.PrfBmSchema=this. PrfBmSchema.Model;
            this.Model.Profil=this.Profil;
            this.Model.Libelle=this.Libelle;
        }
        private PrfBmSchemaViewModel _prfBmSchema;
        [DisplayName("Schéma BM")]
        public virtual PrfBmSchemaViewModel PrfBmSchema
        {
            get
            {
                return this._prfBmSchema;
            }
            set
            {
                this._prfBmSchema = value;
                RaisePropertyChange("PrfBmSchema");
            }
        }
        
        public virtual ObservableCollection<PrfBmProfilTableViewModel> PrfBmProfilTables { get; set; }
        
        public virtual ObservableCollection<PrfBmUserProfilViewModel> PrfBmUserProfils { get; set; }
        
        private String _profil;
        [DisplayName("Profil")]
        public String Profil
        {
            get
            {
                return this._profil;
            }
            set
            {
                this._profil = value;
                RaisePropertyChange("Profil");
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
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Profil"] != null)
                {
                    errors.Add("Profil : "+this["Profil"]);
                }
                if (this["Libelle"] != null)
                {
                    errors.Add("Libellé : "+this["Libelle"]);
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
                if (columnName.Equals("Profil"))
                {
                    if (String.IsNullOrEmpty(this.Profil))
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
