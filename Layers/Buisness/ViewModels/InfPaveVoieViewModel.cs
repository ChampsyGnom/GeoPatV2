using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfPaveVoieViewModel : ViewModelBase<InfPaveVoie>
    {
        public InfPaveVoieViewModel(InfPaveVoie model) : base(model)
        {
        }
        public override void Read()
        {
            this.InfCdVoie=new InfCdVoieViewModel( this.Model.InfCdVoie);
            this.InfChaussee=new InfChausseeViewModel( this.Model.InfChaussee);
            this.AbsDeb=this.Model.AbsDeb;
            this.AbsFin=this.Model.AbsFin;
            this.Largeur=this.Model.Largeur;
            this.DateMs=this.Model.DateMs;
        }
        public override void Write()
        {
            this.Model.InfCdVoie=this. InfCdVoie.Model;
            this.Model.InfChaussee=this. InfChaussee.Model;
            this.Model.AbsDeb=this.AbsDeb;
            this.Model.AbsFin=this.AbsFin;
            this.Model.Largeur=this.Largeur;
            this.Model.DateMs=this.DateMs;
        }
        private InfCdVoieViewModel _infCdVoie;
        [DisplayName("Code Voie")]
        public virtual InfCdVoieViewModel InfCdVoie
        {
            get
            {
                return this._infCdVoie;
            }
            set
            {
                this._infCdVoie = value;
                RaisePropertyChange("InfCdVoie");
            }
        }
        
        private InfChausseeViewModel _infChaussee;
        [DisplayName("Chaussée")]
        public virtual InfChausseeViewModel InfChaussee
        {
            get
            {
                return this._infChaussee;
            }
            set
            {
                this._infChaussee = value;
                RaisePropertyChange("InfChaussee");
            }
        }
        
        private Int64 _absDeb;
        [DisplayName("Début")]
        public Int64 AbsDeb
        {
            get
            {
                return this._absDeb;
            }
            set
            {
                this._absDeb = value;
                RaisePropertyChange("AbsDeb");
            }
        }
        
        private Int64 _absFin;
        [DisplayName("Fin")]
        public Int64 AbsFin
        {
            get
            {
                return this._absFin;
            }
            set
            {
                this._absFin = value;
                RaisePropertyChange("AbsFin");
            }
        }
        
        private Double _largeur;
        [DisplayName("Largeur (m)")]
        public Double Largeur
        {
            get
            {
                return this._largeur;
            }
            set
            {
                this._largeur = value;
                RaisePropertyChange("Largeur");
            }
        }
        
        private DateTime _dateMs;
        [DisplayName("Date MS")]
        public DateTime DateMs
        {
            get
            {
                return this._dateMs;
            }
            set
            {
                this._dateMs = value;
                RaisePropertyChange("DateMs");
            }
        }
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["AbsDeb"] != null)
                {
                    errors.Add("Début : "+this["AbsDeb"]);
                }
                if (this["AbsFin"] != null)
                {
                    errors.Add("Fin : "+this["AbsFin"]);
                }
                if (this["Largeur"] != null)
                {
                    errors.Add("Largeur (m) : "+this["Largeur"]);
                }
                if (this["DateMs"] != null)
                {
                    errors.Add("Date MS : "+this["DateMs"]);
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
                if (columnName.Equals("AbsDeb"))
                {
                }
                if (columnName.Equals("AbsFin"))
                {
                }
                if (columnName.Equals("Largeur"))
                {
                }
                if (columnName.Equals("DateMs"))
                {
                }
                return null;
            }
        }
    }
}
