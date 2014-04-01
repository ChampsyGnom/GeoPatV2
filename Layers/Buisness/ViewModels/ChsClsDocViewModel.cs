using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsClsDocViewModel : ViewModelBase
    {
        public ChsClsDoc Model {get; set;}
        public ChsClsDocViewModel(ChsClsDoc model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.ChsCls=new ChsClsViewModel( this.Model.ChsCls);
            this.ChsDoc=new ChsDocViewModel( this.Model.ChsDoc);
            this.Defaut=this.Model.Defaut;
            this.Dossier=this.Model.Dossier;
        }
        public override void Write()
        {
            this.Model.ChsCls=this. ChsCls.Model;
            this.Model.ChsDoc=this. ChsDoc.Model;
            this.Model.Defaut=this.Defaut;
            this.Model.Dossier=this.Dossier;
        }
        private ChsClsViewModel _chsCls;
        [DisplayName("Classeurs")]
        public virtual ChsClsViewModel ChsCls
        {
            get
            {
                return this._chsCls;
            }
            set
            {
                this._chsCls = value;
                RaisePropertyChange("ChsCls");
            }
        }
        
        private ChsDocViewModel _chsDoc;
        [DisplayName("Documents")]
        public virtual ChsDocViewModel ChsDoc
        {
            get
            {
                return this._chsDoc;
            }
            set
            {
                this._chsDoc = value;
                RaisePropertyChange("ChsDoc");
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
