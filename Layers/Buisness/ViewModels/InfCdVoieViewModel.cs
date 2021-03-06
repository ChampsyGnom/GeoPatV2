using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfCdVoieViewModel : ViewModelBase<InfCdVoie>
    {
        public InfCdVoieViewModel(InfCdVoie model) : base(model)
        {
            this.InfPaveVoies = new  ObservableCollection<InfPaveVoieViewModel>();
            
            this.InfClVoies = new  ObservableCollection<InfClVoieViewModel>();
            
        }
        public override void Read()
        {
            this.Voie=this.Model.Voie;
            this.Posit=this.Model.Posit;
            this.Libelle=this.Model.Libelle;
            this.Roulable=this.Model.Roulable;
        }
        public override void Write()
        {
            this.Model.Voie=this.Voie;
            this.Model.Posit=this.Posit;
            this.Model.Libelle=this.Libelle;
            this.Model.Roulable=this.Roulable;
        }
        public virtual ObservableCollection<InfPaveVoieViewModel> InfPaveVoies { get; set; }
        
        public virtual ObservableCollection<InfClVoieViewModel> InfClVoies { get; set; }
        
        private String _voie;
        [DisplayName("Type Voie")]
        public String Voie
        {
            get
            {
                return this._voie;
            }
            set
            {
                this._voie = value;
                RaisePropertyChange("Voie");
            }
        }
        private Int64 _posit;
        [DisplayName("Position")]
        public Int64 Posit
        {
            get
            {
                return this._posit;
            }
            set
            {
                this._posit = value;
                RaisePropertyChange("Posit");
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
        private Nullable<Boolean> _roulable;
        [DisplayName("Roulable")]
        public Nullable<Boolean> Roulable
        {
            get
            {
                return this._roulable;
            }
            set
            {
                this._roulable = value;
                RaisePropertyChange("Roulable");
            }
        }
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Voie"] != null)
                {
                    errors.Add("Type Voie : "+this["Voie"]);
                }
                if (this["Posit"] != null)
                {
                    errors.Add("Position : "+this["Posit"]);
                }
                if (this["Libelle"] != null)
                {
                    errors.Add("Libellé : "+this["Libelle"]);
                }
                if (this["Roulable"] != null)
                {
                    errors.Add("Roulable : "+this["Roulable"]);
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
                if (columnName.Equals("Voie"))
                {
                    if (String.IsNullOrEmpty(this.Voie))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("Posit"))
                {
                }
                if (columnName.Equals("Libelle"))
                {
                }
                if (columnName.Equals("Roulable"))
                {
                }
                return null;
            }
        }
    }
}
