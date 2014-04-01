using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotCdPrestaViewModel : ViewModelBase
    {
        public GotCdPresta Model {get; set;}
        public GotCdPrestaViewModel(GotCdPresta model)
        {
            this.GotCamps = new  ObservableCollection<GotCampViewModel>();
            
            this.GotInspecteurs = new  ObservableCollection<GotInspecteurViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.Prestataire=this.Model.Prestataire;
        }
        public override void Write()
        {
            this.Model.Prestataire=this.Prestataire;
        }
        public virtual ObservableCollection<GotCampViewModel> GotCamps { get; set; }
        
        public virtual ObservableCollection<GotInspecteurViewModel> GotInspecteurs { get; set; }
        
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
