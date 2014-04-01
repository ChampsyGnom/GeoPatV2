using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhEvtViewModel : ViewModelBase
    {
        public OhEvt Model {get; set;}
        public OhEvtViewModel(OhEvt model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.OhCdEvt=new OhCdEvtViewModel( this.Model.OhCdEvt);
            this.OhDsc=new OhDscViewModel( this.Model.OhDsc);
            this.DateRel=this.Model.DateRel;
            this.DateTrt=this.Model.DateTrt;
            this.Obsv=this.Model.Obsv;
        }
        public override void Write()
        {
            this.Model.OhCdEvt=this. OhCdEvt.Model;
            this.Model.OhDsc=this. OhDsc.Model;
            this.Model.DateRel=this.DateRel;
            this.Model.DateTrt=this.DateTrt;
            this.Model.Obsv=this.Obsv;
        }
        private OhCdEvtViewModel _ohCdEvt;
        [DisplayName("Type d'événement")]
        public virtual OhCdEvtViewModel OhCdEvt
        {
            get
            {
                return this._ohCdEvt;
            }
            set
            {
                this._ohCdEvt = value;
                RaisePropertyChange("OhCdEvt");
            }
        }
        
        private OhDscViewModel _ohDsc;
        [DisplayName("Ouvrage Hydraulique")]
        public virtual OhDscViewModel OhDsc
        {
            get
            {
                return this._ohDsc;
            }
            set
            {
                this._ohDsc = value;
                RaisePropertyChange("OhDsc");
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
    }
}
