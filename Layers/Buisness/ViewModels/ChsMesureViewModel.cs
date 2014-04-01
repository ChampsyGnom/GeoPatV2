using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsMesureViewModel : ViewModelBase<ChsMesure>
    {
        public ChsMesureViewModel(ChsMesure model) : base(model)
        {
        }
        public override void Read()
        {
            this.ChsDetailCamp=new ChsDetailCampViewModel( this.Model.ChsDetailCamp);
            this.Voie=this.Model.Voie;
            this.AbsDeb=this.Model.AbsDeb;
            this.AbsFin=this.Model.AbsFin;
            this.Valeur=this.Model.Valeur;
        }
        public override void Write()
        {
            this.Model.ChsDetailCamp=this. ChsDetailCamp.Model;
            this.Model.Voie=this.Voie;
            this.Model.AbsDeb=this.AbsDeb;
            this.Model.AbsFin=this.AbsFin;
            this.Model.Valeur=this.Valeur;
        }
        private ChsDetailCampViewModel _chsDetailCamp;
        [DisplayName("Détail des campagnes")]
        public virtual ChsDetailCampViewModel ChsDetailCamp
        {
            get
            {
                return this._chsDetailCamp;
            }
            set
            {
                this._chsDetailCamp = value;
                RaisePropertyChange("ChsDetailCamp");
            }
        }
        
        private String _voie;
        [DisplayName("Voie")]
        public String Voie
        {
            get
            {
                return this._voie;
            }
            set
            {
                this._voie = value;
                RaisePropertyChange("Voie");
            }
        }
        private Int64 _absDeb;
        [DisplayName("Début")]
        public Int64 AbsDeb
        {
            get
            {
                return this._absDeb;
            }
            set
            {
                this._absDeb = value;
                RaisePropertyChange("AbsDeb");
            }
        }
        
        private Int64 _absFin;
        [DisplayName("Fin")]
        public Int64 AbsFin
        {
            get
            {
                return this._absFin;
            }
            set
            {
                this._absFin = value;
                RaisePropertyChange("AbsFin");
            }
        }
        
        private Nullable<Double> _valeur;
        [DisplayName("Valeur")]
        public Nullable<Double> Valeur
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
