using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfPrestataireViewModel : ViewModelBase<InfPrestataire>
    {
        public InfPrestataireViewModel(InfPrestataire model) : base(model)
        {
            this.InfAirePrestataires = new  ObservableCollection<InfAirePrestataireViewModel>();
            
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
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Nom"] != null)
                {
                    errors.Add("Enseigne : "+this["Nom"]);
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
                if (columnName.Equals("Nom"))
                {
                    if (String.IsNullOrEmpty(this.Nom))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
