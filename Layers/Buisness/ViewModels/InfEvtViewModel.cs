using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfEvtViewModel : ViewModelBase<InfEvt>
    {
        public InfEvtViewModel(InfEvt model) : base(model)
        {
        }
        public override void Read()
        {
            this.InfCdEvt=new InfCdEvtViewModel( this.Model.InfCdEvt);
            this.InfCdPosit=new InfCdPositViewModel( this.Model.InfCdPosit);
            this.IdEvt=this.Model.IdEvt;
            this.NomTable=this.Model.NomTable;
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
            this.Model.InfCdEvt=this. InfCdEvt.Model;
            this.Model.InfCdPosit=this. InfCdPosit.Model;
            this.Model.IdEvt=this.IdEvt;
            this.Model.NomTable=this.NomTable;
            this.Model.Liaison=this.Liaison;
            this.Model.Sens=this.Sens;
            this.Model.AbsDeb=this.AbsDeb;
            this.Model.AbsFin=this.AbsFin;
            this.Model.DateRel=this.DateRel;
            this.Model.Obsv=this.Obsv;
            this.Model.DateTrt=this.DateTrt;
        }
        private InfCdEvtViewModel _infCdEvt;
        [DisplayName("Type d'événement")]
        public virtual InfCdEvtViewModel InfCdEvt
        {
            get
            {
                return this._infCdEvt;
            }
            set
            {
                this._infCdEvt = value;
                RaisePropertyChange("InfCdEvt");
            }
        }
        
        private InfCdPositViewModel _infCdPosit;
        [DisplayName("Code Position")]
        public virtual InfCdPositViewModel InfCdPosit
        {
            get
            {
                return this._infCdPosit;
            }
            set
            {
                this._infCdPosit = value;
                RaisePropertyChange("InfCdPosit");
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
        
        private String _nomTable;
        [DisplayName("Nom Table")]
        public String NomTable
        {
            get
            {
                return this._nomTable;
            }
            set
            {
                this._nomTable = value;
                RaisePropertyChange("NomTable");
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
        
        private Nullable<Int64> _absFin;
        [DisplayName("PR fin")]
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
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["IdEvt"] != null)
                {
                    errors.Add("Identifiant Evénement : "+this["IdEvt"]);
                }
                if (this["NomTable"] != null)
                {
                    errors.Add("Nom Table : "+this["NomTable"]);
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
                if (columnName.Equals("NomTable"))
                {
                    if (String.IsNullOrEmpty(this.NomTable))
                    {
                        return "valeur vide non autorisée";
                    }
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
