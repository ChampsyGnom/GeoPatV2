using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfPrestataireViewModel : ViewModelBase
    {
        public InfPrestataire Model {get; set;}
        public InfPrestataireViewModel(InfPrestataire model)
        {
            this.InfAirePrestataires = new  ObservableCollection<InfAirePrestataireViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.InfCdPrestataire=new InfCdPrestataireViewModel( this.Model.InfCdPrestataire);
            this.Nom=this.Model.Nom;
        }
        public override void Write()
        {
            this.Model.InfCdPrestataire=this. InfCdPrestataire.Model;
            this.Model.Nom=this.Nom;
        }
        private InfCdPrestataireViewModel _infCdPrestataire;
        [DisplayName("Type Prestataire")]
        public virtual InfCdPrestataireViewModel InfCdPrestataire
        {
            get
            {
                return this._infCdPrestataire;
            }
            set
            {
                this._infCdPrestataire = value;
                RaisePropertyChange("InfCdPrestataire");
            }
        }
        
        public virtual ObservableCollection<InfAirePrestataireViewModel> InfAirePrestataires { get; set; }
        
        private String _nom;
        [DisplayName("Enseigne")]
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
