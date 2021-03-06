using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaCdDocViewModel : ViewModelBase<OaCdDoc>
    {
        public OaCdDocViewModel(OaCdDoc model) : base(model)
        {
            this.OaDocs = new  ObservableCollection<OaDocViewModel>();
            
        }
        public override void Read()
        {
            this.Code=this.Model.Code;
            this.Libelle=this.Model.Libelle;
            this.Path=this.Model.Path;
        }
        public override void Write()
        {
            this.Model.Code=this.Code;
            this.Model.Libelle=this.Libelle;
            this.Model.Path=this.Path;
        }
        public virtual ObservableCollection<OaDocViewModel> OaDocs { get; set; }
        
        private String _code;
        [DisplayName("Code")]
        public String Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
                RaisePropertyChange("Code");
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
        private String _path;
        [DisplayName("Répertoire")]
        public String Path
        {
            get
            {
                return this._path;
            }
            set
            {
                this._path = value;
                RaisePropertyChange("Path");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Code"] != null)
                {
                    errors.Add("Code : "+this["Code"]);
                }
                if (this["Libelle"] != null)
                {
                    errors.Add("Libellé : "+this["Libelle"]);
                }
                if (this["Path"] != null)
                {
                    errors.Add("Répertoire : "+this["Path"]);
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
                if (columnName.Equals("Code"))
                {
                    if (String.IsNullOrEmpty(this.Code))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("Libelle"))
                {
                }
                if (columnName.Equals("Path"))
                {
                }
                return null;
            }
        }
    }
}
