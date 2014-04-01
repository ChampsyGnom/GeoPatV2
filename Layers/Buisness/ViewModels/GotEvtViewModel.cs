using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotEvtViewModel : ViewModelBase
    {
        public GotEvt Model {get; set;}
        public GotEvtViewModel(GotEvt model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.GotCdEvt=new GotCdEvtViewModel( this.Model.GotCdEvt);
            this.GotDsc=new GotDscViewModel( this.Model.GotDsc);
            this.DateRel=this.Model.DateRel;
            this.DateTrt=this.Model.DateTrt;
            this.Obsv=this.Model.Obsv;
        }
        public override void Write()
        {
            this.Model.GotCdEvt=this. GotCdEvt.Model;
            this.Model.GotDsc=this. GotDsc.Model;
            this.Model.DateRel=this.DateRel;
            this.Model.DateTrt=this.DateTrt;
            this.Model.Obsv=this.Obsv;
        }
        private GotCdEvtViewModel _gotCdEvt;
        [DisplayName("Type d'événement")]
        public virtual GotCdEvtViewModel GotCdEvt
        {
            get
            {
                return this._gotCdEvt;
            }
            set
            {
                this._gotCdEvt = value;
                RaisePropertyChange("GotCdEvt");
            }
        }
        
        private GotDscViewModel _gotDsc;
        [DisplayName("Terrassement")]
        public virtual GotDscViewModel GotDsc
        {
            get
            {
                return this._gotDsc;
            }
            set
            {
                this._gotDsc = value;
                RaisePropertyChange("GotDsc");
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
