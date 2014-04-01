using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfCdPlaceViewModel : ViewModelBase<InfCdPlace>
    {
        public InfCdPlaceViewModel(InfCdPlace model) : base(model)
        {
            this.InfAirePlaces = new  ObservableCollection<InfAirePlaceViewModel>();
            
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
