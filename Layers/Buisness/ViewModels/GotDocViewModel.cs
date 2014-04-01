using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotDocViewModel : ViewModelBase<GotDoc>
    {
        public GotDocViewModel(GotDoc model) : base(model)
        {
            this.GotContacts = new  ObservableCollection<GotContactViewModel>();
            
            this.GotClsDocs = new  ObservableCollection<GotClsDocViewModel>();
            
        }
        public override void Read()
        {
            this.GotCdDoc=new GotCdDocViewModel( this.Model.GotCdDoc);
            this.Id=this.Model.Id;
            this.Libelle=this.Model.Libelle;
            this.Ref=this.Model.Ref;
        }
        public override void Write()
        {
            this.Model.GotCdDoc=this. GotCdDoc.Model;
            this.Model.Id=this.Id;
            this.Model.Libelle=this.Libelle;
            this.Model.Ref=this.Ref;
        }
        private GotCdDocViewModel _gotCdDoc;
        [DisplayName("Types de document")]
        public virtual GotCdDocViewModel GotCdDoc
        {
            get
            {
                return this._gotCdDoc;
            }
            set
            {
                this._gotCdDoc = value;
                RaisePropertyChange("GotCdDoc");
            }
        }
        
        public virtual ObservableCollection<GotContactViewModel> GotContacts { get; set; }
        
        public virtual ObservableCollection<GotClsDocViewModel> GotClsDocs { get; set; }
        
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
