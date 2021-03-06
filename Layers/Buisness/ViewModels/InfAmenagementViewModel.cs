using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfAmenagementViewModel : ViewModelBase<InfAmenagement>
    {
        public InfAmenagementViewModel(InfAmenagement model) : base(model)
        {
        }
        public override void Read()
        {
            this.InfCdAmenag=new InfCdAmenagViewModel( this.Model.InfCdAmenag);
            this.InfChaussee=new InfChausseeViewModel( this.Model.InfChaussee);
            this.DateDeb=this.Model.DateDeb;
            this.AbsDeb=this.Model.AbsDeb;
            this.DateFin=this.Model.DateFin;
            this.AbsFin=this.Model.AbsFin;
            this.Cout=this.Model.Cout;
            this.Observ=this.Model.Observ;
        }
        public override void Write()
        {
            this.Model.InfCdAmenag=this. InfCdAmenag.Model;
            this.Model.InfChaussee=this. InfChaussee.Model;
            this.Model.DateDeb=this.DateDeb;
            this.Model.AbsDeb=this.AbsDeb;
            this.Model.DateFin=this.DateFin;
            this.Model.AbsFin=this.AbsFin;
            this.Model.Cout=this.Cout;
            this.Model.Observ=this.Observ;
        }
        private InfCdAmenagViewModel _infCdAmenag;
        [DisplayName("Type Aménagement")]
        public virtual InfCdAmenagViewModel InfCdAmenag
        {
            get
            {
                return this._infCdAmenag;
            }
            set
            {
                this._infCdAmenag = value;
                RaisePropertyChange("InfCdAmenag");
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
        
        private DateTime _dateDeb;
        [DisplayName("Date début")]
        public DateTime DateDeb
        {
            get
            {
                return this._dateDeb;
            }
            set
            {
                this._dateDeb = value;
                RaisePropertyChange("DateDeb");
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
        
        private Nullable<DateTime> _dateFin;
        [DisplayName("Date Fin")]
        public Nullable<DateTime> DateFin
        {
            get
            {
                return this._dateFin;
            }
            set
            {
                this._dateFin = value;
                RaisePropertyChange("DateFin");
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
        
        private Nullable<Int64> _cout;
        [DisplayName("Coûts (k€)")]
        public Nullable<Int64> Cout
        {
            get
            {
                return this._cout;
            }
            set
            {
                this._cout = value;
                RaisePropertyChange("Cout");
            }
        }
        
        private String _observ;
        [DisplayName("Commentaire")]
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
                if (this["DateDeb"] != null)
                {
                    errors.Add("Date début : "+this["DateDeb"]);
                }
                if (this["AbsDeb"] != null)
                {
                    errors.Add("Début : "+this["AbsDeb"]);
                }
                if (this["DateFin"] != null)
                {
                    errors.Add("Date Fin : "+this["DateFin"]);
                }
                if (this["AbsFin"] != null)
                {
                    errors.Add("Fin : "+this["AbsFin"]);
                }
                if (this["Cout"] != null)
                {
                    errors.Add("Coûts (k€) : "+this["Cout"]);
                }
                if (this["Observ"] != null)
                {
                    errors.Add("Commentaire : "+this["Observ"]);
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
                if (columnName.Equals("DateDeb"))
                {
                }
                if (columnName.Equals("AbsDeb"))
                {
                }
                if (columnName.Equals("DateFin"))
                {
                }
                if (columnName.Equals("AbsFin"))
                {
                }
                if (columnName.Equals("Cout"))
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
