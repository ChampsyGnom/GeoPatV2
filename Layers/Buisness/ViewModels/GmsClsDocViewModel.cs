using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GmsClsDocViewModel : ViewModelBase<GmsClsDoc>
    {
        public GmsClsDocViewModel(GmsClsDoc model) : base(model)
        {
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
