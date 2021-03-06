using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfCdDocViewModel : ViewModelBase<InfCdDoc>
    {
        public InfCdDocViewModel(InfCdDoc model) : base(model)
        {
            this.InfDocs = new  ObservableCollection<InfDocViewModel>();
            
        }
        public override void Read()
        {
            this.Code=this.Model.Code;
            this.Path=this.Model.Path;
            this.Libelle=this.Model.Libelle;
        }
        public override void Write()
        {
            this.Model.Code=this.Code;
            this.Model.Path=this.Path;
            this.Model.Libelle=this.Libelle;
        }
        public virtual ObservableCollection<InfDocViewModel> InfDocs { get; set; }
        
        private String _code;
        [DisplayName("Code document")]
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
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Code"] != null)
                {
                    errors.Add("Code document : "+this["Code"]);
                }
                if (this["Path"] != null)
                {
                    errors.Add("Répertoire : "+this["Path"]);
                }
                if (this["Libelle"] != null)
                {
                    errors.Add("Libellé : "+this["Libelle"]);
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
                if (columnName.Equals("Path"))
                {
                    if (String.IsNullOrEmpty(this.Path))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("Libelle"))
                {
                    if (String.IsNullOrEmpty(this.Libelle))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
