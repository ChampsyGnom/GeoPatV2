using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfCdOccupantViewModel : ViewModelBase
    {
        public InfCdOccupant Model {get; set;}
        public InfCdOccupantViewModel(InfCdOccupant model)
        {
            this.InfOccupations = new  ObservableCollection<InfOccupationViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.Nom=this.Model.Nom;
        }
        public override void Write()
        {
            this.Model.Nom=this.Nom;
        }
        public virtual ObservableCollection<InfOccupationViewModel> InfOccupations { get; set; }
        
        private String _nom;
        [DisplayName("Nom")]
        public String Nom
        {
            get
            {
                return this._nom;
            }
            set
            {
                this._nom = value;
                RaisePropertyChange("Nom");
            }
        }
    }
}
