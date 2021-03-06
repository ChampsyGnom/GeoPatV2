using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsParamsisViewModel : ViewModelBase<ChsParamsis>
    {
        public ChsParamsisViewModel(ChsParamsis model) : base(model)
        {
        }
        public override void Read()
        {
            this.Entree=this.Model.Entree;
            this.Parametre=this.Model.Parametre;
            this.Type=this.Model.Type;
            this.Valeur=this.Model.Valeur;
        }
        public override void Write()
        {
            this.Model.Entree=this.Entree;
            this.Model.Parametre=this.Parametre;
            this.Model.Type=this.Type;
            this.Model.Valeur=this.Valeur;
        }
        private String _entree;
        [DisplayName("ENTREE")]
        public String Entree
        {
            get
            {
                return this._entree;
            }
            set
            {
                this._entree = value;
                RaisePropertyChange("Entree");
            }
        }
        private String _parametre;
        [DisplayName("PARAMETRE")]
        public String Parametre
        {
            get
            {
                return this._parametre;
            }
            set
            {
                this._parametre = value;
                RaisePropertyChange("Parametre");
            }
        }
        private String _type;
        [DisplayName("TYPE")]
        public String Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
                RaisePropertyChange("Type");
            }
        }
        private String _valeur;
        [DisplayName("VALEUR")]
        public String Valeur
        {
            get
            {
                return this._valeur;
            }
            set
            {
                this._valeur = value;
                RaisePropertyChange("Valeur");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Entree"] != null)
                {
                    errors.Add("ENTREE : "+this["Entree"]);
                }
                if (this["Parametre"] != null)
                {
                    errors.Add("PARAMETRE : "+this["Parametre"]);
                }
                if (this["Type"] != null)
                {
                    errors.Add("TYPE : "+this["Type"]);
                }
                if (this["Valeur"] != null)
                {
                    errors.Add("VALEUR : "+this["Valeur"]);
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
                if (columnName.Equals("Entree"))
                {
                    if (String.IsNullOrEmpty(this.Entree))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("Parametre"))
                {
                    if (String.IsNullOrEmpty(this.Parametre))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("Type"))
                {
                    if (String.IsNullOrEmpty(this.Type))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("Valeur"))
                {
                }
                return null;
            }
        }
    }
}
