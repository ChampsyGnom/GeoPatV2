using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class PrfBmTableViewModel : ViewModelBase
    {
        public PrfBmTable Model {get; set;}
        public PrfBmTableViewModel(PrfBmTable model)
        {
            this.PrfBmProfilTables = new  ObservableCollection<PrfBmProfilTableViewModel>();
            
            this.Model = model;
            this.Read();
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
    }
}
