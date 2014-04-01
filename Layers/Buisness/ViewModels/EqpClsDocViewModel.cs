using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpClsDocViewModel : ViewModelBase<EqpClsDoc>
    {
        public EqpClsDocViewModel(EqpClsDoc model) : base(model)
        {
        }
        public override void Read()
        {
            this.EqpCls=new EqpClsViewModel( this.Model.EqpCls);
            this.EqpDoc=new EqpDocViewModel( this.Model.EqpDoc);
            this.Defaut=this.Model.Defaut;
            this.Dossier=this.Model.Dossier;
        }
        public override void Write()
        {
            this.Model.EqpCls=this. EqpCls.Model;
            this.Model.EqpDoc=this. EqpDoc.Model;
            this.Model.Defaut=this.Defaut;
            this.Model.Dossier=this.Dossier;
        }
        private EqpClsViewModel _eqpCls;
        [DisplayName("Classeurs")]
        public virtual EqpClsViewModel EqpCls
        {
            get
            {
                return this._eqpCls;
            }
            set
            {
                this._eqpCls = value;
                RaisePropertyChange("EqpCls");
            }
        }
        
        private EqpDocViewModel _eqpDoc;
        [DisplayName("Documents")]
        public virtual EqpDocViewModel EqpDoc
        {
            get
            {
                return this._eqpDoc;
            }
            set
            {
                this._eqpDoc = value;
                RaisePropertyChange("EqpDoc");
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
