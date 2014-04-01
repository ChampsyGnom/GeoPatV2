using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhClsDocViewModel : ViewModelBase
    {
        public OhClsDoc Model {get; set;}
        public OhClsDocViewModel(OhClsDoc model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.OhCls=new OhClsViewModel( this.Model.OhCls);
            this.OhDoc=new OhDocViewModel( this.Model.OhDoc);
            this.Defaut=this.Model.Defaut;
            this.Dossier=this.Model.Dossier;
        }
        public override void Write()
        {
            this.Model.OhCls=this. OhCls.Model;
            this.Model.OhDoc=this. OhDoc.Model;
            this.Model.Defaut=this.Defaut;
            this.Model.Dossier=this.Dossier;
        }
        private OhClsViewModel _ohCls;
        [DisplayName("Classeurs")]
        public virtual OhClsViewModel OhCls
        {
            get
            {
                return this._ohCls;
            }
            set
            {
                this._ohCls = value;
                RaisePropertyChange("OhCls");
            }
        }
        
        private OhDocViewModel _ohDoc;
        [DisplayName("Documents")]
        public virtual OhDocViewModel OhDoc
        {
            get
            {
                return this._ohDoc;
            }
            set
            {
                this._ohDoc = value;
                RaisePropertyChange("OhDoc");
            }
        }
        
        private Nullable<Boolean> _defaut;
        [DisplayName("Document par défaut")]
        public Nullable<Boolean> Defaut
        {
            get
            {
                return this._defaut;
            }
            set
            {
                this._defaut = value;
                RaisePropertyChange("Defaut");
            }
        }
        
        private String _dossier;
        [DisplayName("Dossier")]
        public String Dossier
        {
            get
            {
                return this._dossier;
            }
            set
            {
                this._dossier = value;
                RaisePropertyChange("Dossier");
            }
        }
    }
}
