using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsDetailCarotteViewModel : ViewModelBase
    {
        public ChsDetailCarotte Model {get; set;}
        public ChsDetailCarotteViewModel(ChsDetailCarotte model)
        {
            this.Model = model;
            this.Read();
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
        
    }
}
