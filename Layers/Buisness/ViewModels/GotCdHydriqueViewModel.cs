using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotCdHydriqueViewModel : ViewModelBase<GotCdHydrique>
    {
        public GotCdHydriqueViewModel(GotCdHydrique model) : base(model)
        {
            this.GotCouches = new  ObservableCollection<GotCoucheViewModel>();
            
        }
        public override void Read()
        {
            this.Etat=this.Model.Etat;
        }
        public override void Write()
        {
            this.Model.Etat=this.Etat;
        }
        public virtual ObservableCollection<GotCoucheViewModel> GotCouches { get; set; }
        
        private String _etat;
        [DisplayName("Etat hydrique")]
        public String Etat
        {
            get
            {
                return this._etat;
            }
            set
            {
                this._etat = value;
                RaisePropertyChange("Etat");
            }
        }
    }
}
