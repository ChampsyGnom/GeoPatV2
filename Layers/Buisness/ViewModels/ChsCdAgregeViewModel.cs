using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsCdAgregeViewModel : ViewModelBase<ChsCdAgrege>
    {
        public ChsCdAgregeViewModel(ChsCdAgrege model) : base(model)
        {
            this.ChsAgreges = new  ObservableCollection<ChsAgregeViewModel>();
            
        }
        public override void Read()
        {
            this.Valeur=this.Model.Valeur;
            this.Libelle=this.Model.Libelle;
            this.Couleur=this.Model.Couleur;
        }
        public override void Write()
        {
            this.Model.Valeur=this.Valeur;
            this.Model.Libelle=this.Libelle;
            this.Model.Couleur=this.Couleur;
        }
        public virtual ObservableCollection<ChsAgregeViewModel> ChsAgreges { get; set; }
        
        private Int64 _valeur;
        [DisplayName("Valeur")]
        public Int64 Valeur
        {
            get
            {
                return this._valeur;
            }
            set
            {
                this._valeur = value;
                RaisePropertyChange("Valeur");
            }
        }
        
        private String _libelle;
        [DisplayName("Libellé")]
        public String Libelle
        {
            get
            {
                return this._libelle;
            }
            set
            {
                this._libelle = value;
                RaisePropertyChange("Libelle");
            }
        }
        private String _couleur;
        [DisplayName("Couleur")]
        public String Couleur
        {
            get
            {
                return this._couleur;
            }
            set
            {
                this._couleur = value;
                RaisePropertyChange("Couleur");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Valeur"] != null)
                {
                    errors.Add("Valeur : "+this["Valeur"]);
                }
                if (this["Libelle"] != null)
                {
                    errors.Add("Libellé : "+this["Libelle"]);
                }
                if (this["Couleur"] != null)
                {
                    errors.Add("Couleur : "+this["Couleur"]);
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
                if (columnName.Equals("Valeur"))
                {
                }
                if (columnName.Equals("Libelle"))
                {
                }
                if (columnName.Equals("Couleur"))
                {
                }
                return null;
            }
        }
    }
}
