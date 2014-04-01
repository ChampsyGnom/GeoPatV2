using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class PrfBmProfilViewModel : ViewModelBase
    {
        public PrfBmProfil Model {get; set;}
        public PrfBmProfilViewModel(PrfBmProfil model)
        {
            this.PrfBmProfilTables = new  ObservableCollection<PrfBmProfilTableViewModel>();
            
            this.PrfBmUserProfils = new  ObservableCollection<PrfBmUserProfilViewModel>();
            
            this.Model = model;
            this.Read();
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
    }
}
