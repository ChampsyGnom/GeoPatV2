using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnClsDocViewModel : ViewModelBase<BsnClsDoc>
    {
        public BsnClsDocViewModel(BsnClsDoc model) : base(model)
        {
        }
        public override void Read()
        {
            this.BsnCls=new BsnClsViewModel( this.Model.BsnCls);
            this.BsnDoc=new BsnDocViewModel( this.Model.BsnDoc);
            this.Defaut=this.Model.Defaut;
            this.Dossier=this.Model.Dossier;
        }
        public override void Write()
        {
            this.Model.BsnCls=this. BsnCls.Model;
            this.Model.BsnDoc=this. BsnDoc.Model;
            this.Model.Defaut=this.Defaut;
            this.Model.Dossier=this.Dossier;
        }
        private BsnClsViewModel _bsnCls;
        [DisplayName("Classeurs")]
        public virtual BsnClsViewModel BsnCls
        {
            get
            {
                return this._bsnCls;
            }
            set
            {
                this._bsnCls = value;
                RaisePropertyChange("BsnCls");
            }
        }
        
        private BsnDocViewModel _bsnDoc;
        [DisplayName("Documents")]
        public virtual BsnDocViewModel BsnDoc
        {
            get
            {
                return this._bsnDoc;
            }
            set
            {
                this._bsnDoc = value;
                RaisePropertyChange("BsnDoc");
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
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Defaut"] != null)
                {
                    errors.Add("Document par défaut : "+this["Defaut"]);
                }
                if (this["Dossier"] != null)
                {
                    errors.Add("Dossier : "+this["Dossier"]);
                }
                if (errors.Count > 0)
                {
                    return String.Join("\r\n",errors);
                }
                else return null;
            }
        }
        public override string this[string columnName]
        {
            get
            {
                if (columnName.Equals("Defaut"))
                {
                }
                if (columnName.Equals("Dossier"))
                {
                }
                return null;
            }
        }
    }
}
