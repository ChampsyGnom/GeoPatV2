using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnCdPrestaViewModel : ViewModelBase<BsnCdPresta>
    {
        public BsnCdPrestaViewModel(BsnCdPresta model) : base(model)
        {
            this.BsnCamps = new  ObservableCollection<BsnCampViewModel>();
            
            this.BsnInspecteurs = new  ObservableCollection<BsnInspecteurViewModel>();
            
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
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Prestataire"] != null)
                {
                    errors.Add("Prestataire : "+this["Prestataire"]);
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
                if (columnName.Equals("Prestataire"))
                {
                    if (String.IsNullOrEmpty(this.Prestataire))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
