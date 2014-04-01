using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsCdFamCarViewModel : ViewModelBase<ChsCdFamCar>
    {
        public ChsCdFamCarViewModel(ChsCdFamCar model) : base(model)
        {
            this.ChsFamCars = new  ObservableCollection<ChsFamCarViewModel>();
            
        }
        public override void Read()
        {
            this.Famille=this.Model.Famille;
            this.Libelle=this.Model.Libelle;
            this.Cam=this.Model.Cam;
        }
        public override void Write()
        {
            this.Model.Famille=this.Famille;
            this.Model.Libelle=this.Libelle;
            this.Model.Cam=this.Cam;
        }
        public virtual ObservableCollection<ChsFamCarViewModel> ChsFamCars { get; set; }
        
        private String _famille;
        [DisplayName("Famille")]
        public String Famille
        {
            get
            {
                return this._famille;
            }
            set
            {
                this._famille = value;
                RaisePropertyChange("Famille");
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
        private Double _cam;
        [DisplayName("Coefficient Agressivité Moyen")]
        public Double Cam
        {
            get
            {
                return this._cam;
            }
            set
            {
                this._cam = value;
                RaisePropertyChange("Cam");
            }
        }
        
    }
}
