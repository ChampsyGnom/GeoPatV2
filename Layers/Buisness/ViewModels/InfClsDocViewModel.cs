using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfClsDocViewModel : ViewModelBase<InfClsDoc>
    {
        public InfClsDocViewModel(InfClsDoc model) : base(model)
        {
        }
        public override void Read()
        {
            this.InfDoc=new InfDocViewModel( this.Model.InfDoc);
            this.InfCls=new InfClsViewModel( this.Model.InfCls);
            this.Defaut=this.Model.Defaut;
            this.Dossier=this.Model.Dossier;
        }
        public override void Write()
        {
            this.Model.InfDoc=this. InfDoc.Model;
            this.Model.InfCls=this. InfCls.Model;
            this.Model.Defaut=this.Defaut;
            this.Model.Dossier=this.Dossier;
        }
        private InfDocViewModel _infDoc;
        [DisplayName("Document")]
        public virtual InfDocViewModel InfDoc
        {
            get
            {
                return this._infDoc;
            }
            set
            {
                this._infDoc = value;
                RaisePropertyChange("InfDoc");
            }
        }
        
        private InfClsViewModel _infCls;
        [DisplayName("Classeur")]
        public virtual InfClsViewModel InfCls
        {
            get
            {
                return this._infCls;
            }
            set
            {
                this._infCls = value;
                RaisePropertyChange("InfCls");
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
