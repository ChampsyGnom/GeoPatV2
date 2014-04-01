using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfCdVoieViewModel : ViewModelBase<InfCdVoie>
    {
        public InfCdVoieViewModel(InfCdVoie model) : base(model)
        {
            this.InfPaveVoies = new  ObservableCollection<InfPaveVoieViewModel>();
            
            this.InfClVoies = new  ObservableCollection<InfClVoieViewModel>();
            
        }
        public override void Read()
        {
            this.Voie=this.Model.Voie;
            this.Posit=this.Model.Posit;
            this.Libelle=this.Model.Libelle;
            this.Roulable=this.Model.Roulable;
        }
        public override void Write()
        {
            this.Model.Voie=this.Voie;
            this.Model.Posit=this.Posit;
            this.Model.Libelle=this.Libelle;
            this.Model.Roulable=this.Roulable;
        }
        public virtual ObservableCollection<InfPaveVoieViewModel> InfPaveVoies { get; set; }
        
        public virtual ObservableCollection<InfClVoieViewModel> InfClVoies { get; set; }
        
        private String _voie;
        [DisplayName("Type Voie")]
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
        private Nullable<Boolean> _roulable;
        [DisplayName("Roulable")]
        public Nullable<Boolean> Roulable
        {
            get
            {
                return this._roulable;
            }
            set
            {
                this._roulable = value;
                RaisePropertyChange("Roulable");
            }
        }
        
    }
}
