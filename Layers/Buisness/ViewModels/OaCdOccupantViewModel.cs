using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaCdOccupantViewModel : ViewModelBase
    {
        public OaCdOccupant Model {get; set;}
        public OaCdOccupantViewModel(OaCdOccupant model)
        {
            this.OaOccupations = new  ObservableCollection<OaOccupationViewModel>();
            
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
        public virtual ObservableCollection<OaOccupationViewModel> OaOccupations { get; set; }
        
        private String _nom;
        [DisplayName("Nom occupant")]
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
