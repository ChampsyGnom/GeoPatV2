using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpEvtViewModel : ViewModelBase
    {
        public EqpEvt Model {get; set;}
        public EqpEvtViewModel(EqpEvt model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.EqpCdType=new EqpCdTypeViewModel( this.Model.EqpCdType);
            this.EqpCdEvt=new EqpCdEvtViewModel( this.Model.EqpCdEvt);
            this.EqpCdPosit=new EqpCdPositViewModel( this.Model.EqpCdPosit);
            this.IdEvt=this.Model.IdEvt;
            this.Ouvrage=this.Model.Ouvrage;
            this.Liaison=this.Model.Liaison;
            this.Sens=this.Model.Sens;
            this.AbsDeb=this.Model.AbsDeb;
            this.AbsFin=this.Model.AbsFin;
            this.DateRel=this.Model.DateRel;
            this.Obsv=this.Model.Obsv;
            this.DateTrt=this.Model.DateTrt;
        }
        public override void Write()
        {
            this.Model.EqpCdType=this. EqpCdType.Model;
            this.Model.EqpCdEvt=this. EqpCdEvt.Model;
            this.Model.EqpCdPosit=this. EqpCdPosit.Model;
            this.Model.IdEvt=this.IdEvt;
            this.Model.Ouvrage=this.Ouvrage;
            this.Model.Liaison=this.Liaison;
            this.Model.Sens=this.Sens;
            this.Model.AbsDeb=this.AbsDeb;
            this.Model.AbsFin=this.AbsFin;
            this.Model.DateRel=this.DateRel;
            this.Model.Obsv=this.Obsv;
            this.Model.DateTrt=this.DateTrt;
        }
        private EqpCdTypeViewModel _eqpCdType;
        [DisplayName("Type d'équipement")]
        public virtual EqpCdTypeViewModel EqpCdType
        {
            get
            {
                return this._eqpCdType;
            }
            set
            {
                this._eqpCdType = value;
                RaisePropertyChange("EqpCdType");
            }
        }
        
        private EqpCdEvtViewModel _eqpCdEvt;
        [DisplayName("Type d'événement")]
        public virtual EqpCdEvtViewModel EqpCdEvt
        {
            get
            {
                return this._eqpCdEvt;
            }
            set
            {
                this._eqpCdEvt = value;
                RaisePropertyChange("EqpCdEvt");
            }
        }
        
        private EqpCdPositViewModel _eqpCdPosit;
        [DisplayName("Position")]
        public virtual EqpCdPositViewModel EqpCdPosit
        {
            get
            {
                return this._eqpCdPosit;
            }
            set
            {
                this._eqpCdPosit = value;
                RaisePropertyChange("EqpCdPosit");
            }
        }
        
        private Int64 _idEvt;
        [DisplayName("Identifiant Evénement")]
        public Int64 IdEvt
        {
            get
            {
                return this._idEvt;
            }
            set
            {
                this._idEvt = value;
                RaisePropertyChange("IdEvt");
            }
        }
        
        private String _ouvrage;
        [DisplayName("N° Exploitation")]
        public String Ouvrage
        {
            get
            {
                return this._ouvrage;
            }
            set
            {
                this._ouvrage = value;
                RaisePropertyChange("Ouvrage");
            }
        }
        private String _liaison;
        [DisplayName("Liaison")]
        public String Liaison
        {
            get
            {
                return this._liaison;
            }
            set
            {
                this._liaison = value;
                RaisePropertyChange("Liaison");
            }
        }
        private String _sens;
        [DisplayName("Sens")]
        public String Sens
        {
            get
            {
                return this._sens;
            }
            set
            {
                this._sens = value;
                RaisePropertyChange("Sens");
            }
        }
        private Int64 _absDeb;
        [DisplayName("PR début")]
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
        [DisplayName("PR fin")]
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
        
        private DateTime _dateRel;
        [DisplayName("Date Relevé")]
        public DateTime DateRel
        {
            get
            {
                return this._dateRel;
            }
            set
            {
                this._dateRel = value;
                RaisePropertyChange("DateRel");
            }
        }
        
        private String _obsv;
        [DisplayName("Observation")]
        public String Obsv
        {
            get
            {
                return this._obsv;
            }
            set
            {
                this._obsv = value;
                RaisePropertyChange("Obsv");
            }
        }
        private Nullable<DateTime> _dateTrt;
        [DisplayName("Date Traitement")]
        public Nullable<DateTime> DateTrt
        {
            get
            {
                return this._dateTrt;
            }
            set
            {
                this._dateTrt = value;
                RaisePropertyChange("DateTrt");
            }
        }
        
    }
}
