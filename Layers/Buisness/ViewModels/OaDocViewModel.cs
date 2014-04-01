using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaDocViewModel : ViewModelBase
    {
        public OaDoc Model {get; set;}
        public OaDocViewModel(OaDoc model)
        {
            this.OaContacts = new  ObservableCollection<OaContactViewModel>();
            
            this.OaClsDocs = new  ObservableCollection<OaClsDocViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.OaCdDoc=new OaCdDocViewModel( this.Model.OaCdDoc);
            this.Id=this.Model.Id;
            this.Libelle=this.Model.Libelle;
            this.Ref=this.Model.Ref;
        }
        public override void Write()
        {
            this.Model.OaCdDoc=this. OaCdDoc.Model;
            this.Model.Id=this.Id;
            this.Model.Libelle=this.Libelle;
            this.Model.Ref=this.Ref;
        }
        private OaCdDocViewModel _oaCdDoc;
        [DisplayName("Types de document")]
        public virtual OaCdDocViewModel OaCdDoc
        {
            get
            {
                return this._oaCdDoc;
            }
            set
            {
                this._oaCdDoc = value;
                RaisePropertyChange("OaCdDoc");
            }
        }
        
        public virtual ObservableCollection<OaContactViewModel> OaContacts { get; set; }
        
        public virtual ObservableCollection<OaClsDocViewModel> OaClsDocs { get; set; }
        
        private Int64 _id;
        [DisplayName("Identifiant document(cpt)")]
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
        [DisplayName("Réference(fichier)")]
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
