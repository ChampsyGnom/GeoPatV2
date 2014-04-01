using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfDocViewModel : ViewModelBase
    {
        public InfDoc Model {get; set;}
        public InfDocViewModel(InfDoc model)
        {
            this.InfContacts = new  ObservableCollection<InfContactViewModel>();
            
            this.InfClsDocs = new  ObservableCollection<InfClsDocViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.InfCdDoc=new InfCdDocViewModel( this.Model.InfCdDoc);
            this.Id=this.Model.Id;
            this.Libelle=this.Model.Libelle;
            this.Ref=this.Model.Ref;
        }
        public override void Write()
        {
            this.Model.InfCdDoc=this. InfCdDoc.Model;
            this.Model.Id=this.Id;
            this.Model.Libelle=this.Libelle;
            this.Model.Ref=this.Ref;
        }
        private InfCdDocViewModel _infCdDoc;
        [DisplayName("Type de document")]
        public virtual InfCdDocViewModel InfCdDoc
        {
            get
            {
                return this._infCdDoc;
            }
            set
            {
                this._infCdDoc = value;
                RaisePropertyChange("InfCdDoc");
            }
        }
        
        public virtual ObservableCollection<InfContactViewModel> InfContacts { get; set; }
        
        public virtual ObservableCollection<InfClsDocViewModel> InfClsDocs { get; set; }
        
        private Int64 _id;
        [DisplayName("Identificant(cpt)")]
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
        [DisplayName("Référence")]
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
