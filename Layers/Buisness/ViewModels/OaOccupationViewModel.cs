using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaOccupationViewModel : ViewModelBase<OaOccupation>
    {
        public OaOccupationViewModel(OaOccupation model) : base(model)
        {
        }
        public override void Read()
        {
            this.OaDsc=new OaDscViewModel( this.Model.OaDsc);
            this.OaCdOccupant=new OaCdOccupantViewModel( this.Model.OaCdOccupant);
            this.OaCdOccup=new OaCdOccupViewModel( this.Model.OaCdOccup);
            this.DateMs=this.Model.DateMs;
            this.DateFv=this.Model.DateFv;
            this.Trav=this.Model.Trav;
            this.NumConv=this.Model.NumConv;
            this.Observ=this.Model.Observ;
        }
        public override void Write()
        {
            this.Model.OaDsc=this. OaDsc.Model;
            this.Model.OaCdOccupant=this. OaCdOccupant.Model;
            this.Model.OaCdOccup=this. OaCdOccup.Model;
            this.Model.DateMs=this.DateMs;
            this.Model.DateFv=this.DateFv;
            this.Model.Trav=this.Trav;
            this.Model.NumConv=this.NumConv;
            this.Model.Observ=this.Observ;
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
        
        private OaCdOccupantViewModel _oaCdOccupant;
        [DisplayName("Occupant")]
        public virtual OaCdOccupantViewModel OaCdOccupant
        {
            get
            {
                return this._oaCdOccupant;
            }
            set
            {
                this._oaCdOccupant = value;
                RaisePropertyChange("OaCdOccupant");
            }
        }
        
        private OaCdOccupViewModel _oaCdOccup;
        [DisplayName("Type Occupation")]
        public virtual OaCdOccupViewModel OaCdOccup
        {
            get
            {
                return this._oaCdOccup;
            }
            set
            {
                this._oaCdOccup = value;
                RaisePropertyChange("OaCdOccup");
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
        
        private String _numConv;
        [DisplayName("N° convention")]
        public String NumConv
        {
            get
            {
                return this._numConv;
            }
            set
            {
                this._numConv = value;
                RaisePropertyChange("NumConv");
            }
        }
        private String _observ;
        [DisplayName("Commentaires")]
        public String Observ
        {
            get
            {
                return this._observ;
            }
            set
            {
                this._observ = value;
                RaisePropertyChange("Observ");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["DateMs"] != null)
                {
                    errors.Add("Date Début : "+this["DateMs"]);
                }
                if (this["DateFv"] != null)
                {
                    errors.Add("Date Fin : "+this["DateFv"]);
                }
                if (this["Trav"] != null)
                {
                    errors.Add("Traversé : "+this["Trav"]);
                }
                if (this["NumConv"] != null)
                {
                    errors.Add("N° convention : "+this["NumConv"]);
                }
                if (this["Observ"] != null)
                {
                    errors.Add("Commentaires : "+this["Observ"]);
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
                if (columnName.Equals("DateMs"))
                {
                }
                if (columnName.Equals("DateFv"))
                {
                }
                if (columnName.Equals("Trav"))
                {
                }
                if (columnName.Equals("NumConv"))
                {
                }
                if (columnName.Equals("Observ"))
                {
                }
                return null;
            }
        }
    }
}
