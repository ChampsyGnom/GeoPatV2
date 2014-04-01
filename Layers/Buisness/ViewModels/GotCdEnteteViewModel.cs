using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotCdEnteteViewModel : ViewModelBase
    {
        public GotCdEntete Model {get; set;}
        public GotCdEnteteViewModel(GotCdEntete model)
        {
            this.GotEntetes = new  ObservableCollection<GotEnteteViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.GotCdComposant=new GotCdComposantViewModel( this.Model.GotCdComposant);
            this.IdEntete=this.Model.IdEntete;
            this.Libelle=this.Model.Libelle;
            this.OrdreEnt=this.Model.OrdreEnt;
            this.Guide=this.Model.Guide;
        }
        public override void Write()
        {
            this.Model.GotCdComposant=this. GotCdComposant.Model;
            this.Model.IdEntete=this.IdEntete;
            this.Model.Libelle=this.Libelle;
            this.Model.OrdreEnt=this.OrdreEnt;
            this.Model.Guide=this.Guide;
        }
        private GotCdComposantViewModel _gotCdComposant;
        [DisplayName("Type Composant")]
        public virtual GotCdComposantViewModel GotCdComposant
        {
            get
            {
                return this._gotCdComposant;
            }
            set
            {
                this._gotCdComposant = value;
                RaisePropertyChange("GotCdComposant");
            }
        }
        
        public virtual ObservableCollection<GotEnteteViewModel> GotEntetes { get; set; }
        
        private Int64 _idEntete;
        [DisplayName("Identifiant Entête")]
        public Int64 IdEntete
        {
            get
            {
                return this._idEntete;
            }
            set
            {
                this._idEntete = value;
                RaisePropertyChange("IdEntete");
            }
        }
        
        private String _libelle;
        [DisplayName("Ligne d'entête")]
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
        private Int64 _ordreEnt;
        [DisplayName("Ordre")]
        public Int64 OrdreEnt
        {
            get
            {
                return this._ordreEnt;
            }
            set
            {
                this._ordreEnt = value;
                RaisePropertyChange("OrdreEnt");
            }
        }
        
        private String _guide;
        [DisplayName("Guide")]
        public String Guide
        {
            get
            {
                return this._guide;
            }
            set
            {
                this._guide = value;
                RaisePropertyChange("Guide");
            }
        }
    }
}
