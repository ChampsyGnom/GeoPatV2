using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhCdPrestaViewModel : ViewModelBase<OhCdPresta>
    {
        public OhCdPrestaViewModel(OhCdPresta model) : base(model)
        {
            this.OhCamps = new  ObservableCollection<OhCampViewModel>();
            
            this.OhInspecteurs = new  ObservableCollection<OhInspecteurViewModel>();
            
        }
        public override void Read()
        {
            this.Prestataire=this.Model.Prestataire;
        }
        public override void Write()
        {
            this.Model.Prestataire=this.Prestataire;
        }
        public virtual ObservableCollection<OhCampViewModel> OhCamps { get; set; }
        
        public virtual ObservableCollection<OhInspecteurViewModel> OhInspecteurs { get; set; }
        
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
