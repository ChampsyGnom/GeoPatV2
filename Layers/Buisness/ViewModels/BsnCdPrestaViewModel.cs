using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnCdPrestaViewModel : ViewModelBase
    {
        public BsnCdPresta Model {get; set;}
        public BsnCdPrestaViewModel(BsnCdPresta model)
        {
            this.BsnCamps = new  ObservableCollection<BsnCampViewModel>();
            
            this.BsnInspecteurs = new  ObservableCollection<BsnInspecteurViewModel>();
            
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
        public virtual ObservableCollection<BsnCampViewModel> BsnCamps { get; set; }
        
        public virtual ObservableCollection<BsnInspecteurViewModel> BsnInspecteurs { get; set; }
        
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
