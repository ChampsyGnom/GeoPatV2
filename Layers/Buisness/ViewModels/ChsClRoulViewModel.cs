using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsClRoulViewModel : ViewModelBase<ChsClRoul>
    {
        public ChsClRoulViewModel(ChsClRoul model) : base(model)
        {
        }
        public override void Read()
        {
            this.ChsClCarotte=new ChsClCarotteViewModel( this.Model.ChsClCarotte);
            this.DateMs=this.Model.DateMs;
            this.AbsFin=this.Model.AbsFin;
            this.Technique=this.Model.Technique;
            this.Epais=this.Model.Epais;
            this.Granulo=this.Model.Granulo;
        }
        public override void Write()
        {
            this.Model.ChsClCarotte=this. ChsClCarotte.Model;
            this.Model.DateMs=this.DateMs;
            this.Model.AbsFin=this.AbsFin;
            this.Model.Technique=this.Technique;
            this.Model.Epais=this.Epais;
            this.Model.Granulo=this.Granulo;
        }
        private ChsClCarotteViewModel _chsClCarotte;
        [DisplayName("Carotte calculée")]
        public virtual ChsClCarotteViewModel ChsClCarotte
        {
            get
            {
                return this._chsClCarotte;
            }
            set
            {
                this._chsClCarotte = value;
                RaisePropertyChange("ChsClCarotte");
            }
        }
        
        private DateTime _dateMs;
        [DisplayName("Date MS")]
        public DateTime DateMs
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
        
        private Int64 _absFin;
        [DisplayName("Pr fin")]
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
        
        private String _technique;
        [DisplayName("Technique")]
        public String Technique
        {
            get
            {
                return this._technique;
            }
            set
            {
                this._technique = value;
                RaisePropertyChange("Technique");
            }
        }
        private Nullable<Double> _epais;
        [DisplayName("Epaisseur")]
        public Nullable<Double> Epais
        {
            get
            {
                return this._epais;
            }
            set
            {
                this._epais = value;
                RaisePropertyChange("Epais");
            }
        }
        
        private String _granulo;
        [DisplayName("Granulométrie")]
        public String Granulo
        {
            get
            {
                return this._granulo;
            }
            set
            {
                this._granulo = value;
                RaisePropertyChange("Granulo");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["DateMs"] != null)
                {
                    errors.Add("Date MS : "+this["DateMs"]);
                }
                if (this["AbsFin"] != null)
                {
                    errors.Add("Pr fin : "+this["AbsFin"]);
                }
                if (this["Technique"] != null)
                {
                    errors.Add("Technique : "+this["Technique"]);
                }
                if (this["Epais"] != null)
                {
                    errors.Add("Epaisseur : "+this["Epais"]);
                }
                if (this["Granulo"] != null)
                {
                    errors.Add("Granulométrie : "+this["Granulo"]);
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
                if (columnName.Equals("AbsFin"))
                {
                }
                if (columnName.Equals("Technique"))
                {
                }
                if (columnName.Equals("Epais"))
                {
                }
                if (columnName.Equals("Granulo"))
                {
                }
                return null;
            }
        }
    }
}
