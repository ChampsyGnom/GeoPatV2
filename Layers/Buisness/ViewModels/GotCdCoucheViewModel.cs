using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotCdCoucheViewModel : ViewModelBase<GotCdCouche>
    {
        public GotCdCoucheViewModel(GotCdCouche model) : base(model)
        {
            this.GotCouches = new  ObservableCollection<GotCoucheViewModel>();
            
        }
        public override void Read()
        {
            this.Code=this.Model.Code;
            this.Posit=this.Model.Posit;
            this.Couleur=this.Model.Couleur;
        }
        public override void Write()
        {
            this.Model.Code=this.Code;
            this.Model.Posit=this.Posit;
            this.Model.Couleur=this.Couleur;
        }
        public virtual ObservableCollection<GotCoucheViewModel> GotCouches { get; set; }
        
        private String _code;
        [DisplayName("Code couche")]
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
        private Nullable<Int64> _posit;
        [DisplayName("Position")]
        public Nullable<Int64> Posit
        {
            get
            {
                return this._posit;
            }
            set
            {
                this._posit = value;
                RaisePropertyChange("Posit");
            }
        }
        
        private String _couleur;
        [DisplayName("Couleur")]
        public String Couleur
        {
            get
            {
                return this._couleur;
            }
            set
            {
                this._couleur = value;
                RaisePropertyChange("Couleur");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Code"] != null)
                {
                    errors.Add("Code couche : "+this["Code"]);
                }
                if (this["Posit"] != null)
                {
                    errors.Add("Position : "+this["Posit"]);
                }
                if (this["Couleur"] != null)
                {
                    errors.Add("Couleur : "+this["Couleur"]);
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
                if (columnName.Equals("Posit"))
                {
                }
                if (columnName.Equals("Couleur"))
                {
                }
                return null;
            }
        }
    }
}
