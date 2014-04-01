using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpDocViewModel : ViewModelBase
    {
        public EqpDoc Model {get; set;}
        public EqpDocViewModel(EqpDoc model)
        {
            this.EqpContacts = new  ObservableCollection<EqpContactViewModel>();
            
            this.EqpClsDocs = new  ObservableCollection<EqpClsDocViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.EqpCdDoc=new EqpCdDocViewModel( this.Model.EqpCdDoc);
            this.Id=this.Model.Id;
            this.Libelle=this.Model.Libelle;
            this.Ref=this.Model.Ref;
        }
        public override void Write()
        {
            this.Model.EqpCdDoc=this. EqpCdDoc.Model;
            this.Model.Id=this.Id;
            this.Model.Libelle=this.Libelle;
            this.Model.Ref=this.Ref;
        }
        private EqpCdDocViewModel _eqpCdDoc;
        [DisplayName("Type de document")]
        public virtual EqpCdDocViewModel EqpCdDoc
        {
            get
            {
                return this._eqpCdDoc;
            }
            set
            {
                this._eqpCdDoc = value;
                RaisePropertyChange("EqpCdDoc");
            }
        }
        
        public virtual ObservableCollection<EqpContactViewModel> EqpContacts { get; set; }
        
        public virtual ObservableCollection<EqpClsDocViewModel> EqpClsDocs { get; set; }
        
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
