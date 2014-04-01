using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GmsClsDocViewModel : ViewModelBase
    {
        public GmsClsDoc Model {get; set;}
        public GmsClsDocViewModel(GmsClsDoc model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.GmsCls=new GmsClsViewModel( this.Model.GmsCls);
            this.GmsDoc=new GmsDocViewModel( this.Model.GmsDoc);
            this.Defaut=this.Model.Defaut;
            this.Dossier=this.Model.Dossier;
        }
        public override void Write()
        {
            this.Model.GmsCls=this. GmsCls.Model;
            this.Model.GmsDoc=this. GmsDoc.Model;
            this.Model.Defaut=this.Defaut;
            this.Model.Dossier=this.Dossier;
        }
        private GmsClsViewModel _gmsCls;
        [DisplayName("Classeurs")]
        public virtual GmsClsViewModel GmsCls
        {
            get
            {
                return this._gmsCls;
            }
            set
            {
                this._gmsCls = value;
                RaisePropertyChange("GmsCls");
            }
        }
        
        private GmsDocViewModel _gmsDoc;
        [DisplayName("Documents")]
        public virtual GmsDocViewModel GmsDoc
        {
            get
            {
                return this._gmsDoc;
            }
            set
            {
                this._gmsDoc = value;
                RaisePropertyChange("GmsDoc");
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
