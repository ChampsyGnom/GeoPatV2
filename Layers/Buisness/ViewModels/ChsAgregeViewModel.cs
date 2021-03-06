using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsAgregeViewModel : ViewModelBase<ChsAgrege>
    {
        public ChsAgregeViewModel(ChsAgrege model) : base(model)
        {
        }
        public override void Read()
        {
            this.ChsCdAgrege=new ChsCdAgregeViewModel( this.Model.ChsCdAgrege);
            this.ChsDetailCamp=new ChsDetailCampViewModel( this.Model.ChsDetailCamp);
            this.Voie=this.Model.Voie;
            this.AbsDeb=this.Model.AbsDeb;
            this.AbsFin=this.Model.AbsFin;
            this.Moyenne=this.Model.Moyenne;
        }
        public override void Write()
        {
            this.Model.ChsCdAgrege=this. ChsCdAgrege.Model;
            this.Model.ChsDetailCamp=this. ChsDetailCamp.Model;
            this.Model.Voie=this.Voie;
            this.Model.AbsDeb=this.AbsDeb;
            this.Model.AbsFin=this.AbsFin;
            this.Model.Moyenne=this.Moyenne;
        }
        private ChsCdAgregeViewModel _chsCdAgrege;
        [DisplayName("Valeur d'indicateur agrégé")]
        public virtual ChsCdAgregeViewModel ChsCdAgrege
        {
            get
            {
                return this._chsCdAgrege;
            }
            set
            {
                this._chsCdAgrege = value;
                RaisePropertyChange("ChsCdAgrege");
            }
        }
        
        private ChsDetailCampViewModel _chsDetailCamp;
        [DisplayName("Détail des campagnes")]
        public virtual ChsDetailCampViewModel ChsDetailCamp
        {
            get
            {
                return this._chsDetailCamp;
            }
            set
            {
                this._chsDetailCamp = value;
                RaisePropertyChange("ChsDetailCamp");
            }
        }
        
        private String _voie;
        [DisplayName("Voie")]
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
        
        private Nullable<Double> _moyenne;
        [DisplayName("Moyenne")]
        public Nullable<Double> Moyenne
        {
            get
            {
                return this._moyenne;
            }
            set
            {
                this._moyenne = value;
                RaisePropertyChange("Moyenne");
            }
        }
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Voie"] != null)
                {
                    errors.Add("Voie : "+this["Voie"]);
                }
                if (this["AbsDeb"] != null)
                {
                    errors.Add("Début : "+this["AbsDeb"]);
                }
                if (this["AbsFin"] != null)
                {
                    errors.Add("Fin : "+this["AbsFin"]);
                }
                if (this["Moyenne"] != null)
                {
                    errors.Add("Moyenne : "+this["Moyenne"]);
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
                if (columnName.Equals("AbsDeb"))
                {
                }
                if (columnName.Equals("AbsFin"))
                {
                }
                if (columnName.Equals("Moyenne"))
                {
                }
                return null;
            }
        }
    }
}
