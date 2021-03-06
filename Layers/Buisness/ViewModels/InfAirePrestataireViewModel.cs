using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfAirePrestataireViewModel : ViewModelBase<InfAirePrestataire>
    {
        public InfAirePrestataireViewModel(InfAirePrestataire model) : base(model)
        {
        }
        public override void Read()
        {
            this.InfAire=new InfAireViewModel( this.Model.InfAire);
            this.InfPrestataire=new InfPrestataireViewModel( this.Model.InfPrestataire);
        }
        public override void Write()
        {
            this.Model.InfAire=this. InfAire.Model;
            this.Model.InfPrestataire=this. InfPrestataire.Model;
        }
        private InfAireViewModel _infAire;
        [DisplayName("Aires")]
        public virtual InfAireViewModel InfAire
        {
            get
            {
                return this._infAire;
            }
            set
            {
                this._infAire = value;
                RaisePropertyChange("InfAire");
            }
        }
        
        private InfPrestataireViewModel _infPrestataire;
        [DisplayName("Prestataire")]
        public virtual InfPrestataireViewModel InfPrestataire
        {
            get
            {
                return this._infPrestataire;
            }
            set
            {
                this._infPrestataire = value;
                RaisePropertyChange("InfPrestataire");
            }
        }
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
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
                return null;
            }
        }
    }
}
