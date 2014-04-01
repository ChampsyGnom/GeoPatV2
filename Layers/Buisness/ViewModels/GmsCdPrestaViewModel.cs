using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GmsCdPrestaViewModel : ViewModelBase<GmsCdPresta>
    {
        public GmsCdPrestaViewModel(GmsCdPresta model) : base(model)
        {
            this.GmsCamps = new  ObservableCollection<GmsCampViewModel>();
            
            this.GmsInspecteurs = new  ObservableCollection<GmsInspecteurViewModel>();
            
        }
        public override void Read()
        {
            this.Prestataire=this.Model.Prestataire;
        }
        public override void Write()
        {
            this.Model.Prestataire=this.Prestataire;
        }
        public virtual ObservableCollection<GmsCampViewModel> GmsCamps { get; set; }
        
        public virtual ObservableCollection<GmsInspecteurViewModel> GmsInspecteurs { get; set; }
        
        private String _prestataire;
        [DisplayName("Prestataire")]
        public String Prestataire
        {
            get
            {
                return this._prestataire;
            }
            set
            {
                this._prestataire = value;
                RaisePropertyChange("Prestataire");
            }
        }
    }
}
