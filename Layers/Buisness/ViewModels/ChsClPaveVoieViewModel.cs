using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsClPaveVoieViewModel : ViewModelBase
    {
        public ChsClPaveVoie Model {get; set;}
        public ChsClPaveVoieViewModel(ChsClPaveVoie model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.ChsPaveVoie=new ChsPaveVoieViewModel( this.Model.ChsPaveVoie);
            this.AbsDeb=this.Model.AbsDeb;
            this.AbsFin=this.Model.AbsFin;
        }
        public override void Write()
        {
            this.Model.ChsPaveVoie=this. ChsPaveVoie.Model;
            this.Model.AbsDeb=this.AbsDeb;
            this.Model.AbsFin=this.AbsFin;
        }
        private ChsPaveVoieViewModel _chsPaveVoie;
        [DisplayName("Voies des paves")]
        public virtual ChsPaveVoieViewModel ChsPaveVoie
        {
            get
            {
                return this._chsPaveVoie;
            }
            set
            {
                this._chsPaveVoie = value;
                RaisePropertyChange("ChsPaveVoie");
            }
        }
        
        private Int64 _absDeb;
        [DisplayName("Début pavé voie")]
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
        [DisplayName("Fin pavé voie")]
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
        
    }
}
