using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsClCampViewModel : ViewModelBase
    {
        public ChsClCamp Model {get; set;}
        public ChsClCampViewModel(ChsClCamp model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.ChsDetailCamp=new ChsDetailCampViewModel( this.Model.ChsDetailCamp);
            this.AnneeCalc=this.Model.AnneeCalc;
            this.AbsDeb=this.Model.AbsDeb;
            this.AbsFin=this.Model.AbsFin;
            this.Voie=this.Model.Voie;
        }
        public override void Write()
        {
            this.Model.ChsDetailCamp=this. ChsDetailCamp.Model;
            this.Model.AnneeCalc=this.AnneeCalc;
            this.Model.AbsDeb=this.AbsDeb;
            this.Model.AbsFin=this.AbsFin;
            this.Model.Voie=this.Voie;
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
        
        private Int64 _anneeCalc;
        [DisplayName("Année calculs")]
        public Int64 AnneeCalc
        {
            get
            {
                return this._anneeCalc;
            }
            set
            {
                this._anneeCalc = value;
                RaisePropertyChange("AnneeCalc");
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
    }
}
