using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaCdOccupantViewModel : ViewModelBase<OaCdOccupant>
    {
        public OaCdOccupantViewModel(OaCdOccupant model) : base(model)
        {
            this.OaOccupations = new  ObservableCollection<OaOccupationViewModel>();
            
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
