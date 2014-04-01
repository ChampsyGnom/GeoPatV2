using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaCdEnteteViewModel : ViewModelBase
    {
        public OaCdEntete Model {get; set;}
        public OaCdEnteteViewModel(OaCdEntete model)
        {
            this.OaEntetes = new  ObservableCollection<OaEnteteViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.OaCdComposant=new OaCdComposantViewModel( this.Model.OaCdComposant);
            this.IdEntete=this.Model.IdEntete;
            this.Libelle=this.Model.Libelle;
            this.OrdreEnt=this.Model.OrdreEnt;
            this.Guide=this.Model.Guide;
        }
        public override void Write()
        {
            this.Model.OaCdComposant=this. OaCdComposant.Model;
            this.Model.IdEntete=this.IdEntete;
            this.Model.Libelle=this.Libelle;
            this.Model.OrdreEnt=this.OrdreEnt;
            this.Model.Guide=this.Guide;
        }
        private OaCdComposantViewModel _oaCdComposant;
        [DisplayName("Type Composant")]
        public virtual OaCdComposantViewModel OaCdComposant
        {
            get
            {
                return this._oaCdComposant;
            }
            set
            {
                this._oaCdComposant = value;
                RaisePropertyChange("OaCdComposant");
            }
        }
        
        public virtual ObservableCollection<OaEnteteViewModel> OaEntetes { get; set; }
        
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
        [DisplayName("Libellé Entête")]
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
        [DisplayName("N° ordre Entête")]
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
