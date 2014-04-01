using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfOccupationViewModel : ViewModelBase<InfOccupation>
    {
        public InfOccupationViewModel(InfOccupation model) : base(model)
        {
        }
        public override void Read()
        {
            this.InfCdOccup=new InfCdOccupViewModel( this.Model.InfCdOccup);
            this.InfCdOccupant=new InfCdOccupantViewModel( this.Model.InfCdOccupant);
            this.InfChaussee=new InfChausseeViewModel( this.Model.InfChaussee);
            this.AbsDeb=this.Model.AbsDeb;
            this.AbsFin=this.Model.AbsFin;
            this.DateMs=this.Model.DateMs;
            this.DateFv=this.Model.DateFv;
            this.Trav=this.Model.Trav;
            this.Obs=this.Model.Obs;
        }
        public override void Write()
        {
            this.Model.InfCdOccup=this. InfCdOccup.Model;
            this.Model.InfCdOccupant=this. InfCdOccupant.Model;
            this.Model.InfChaussee=this. InfChaussee.Model;
            this.Model.AbsDeb=this.AbsDeb;
            this.Model.AbsFin=this.AbsFin;
            this.Model.DateMs=this.DateMs;
            this.Model.DateFv=this.DateFv;
            this.Model.Trav=this.Trav;
            this.Model.Obs=this.Obs;
        }
        private InfCdOccupViewModel _infCdOccup;
        [DisplayName("Type Occupation")]
        public virtual InfCdOccupViewModel InfCdOccup
        {
            get
            {
                return this._infCdOccup;
            }
            set
            {
                this._infCdOccup = value;
                RaisePropertyChange("InfCdOccup");
            }
        }
        
        private InfCdOccupantViewModel _infCdOccupant;
        [DisplayName("Type Occupant")]
        public virtual InfCdOccupantViewModel InfCdOccupant
        {
            get
            {
                return this._infCdOccupant;
            }
            set
            {
                this._infCdOccupant = value;
                RaisePropertyChange("InfCdOccupant");
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
        
        private Nullable<DateTime> _dateMs;
        [DisplayName("Date Début")]
        public Nullable<DateTime> DateMs
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
        
        private Nullable<DateTime> _dateFv;
        [DisplayName("Date Fin")]
        public Nullable<DateTime> DateFv
        {
            get
            {
                return this._dateFv;
            }
            set
            {
                this._dateFv = value;
                RaisePropertyChange("DateFv");
            }
        }
        
        private Nullable<Boolean> _trav;
        [DisplayName("Traversé")]
        public Nullable<Boolean> Trav
        {
            get
            {
                return this._trav;
            }
            set
            {
                this._trav = value;
                RaisePropertyChange("Trav");
            }
        }
        
        private String _obs;
        [DisplayName("Commentaire")]
        public String Obs
        {
            get
            {
                return this._obs;
            }
            set
            {
                this._obs = value;
                RaisePropertyChange("Obs");
            }
        }
    }
}
