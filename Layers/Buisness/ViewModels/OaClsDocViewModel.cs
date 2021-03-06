using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaClsDocViewModel : ViewModelBase<OaClsDoc>
    {
        public OaClsDocViewModel(OaClsDoc model) : base(model)
        {
        }
        public override void Read()
        {
            this.OaCls=new OaClsViewModel( this.Model.OaCls);
            this.OaDoc=new OaDocViewModel( this.Model.OaDoc);
            this.Defaut=this.Model.Defaut;
            this.Dossier=this.Model.Dossier;
        }
        public override void Write()
        {
            this.Model.OaCls=this. OaCls.Model;
            this.Model.OaDoc=this. OaDoc.Model;
            this.Model.Defaut=this.Defaut;
            this.Model.Dossier=this.Dossier;
        }
        private OaClsViewModel _oaCls;
        [DisplayName("Classeurs")]
        public virtual OaClsViewModel OaCls
        {
            get
            {
                return this._oaCls;
            }
            set
            {
                this._oaCls = value;
                RaisePropertyChange("OaCls");
            }
        }
        
        private OaDocViewModel _oaDoc;
        [DisplayName("Documents")]
        public virtual OaDocViewModel OaDoc
        {
            get
            {
                return this._oaDoc;
            }
            set
            {
                this._oaDoc = value;
                RaisePropertyChange("OaDoc");
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
