using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsEvtViewModel : ViewModelBase<ChsEvt>
    {
        public ChsEvtViewModel(ChsEvt model) : base(model)
        {
        }
        public override void Read()
        {
            this.ChsCdEvt=new ChsCdEvtViewModel( this.Model.ChsCdEvt);
            this.ChsCdPosit=new ChsCdPositViewModel( this.Model.ChsCdPosit);
            this.IdEvt=this.Model.IdEvt;
            this.Liaison=this.Model.Liaison;
            this.Sens=this.Model.Sens;
            this.AbsDeb=this.Model.AbsDeb;
            this.AbsFin=this.Model.AbsFin;
            this.DateRel=this.Model.DateRel;
            this.Vsta=this.Model.Vsta;
            this.Obsv=this.Model.Obsv;
            this.DateTrt=this.Model.DateTrt;
        }
        public override void Write()
        {
            this.Model.ChsCdEvt=this. ChsCdEvt.Model;
            this.Model.ChsCdPosit=this. ChsCdPosit.Model;
            this.Model.IdEvt=this.IdEvt;
            this.Model.Liaison=this.Liaison;
            this.Model.Sens=this.Sens;
            this.Model.AbsDeb=this.AbsDeb;
            this.Model.AbsFin=this.AbsFin;
            this.Model.DateRel=this.DateRel;
            this.Model.Vsta=this.Vsta;
            this.Model.Obsv=this.Obsv;
            this.Model.DateTrt=this.DateTrt;
        }
        private ChsCdEvtViewModel _chsCdEvt;
        [DisplayName("Type d'événement")]
        public virtual ChsCdEvtViewModel ChsCdEvt
        {
            get
            {
                return this._chsCdEvt;
            }
            set
            {
                this._chsCdEvt = value;
                RaisePropertyChange("ChsCdEvt");
            }
        }
        
        private ChsCdPositViewModel _chsCdPosit;
        [DisplayName("Position")]
        public virtual ChsCdPositViewModel ChsCdPosit
        {
            get
            {
                return this._chsCdPosit;
            }
            set
            {
                this._chsCdPosit = value;
                RaisePropertyChange("ChsCdPosit");
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
        
        private Nullable<Boolean> _vsta;
        [DisplayName("Visite annuelle")]
        public Nullable<Boolean> Vsta
        {
            get
            {
                return this._vsta;
            }
            set
            {
                this._vsta = value;
                RaisePropertyChange("Vsta");
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
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["IdEvt"] != null)
                {
                    errors.Add("Identifiant Evénement : "+this["IdEvt"]);
                }
                if (this["Liaison"] != null)
                {
                    errors.Add("Liaison : "+this["Liaison"]);
                }
                if (this["Sens"] != null)
                {
                    errors.Add("Sens : "+this["Sens"]);
                }
                if (this["AbsDeb"] != null)
                {
                    errors.Add("PR début : "+this["AbsDeb"]);
                }
                if (this["AbsFin"] != null)
                {
                    errors.Add("PR fin : "+this["AbsFin"]);
                }
                if (this["DateRel"] != null)
                {
                    errors.Add("Date Relevé : "+this["DateRel"]);
                }
                if (this["Vsta"] != null)
                {
                    errors.Add("Visite annuelle : "+this["Vsta"]);
                }
                if (this["Obsv"] != null)
                {
                    errors.Add("Observation : "+this["Obsv"]);
                }
                if (this["DateTrt"] != null)
                {
                    errors.Add("Date Traitement : "+this["DateTrt"]);
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
                if (columnName.Equals("IdEvt"))
                {
                }
                if (columnName.Equals("Liaison"))
                {
                    if (String.IsNullOrEmpty(this.Liaison))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("Sens"))
                {
                    if (String.IsNullOrEmpty(this.Sens))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("AbsDeb"))
                {
                }
                if (columnName.Equals("AbsFin"))
                {
                }
                if (columnName.Equals("DateRel"))
                {
                }
                if (columnName.Equals("Vsta"))
                {
                }
                if (columnName.Equals("Obsv"))
                {
                }
                if (columnName.Equals("DateTrt"))
                {
                }
                return null;
            }
        }
    }
}
