using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsCdCouViewModel : ViewModelBase<ChsCdCou>
    {
        public ChsCdCouViewModel(ChsCdCou model) : base(model)
        {
            this.ChsPaves = new  ObservableCollection<ChsPaveViewModel>();
            
        }
        public override void Read()
        {
            this.Couche=this.Model.Couche;
            this.Posit=this.Model.Posit;
            this.Couleur=this.Model.Couleur;
        }
        public override void Write()
        {
            this.Model.Couche=this.Couche;
            this.Model.Posit=this.Posit;
            this.Model.Couleur=this.Couleur;
        }
        public virtual ObservableCollection<ChsPaveViewModel> ChsPaves { get; set; }
        
        private String _couche;
        [DisplayName("Couche")]
        public String Couche
        {
            get
            {
                return this._couche;
            }
            set
            {
                this._couche = value;
                RaisePropertyChange("Couche");
            }
        }
        private Int64 _posit;
        [DisplayName("Position")]
        public Int64 Posit
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
                if (this["Couche"] != null)
                {
                    errors.Add("Couche : "+this["Couche"]);
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
                if (columnName.Equals("Couche"))
                {
                    if (String.IsNullOrEmpty(this.Couche))
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
