using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsCdSeuilViewModel : ViewModelBase
    {
        public ChsCdSeuil Model {get; set;}
        public ChsCdSeuilViewModel(ChsCdSeuil model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.ChsCdIndic=new ChsCdIndicViewModel( this.Model.ChsCdIndic);
            this.Seuil1=this.Model.Seuil1;
            this.Seuil2=this.Model.Seuil2;
            this.Seuil3=this.Model.Seuil3;
            this.Seuil4=this.Model.Seuil4;
            this.Interp=this.Model.Interp;
            this.Valabs=this.Model.Valabs;
            this.Zone=this.Model.Zone;
            this.UAlpha=this.Model.UAlpha;
            this.CaractEcart=this.Model.CaractEcart;
        }
        public override void Write()
        {
            this.Model.ChsCdIndic=this. ChsCdIndic.Model;
            this.Model.Seuil1=this.Seuil1;
            this.Model.Seuil2=this.Seuil2;
            this.Model.Seuil3=this.Seuil3;
            this.Model.Seuil4=this.Seuil4;
            this.Model.Interp=this.Interp;
            this.Model.Valabs=this.Valabs;
            this.Model.Zone=this.Zone;
            this.Model.UAlpha=this.UAlpha;
            this.Model.CaractEcart=this.CaractEcart;
        }
        private ChsCdIndicViewModel _chsCdIndic;
        [DisplayName("Indicateurs")]
        public virtual ChsCdIndicViewModel ChsCdIndic
        {
            get
            {
                return this._chsCdIndic;
            }
            set
            {
                this._chsCdIndic = value;
                RaisePropertyChange("ChsCdIndic");
            }
        }
        
        private Double _seuil1;
        [DisplayName("< Seuil 1")]
        public Double Seuil1
        {
            get
            {
                return this._seuil1;
            }
            set
            {
                this._seuil1 = value;
                RaisePropertyChange("Seuil1");
            }
        }
        
        private Nullable<Double> _seuil2;
        [DisplayName("< Seuil 2")]
        public Nullable<Double> Seuil2
        {
            get
            {
                return this._seuil2;
            }
            set
            {
                this._seuil2 = value;
                RaisePropertyChange("Seuil2");
            }
        }
        
        private Nullable<Double> _seuil3;
        [DisplayName("< Seuil 3")]
        public Nullable<Double> Seuil3
        {
            get
            {
                return this._seuil3;
            }
            set
            {
                this._seuil3 = value;
                RaisePropertyChange("Seuil3");
            }
        }
        
        private Nullable<Double> _seuil4;
        [DisplayName(">= Seuil 4")]
        public Nullable<Double> Seuil4
        {
            get
            {
                return this._seuil4;
            }
            set
            {
                this._seuil4 = value;
                RaisePropertyChange("Seuil4");
            }
        }
        
        private String _interp;
        [DisplayName("Sens interprétation")]
        public String Interp
        {
            get
            {
                return this._interp;
            }
            set
            {
                this._interp = value;
                RaisePropertyChange("Interp");
            }
        }
        private Boolean _valabs;
        [DisplayName("Valeur Absolue")]
        public Boolean Valabs
        {
            get
            {
                return this._valabs;
            }
            set
            {
                this._valabs = value;
                RaisePropertyChange("Valabs");
            }
        }
        
        private Nullable<Boolean> _zone;
        [DisplayName("Zone Homogène")]
        public Nullable<Boolean> Zone
        {
            get
            {
                return this._zone;
            }
            set
            {
                this._zone = value;
                RaisePropertyChange("Zone");
            }
        }
        
        private Nullable<Double> _uAlpha;
        [DisplayName("U Alpha")]
        public Nullable<Double> UAlpha
        {
            get
            {
                return this._uAlpha;
            }
            set
            {
                this._uAlpha = value;
                RaisePropertyChange("UAlpha");
            }
        }
        
        private Nullable<Double> _caractEcart;
        [DisplayName("Caractéristique Ecart")]
        public Nullable<Double> CaractEcart
        {
            get
            {
                return this._caractEcart;
            }
            set
            {
                this._caractEcart = value;
                RaisePropertyChange("CaractEcart");
            }
        }
        
    }
}
