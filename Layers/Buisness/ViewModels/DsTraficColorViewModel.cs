using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class DsTraficColorViewModel : ViewModelBase<DsTraficColor>
    {
        public DsTraficColorViewModel(DsTraficColor model) : base(model)
        {
        }
        public override void Read()
        {
            this.Code=this.Model.Code;
            this.Color=this.Model.Color;
        }
        public override void Write()
        {
            this.Model.Code=this.Code;
            this.Model.Color=this.Color;
        }
        private String _code;
        [DisplayName("TRAFIC_COLOR_DS__CODE")]
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
        private String _color;
        [DisplayName("TRAFIC_COLOR_DS__COLOR")]
        public String Color
        {
            get
            {
                return this._color;
            }
            set
            {
                this._color = value;
                RaisePropertyChange("Color");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Code"] != null)
                {
                    errors.Add("TRAFIC_COLOR_DS__CODE : "+this["Code"]);
                }
                if (this["Color"] != null)
                {
                    errors.Add("TRAFIC_COLOR_DS__COLOR : "+this["Color"]);
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
                if (columnName.Equals("Color"))
                {
                }
                return null;
            }
        }
    }
}
