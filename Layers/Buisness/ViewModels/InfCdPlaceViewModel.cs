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
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Parking"] != null)
                {
                    errors.Add("Type Parking : "+this["Parking"]);
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
                if (columnName.Equals("Parking"))
                {
                    if (String.IsNullOrEmpty(this.Parking))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
