using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class PrfBmParamViewModel : ViewModelBase<PrfBmParam>
    {
        public PrfBmParamViewModel(PrfBmParam model) : base(model)
        {
        }
        public override void Read()
        {
            this.Code=this.Model.Code;
            this.Valeur=this.Model.Valeur;
        }
        public override void Write()
        {
            this.Model.Code=this.Code;
            this.Model.Valeur=this.Valeur;
        }
        private String _code;
        [DisplayName("CODE")]
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
                if (this["Code"] != null)
                {
                    errors.Add("CODE : "+this["Code"]);
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
                if (columnName.Equals("Code"))
                {
                    if (String.IsNullOrEmpty(this.Code))
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
