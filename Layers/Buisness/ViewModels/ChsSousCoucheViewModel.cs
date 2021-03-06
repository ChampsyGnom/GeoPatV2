using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsSousCoucheViewModel : ViewModelBase<ChsSousCouche>
    {
        public ChsSousCoucheViewModel(ChsSousCouche model) : base(model)
        {
        }
        public override void Read()
        {
            this.ChsPave=new ChsPaveViewModel( this.Model.ChsPave);
            this.ChsCdTech=new ChsCdTechViewModel( this.Model.ChsCdTech);
            this.Numordre=this.Model.Numordre;
            this.Epais=this.Model.Epais;
            this.Dosage=this.Model.Dosage;
        }
        public override void Write()
        {
            this.Model.ChsPave=this. ChsPave.Model;
            this.Model.ChsCdTech=this. ChsCdTech.Model;
            this.Model.Numordre=this.Numordre;
            this.Model.Epais=this.Epais;
            this.Model.Dosage=this.Dosage;
        }
        private ChsPaveViewModel _chsPave;
        [DisplayName("Pavé MO")]
        public virtual ChsPaveViewModel ChsPave
        {
            get
            {
                return this._chsPave;
            }
            set
            {
                this._chsPave = value;
                RaisePropertyChange("ChsPave");
            }
        }
        
        private ChsCdTechViewModel _chsCdTech;
        [DisplayName("Techniques structure et entretien")]
        public virtual ChsCdTechViewModel ChsCdTech
        {
            get
            {
                return this._chsCdTech;
            }
            set
            {
                this._chsCdTech = value;
                RaisePropertyChange("ChsCdTech");
            }
        }
        
        private Int64 _numordre;
        [DisplayName("No Ordre")]
        public Int64 Numordre
        {
            get
            {
                return this._numordre;
            }
            set
            {
                this._numordre = value;
                RaisePropertyChange("Numordre");
            }
        }
        
        private Double _epais;
        [DisplayName("Epaisseur (cm)")]
        public Double Epais
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
        
        private String _dosage;
        [DisplayName("Dosage")]
        public String Dosage
        {
            get
            {
                return this._dosage;
            }
            set
            {
                this._dosage = value;
                RaisePropertyChange("Dosage");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Numordre"] != null)
                {
                    errors.Add("No Ordre : "+this["Numordre"]);
                }
                if (this["Epais"] != null)
                {
                    errors.Add("Epaisseur (cm) : "+this["Epais"]);
                }
                if (this["Dosage"] != null)
                {
                    errors.Add("Dosage : "+this["Dosage"]);
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
                if (columnName.Equals("Numordre"))
                {
                }
                if (columnName.Equals("Epais"))
                {
                }
                if (columnName.Equals("Dosage"))
                {
                }
                return null;
            }
        }
    }
}
