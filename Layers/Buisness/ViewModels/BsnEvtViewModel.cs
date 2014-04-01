using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnEvtViewModel : ViewModelBase
    {
        public BsnEvt Model {get; set;}
        public BsnEvtViewModel(BsnEvt model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.BsnCdEvt=new BsnCdEvtViewModel( this.Model.BsnCdEvt);
            this.BsnDsc=new BsnDscViewModel( this.Model.BsnDsc);
            this.DateRel=this.Model.DateRel;
            this.DateTrt=this.Model.DateTrt;
            this.Obsv=this.Model.Obsv;
        }
        public override void Write()
        {
            this.Model.BsnCdEvt=this. BsnCdEvt.Model;
            this.Model.BsnDsc=this. BsnDsc.Model;
            this.Model.DateRel=this.DateRel;
            this.Model.DateTrt=this.DateTrt;
            this.Model.Obsv=this.Obsv;
        }
        private BsnCdEvtViewModel _bsnCdEvt;
        [DisplayName("Type d'événement")]
        public virtual BsnCdEvtViewModel BsnCdEvt
        {
            get
            {
                return this._bsnCdEvt;
            }
            set
            {
                this._bsnCdEvt = value;
                RaisePropertyChange("BsnCdEvt");
            }
        }
        
        private BsnDscViewModel _bsnDsc;
        [DisplayName("Bassin")]
        public virtual BsnDscViewModel BsnDsc
        {
            get
            {
                return this._bsnDsc;
            }
            set
            {
                this._bsnDsc = value;
                RaisePropertyChange("BsnDsc");
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
