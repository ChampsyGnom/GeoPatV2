using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class PrfBmParamViewModel : ViewModelBase
    {
        public PrfBmParam Model {get; set;}
        public PrfBmParamViewModel(PrfBmParam model)
        {
            this.Model = model;
            this.Read();
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
    }
}
