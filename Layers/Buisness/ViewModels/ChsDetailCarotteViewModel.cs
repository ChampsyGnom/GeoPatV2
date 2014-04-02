using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsDetailCarotteViewModel : ViewModelBase<ChsDetailCarotte>
    {
        public ChsDetailCarotteViewModel(ChsDetailCarotte model) : base(model)
        {
        }
        public override void Read()
        {
            this.ChsClCarotte=new ChsClCarotteViewModel( this.Model.ChsClCarotte);
            this.DateMs=this.Model.DateMs;
            this.Posit=this.Model.Posit;
            this.Numordre=this.Model.Numordre;
            this.AbsFin=this.Model.AbsFin;
            this.Couche=this.Model.Couche;
            this.Technique=this.Model.Technique;
            this.Epais=this.Model.Epais;
            this.Granulo=this.Model.Granulo;
            this.TypeSc=this.Model.TypeSc;
            this.EpaisSc=this.Model.EpaisSc;
            this.DureeServ=this.Model.DureeServ;
        }
        public override void Write()
        {
            this.Model.ChsClCarotte=this. ChsClCarotte.Model;
            this.Model.DateMs=this.DateMs;
            this.Model.Posit=this.Posit;
            this.Model.Numordre=this.Numordre;
            this.Model.AbsFin=this.AbsFin;
            this.Model.Couche=this.Couche;
            this.Model.Technique=this.Technique;
            this.Model.Epais=this.Epais;
            this.Model.Granulo=this.Granulo;
            this.Model.TypeSc=this.TypeSc;
            this.Model.EpaisSc=this.EpaisSc;
            this.Model.DureeServ=this.DureeServ;
        }
        private ChsClCarotteViewModel _chsClCarotte;
        [DisplayName("Carotte calculée")]
        public virtual ChsClCarotteViewModel ChsClCarotte
        {
            get
            {
                return this._chsClCarotte;
            }
            set
            {
                this._chsClCarotte = value;
                RaisePropertyChange("ChsClCarotte");
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
        
        private Int64 _numordre;
        [DisplayName("No Ordre sous couche")]
        public Int64 Numordre
        {
            get
            {
                return this._numordre;
            }
            set
            {
                this._numordre = value;
                RaisePropertyChange("Numordre");
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
        
        private String _couche;
        [DisplayName("Couche")]
        public String Couche
        {
            get
            {
                return this._couche;
            }
            set
            {
                this._couche = value;
                RaisePropertyChange("Couche");
            }
        }
        private String _technique;
        [DisplayName("Technique")]
        public String Technique
        {
            get
            {
                return this._technique;
            }
            set
            {
                this._technique = value;
                RaisePropertyChange("Technique");
            }
        }
        private Nullable<Double> _epais;
        [DisplayName("Epaisseur (cm)")]
        public Nullable<Double> Epais
        {
            get
            {
                return this._epais;
            }
            set
            {
                this._epais = value;
                RaisePropertyChange("Epais");
            }
        }
        
        private String _granulo;
        [DisplayName("Granulométrie")]
        public String Granulo
        {
            get
            {
                return this._granulo;
            }
            set
            {
                this._granulo = value;
                RaisePropertyChange("Granulo");
            }
        }
        private String _typeSc;
        [DisplayName("Sous-couche")]
        public String TypeSc
        {
            get
            {
                return this._typeSc;
            }
            set
            {
                this._typeSc = value;
                RaisePropertyChange("TypeSc");
            }
        }
        private Nullable<Double> _epaisSc;
        [DisplayName("Epais SC")]
        public Nullable<Double> EpaisSc
        {
            get
            {
                return this._epaisSc;
            }
            set
            {
                this._epaisSc = value;
                RaisePropertyChange("EpaisSc");
            }
        }
        
        private Nullable<Double> _dureeServ;
        [DisplayName("Durée de service")]
        public Nullable<Double> DureeServ
        {
            get
            {
                return this._dureeServ;
            }
            set
            {
                this._dureeServ = value;
                RaisePropertyChange("DureeServ");
            }
        }
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["DateMs"] != null)
                {
                    errors.Add("Date MS : "+this["DateMs"]);
                }
                if (this["Posit"] != null)
                {
                    errors.Add("Position : "+this["Posit"]);
                }
                if (this["Numordre"] != null)
                {
                    errors.Add("No Ordre sous couche : "+this["Numordre"]);
                }
                if (this["AbsFin"] != null)
                {
                    errors.Add("Fin : "+this["AbsFin"]);
                }
                if (this["Couche"] != null)
                {
                    errors.Add("Couche : "+this["Couche"]);
                }
                if (this["Technique"] != null)
                {
                    errors.Add("Technique : "+this["Technique"]);
                }
                if (this["Epais"] != null)
                {
                    errors.Add("Epaisseur (cm) : "+this["Epais"]);
                }
                if (this["Granulo"] != null)
                {
                    errors.Add("Granulométrie : "+this["Granulo"]);
                }
                if (this["TypeSc"] != null)
                {
                    errors.Add("Sous-couche : "+this["TypeSc"]);
                }
                if (this["EpaisSc"] != null)
                {
                    errors.Add("Epais SC : "+this["EpaisSc"]);
                }
                if (this["DureeServ"] != null)
                {
                    errors.Add("Durée de service : "+this["DureeServ"]);
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
                if (columnName.Equals("DateMs"))
                {
                }
                if (columnName.Equals("Posit"))
                {
                }
                if (columnName.Equals("Numordre"))
                {
                }
                if (columnName.Equals("AbsFin"))
                {
                }
                if (columnName.Equals("Couche"))
                {
                    if (String.IsNullOrEmpty(this.Couche))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("Technique"))
                {
                }
                if (columnName.Equals("Epais"))
                {
                }
                if (columnName.Equals("Granulo"))
                {
                }
                if (columnName.Equals("TypeSc"))
                {
                }
                if (columnName.Equals("EpaisSc"))
                {
                }
                if (columnName.Equals("DureeServ"))
                {
                }
                return null;
            }
        }
    }
}
