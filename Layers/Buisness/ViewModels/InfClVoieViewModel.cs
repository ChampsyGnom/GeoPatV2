using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfClVoieViewModel : ViewModelBase
    {
        public InfClVoie Model {get; set;}
        public InfClVoieViewModel(InfClVoie model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.InfCdVoie=new InfCdVoieViewModel( this.Model.InfCdVoie);
            this.InfChaussee=new InfChausseeViewModel( this.Model.InfChaussee);
            this.AbsDeb=this.Model.AbsDeb;
            this.NumVnr=this.Model.NumVnr;
            this.AbsFin=this.Model.AbsFin;
            this.Num=this.Model.Num;
            this.Nbre=this.Model.Nbre;
            this.NbreVnr=this.Model.NbreVnr;
        }
        public override void Write()
        {
            this.Model.InfCdVoie=this. InfCdVoie.Model;
            this.Model.InfChaussee=this. InfChaussee.Model;
            this.Model.AbsDeb=this.AbsDeb;
            this.Model.NumVnr=this.NumVnr;
            this.Model.AbsFin=this.AbsFin;
            this.Model.Num=this.Num;
            this.Model.Nbre=this.Nbre;
            this.Model.NbreVnr=this.NbreVnr;
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
        
        private Int64 _numVnr;
        [DisplayName("Num Voie total")]
        public Int64 NumVnr
        {
            get
            {
                return this._numVnr;
            }
            set
            {
                this._numVnr = value;
                RaisePropertyChange("NumVnr");
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
        
        private Nullable<Int64> _num;
        [DisplayName("Numéro Voie")]
        public Nullable<Int64> Num
        {
            get
            {
                return this._num;
            }
            set
            {
                this._num = value;
                RaisePropertyChange("Num");
            }
        }
        
        private Nullable<Int64> _nbre;
        [DisplayName("Nbre de voies")]
        public Nullable<Int64> Nbre
        {
            get
            {
                return this._nbre;
            }
            set
            {
                this._nbre = value;
                RaisePropertyChange("Nbre");
            }
        }
        
        private Int64 _nbreVnr;
        [DisplayName("Nbre Voie total")]
        public Int64 NbreVnr
        {
            get
            {
                return this._nbreVnr;
            }
            set
            {
                this._nbreVnr = value;
                RaisePropertyChange("NbreVnr");
            }
        }
        
    }
}
