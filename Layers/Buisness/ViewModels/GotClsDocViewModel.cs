using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotClsDocViewModel : ViewModelBase<GotClsDoc>
    {
        public GotClsDocViewModel(GotClsDoc model) : base(model)
        {
        }
        public override void Read()
        {
            this.GotCls=new GotClsViewModel( this.Model.GotCls);
            this.GotDoc=new GotDocViewModel( this.Model.GotDoc);
            this.Defaut=this.Model.Defaut;
            this.Dossier=this.Model.Dossier;
        }
        public override void Write()
        {
            this.Model.GotCls=this. GotCls.Model;
            this.Model.GotDoc=this. GotDoc.Model;
            this.Model.Defaut=this.Defaut;
            this.Model.Dossier=this.Dossier;
        }
        private GotClsViewModel _gotCls;
        [DisplayName("Classeurs")]
        public virtual GotClsViewModel GotCls
        {
            get
            {
                return this._gotCls;
            }
            set
            {
                this._gotCls = value;
                RaisePropertyChange("GotCls");
            }
        }
        
        private GotDocViewModel _gotDoc;
        [DisplayName("Documents")]
        public virtual GotDocViewModel GotDoc
        {
            get
            {
                return this._gotDoc;
            }
            set
            {
                this._gotDoc = value;
                RaisePropertyChange("GotDoc");
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
