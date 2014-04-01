using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfAirePlaceViewModel : ViewModelBase
    {
        public InfAirePlace Model {get; set;}
        public InfAirePlaceViewModel(InfAirePlace model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.InfCdPlace=new InfCdPlaceViewModel( this.Model.InfCdPlace);
            this.InfAire=new InfAireViewModel( this.Model.InfAire);
            this.Nbre=this.Model.Nbre;
        }
        public override void Write()
        {
            this.Model.InfCdPlace=this. InfCdPlace.Model;
            this.Model.InfAire=this. InfAire.Model;
            this.Model.Nbre=this.Nbre;
        }
        private InfCdPlaceViewModel _infCdPlace;
        [DisplayName("Type parking")]
        public virtual InfCdPlaceViewModel InfCdPlace
        {
            get
            {
                return this._infCdPlace;
            }
            set
            {
                this._infCdPlace = value;
                RaisePropertyChange("InfCdPlace");
            }
        }
        
        private InfAireViewModel _infAire;
        [DisplayName("Aires")]
        public virtual InfAireViewModel InfAire
        {
            get
            {
                return this._infAire;
            }
            set
            {
                this._infAire = value;
                RaisePropertyChange("InfAire");
            }
        }
        
        private Nullable<Int64> _nbre;
        [DisplayName("Nbre de place")]
        public Nullable<Int64> Nbre
        {
            get
            {
                return this._nbre;
            }
            set
            {
                this._nbre = value;
                RaisePropertyChange("Nbre");
            }
        }
        
    }
}
