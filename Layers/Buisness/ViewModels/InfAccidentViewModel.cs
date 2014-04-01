using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfAccidentViewModel : ViewModelBase
    {
        public InfAccident Model {get; set;}
        public InfAccidentViewModel(InfAccident model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.InfChaussee=new InfChausseeViewModel( this.Model.InfChaussee);
            this.Annee=this.Model.Annee;
            this.AbsDeb=this.Model.AbsDeb;
            this.Mois=this.Model.Mois;
            this.AbsFin=this.Model.AbsFin;
            this.NbrAcc=this.Model.NbrAcc;
            this.NbrAccMois=this.Model.NbrAccMois;
        }
        public override void Write()
        {
            this.Model.InfChaussee=this. InfChaussee.Model;
            this.Model.Annee=this.Annee;
            this.Model.AbsDeb=this.AbsDeb;
            this.Model.Mois=this.Mois;
            this.Model.AbsFin=this.AbsFin;
            this.Model.NbrAcc=this.NbrAcc;
            this.Model.NbrAccMois=this.NbrAccMois;
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
        
        private Int64 _annee;
        [DisplayName("Année")]
        public Int64 Annee
        {
            get
            {
                return this._annee;
            }
            set
            {
                this._annee = value;
                RaisePropertyChange("Annee");
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
        
        private Int64 _mois;
        [DisplayName("Mois")]
        public Int64 Mois
        {
            get
            {
                return this._mois;
            }
            set
            {
                this._mois = value;
                RaisePropertyChange("Mois");
            }
        }
        
        private Nullable<Int64> _absFin;
        [DisplayName("Fin")]
        public Nullable<Int64> AbsFin
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
        
        private Nullable<Int64> _nbrAcc;
        [DisplayName("Nbre Accidents")]
        public Nullable<Int64> NbrAcc
        {
            get
            {
                return this._nbrAcc;
            }
            set
            {
                this._nbrAcc = value;
                RaisePropertyChange("NbrAcc");
            }
        }
        
        private Nullable<Int64> _nbrAccMois;
        [DisplayName("AM")]
        public Nullable<Int64> NbrAccMois
        {
            get
            {
                return this._nbrAccMois;
            }
            set
            {
                this._nbrAccMois = value;
                RaisePropertyChange("NbrAccMois");
            }
        }
        
    }
}
