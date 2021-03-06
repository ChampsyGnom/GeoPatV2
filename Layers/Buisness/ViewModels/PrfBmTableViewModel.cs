using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class PrfBmTableViewModel : ViewModelBase<PrfBmTable>
    {
        public PrfBmTableViewModel(PrfBmTable model) : base(model)
        {
            this.PrfBmProfilTables = new  ObservableCollection<PrfBmProfilTableViewModel>();
            
        }
        public override void Read()
        {
            this.PrfBmSchema=new PrfBmSchemaViewModel( this.Model.PrfBmSchema);
            this.Nom=this.Model.Nom;
            this.Libelle=this.Model.Libelle;
        }
        public override void Write()
        {
            this.Model.PrfBmSchema=this. PrfBmSchema.Model;
            this.Model.Nom=this.Nom;
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
        
        private String _nom;
        [DisplayName("Nom")]
        public String Nom
        {
            get
            {
                return this._nom;
            }
            set
            {
                this._nom = value;
                RaisePropertyChange("Nom");
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
                if (this["Nom"] != null)
                {
                    errors.Add("Nom : "+this["Nom"]);
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
                if (columnName.Equals("Nom"))
                {
                    if (String.IsNullOrEmpty(this.Nom))
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
