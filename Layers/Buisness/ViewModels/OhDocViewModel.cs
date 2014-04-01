using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhDocViewModel : ViewModelBase
    {
        public OhDoc Model {get; set;}
        public OhDocViewModel(OhDoc model)
        {
            this.OhContacts = new  ObservableCollection<OhContactViewModel>();
            
            this.OhClsDocs = new  ObservableCollection<OhClsDocViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.OhCdDoc=new OhCdDocViewModel( this.Model.OhCdDoc);
            this.Id=this.Model.Id;
            this.Libelle=this.Model.Libelle;
            this.Ref=this.Model.Ref;
        }
        public override void Write()
        {
            this.Model.OhCdDoc=this. OhCdDoc.Model;
            this.Model.Id=this.Id;
            this.Model.Libelle=this.Libelle;
            this.Model.Ref=this.Ref;
        }
        private OhCdDocViewModel _ohCdDoc;
        [DisplayName("Type de document")]
        public virtual OhCdDocViewModel OhCdDoc
        {
            get
            {
                return this._ohCdDoc;
            }
            set
            {
                this._ohCdDoc = value;
                RaisePropertyChange("OhCdDoc");
            }
        }
        
        public virtual ObservableCollection<OhContactViewModel> OhContacts { get; set; }
        
        public virtual ObservableCollection<OhClsDocViewModel> OhClsDocs { get; set; }
        
        private Int64 _id;
        [DisplayName("Id document")]
        public Int64 Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
                RaisePropertyChange("Id");
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
        private String _ref;
        [DisplayName("Réference (fichier)")]
        public String Ref
        {
            get
            {
                return this._ref;
            }
            set
            {
                this._ref = value;
                RaisePropertyChange("Ref");
            }
        }
    }
}
