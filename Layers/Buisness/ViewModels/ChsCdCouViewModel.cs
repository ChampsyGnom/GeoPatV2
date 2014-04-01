using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsCdCouViewModel : ViewModelBase
    {
        public ChsCdCou Model {get; set;}
        public ChsCdCouViewModel(ChsCdCou model)
        {
            this.ChsPaves = new  ObservableCollection<ChsPaveViewModel>();
            
            this.Model = model;
            this.Read();
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
    }
}
