using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfCdPlaceViewModel : ViewModelBase
    {
        public InfCdPlace Model {get; set;}
        public InfCdPlaceViewModel(InfCdPlace model)
        {
            this.InfAirePlaces = new  ObservableCollection<InfAirePlaceViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.Parking=this.Model.Parking;
        }
        public override void Write()
        {
            this.Model.Parking=this.Parking;
        }
        public virtual ObservableCollection<InfAirePlaceViewModel> InfAirePlaces { get; set; }
        
        private String _parking;
        [DisplayName("Type Parking")]
        public String Parking
        {
            get
            {
                return this._parking;
            }
            set
            {
                this._parking = value;
                RaisePropertyChange("Parking");
            }
        }
    }
}
