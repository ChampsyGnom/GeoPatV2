using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaEvtViewModel : ViewModelBase<OaEvt>
    {
        public OaEvtViewModel(OaEvt model) : base(model)
        {
        }
        public override void Read()
        {
            this.OaCdEvt=new OaCdEvtViewModel( this.Model.OaCdEvt);
            this.OaDsc=new OaDscViewModel( this.Model.OaDsc);
            this.DateRel=this.Model.DateRel;
            this.DateTrt=this.Model.DateTrt;
            this.Obsv=this.Model.Obsv;
        }
        public override void Write()
        {
            this.Model.OaCdEvt=this. OaCdEvt.Model;
            this.Model.OaDsc=this. OaDsc.Model;
            this.Model.DateRel=this.DateRel;
            this.Model.DateTrt=this.DateTrt;
            this.Model.Obsv=this.Obsv;
        }
        private OaCdEvtViewModel _oaCdEvt;
        [DisplayName("Type d'événement")]
        public virtual OaCdEvtViewModel OaCdEvt
        {
            get
            {
                return this._oaCdEvt;
            }
            set
            {
                this._oaCdEvt = value;
                RaisePropertyChange("OaCdEvt");
            }
        }
        
        private OaDscViewModel _oaDsc;
        [DisplayName("Ouvrages d'Art")]
        public virtual OaDscViewModel OaDsc
        {
            get
            {
                return this._oaDsc;
            }
            set
            {
                this._oaDsc = value;
                RaisePropertyChange("OaDsc");
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
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["DateRel"] != null)
                {
                    errors.Add("Date Relevé : "+this["DateRel"]);
                }
                if (this["DateTrt"] != null)
                {
                    errors.Add("Date Traitement : "+this["DateTrt"]);
                }
                if (this["Obsv"] != null)
                {
                    errors.Add("Observation : "+this["Obsv"]);
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
                if (columnName.Equals("DateRel"))
                {
                }
                if (columnName.Equals("DateTrt"))
                {
                }
                if (columnName.Equals("Obsv"))
                {
                }
                return null;
            }
        }
    }
}
