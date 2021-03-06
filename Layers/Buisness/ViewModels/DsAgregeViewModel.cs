using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class DsAgregeViewModel : ViewModelBase<DsAgrege>
    {
        public DsAgregeViewModel(DsAgrege model) : base(model)
        {
        }
        public override void Read()
        {
            this.Code=this.Model.Code;
            this.Libelle=this.Model.Libelle;
            this.SrcAgr=this.Model.SrcAgr;
            this.SrcIndic=this.Model.SrcIndic;
            this.Seuil1=this.Model.Seuil1;
            this.Seuil2=this.Model.Seuil2;
            this.Seuil3=this.Model.Seuil3;
            this.Seuil4=this.Model.Seuil4;
            this.ValeurSens=this.Model.ValeurSens;
            this.ValeurAbs=this.Model.ValeurAbs;
        }
        public override void Write()
        {
            this.Model.Code=this.Code;
            this.Model.Libelle=this.Libelle;
            this.Model.SrcAgr=this.SrcAgr;
            this.Model.SrcIndic=this.SrcIndic;
            this.Model.Seuil1=this.Seuil1;
            this.Model.Seuil2=this.Seuil2;
            this.Model.Seuil3=this.Seuil3;
            this.Model.Seuil4=this.Seuil4;
            this.Model.ValeurSens=this.ValeurSens;
            this.Model.ValeurAbs=this.ValeurAbs;
        }
        private String _code;
        [DisplayName("AGREGE_DS__CODE")]
        public String Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
                RaisePropertyChange("Code");
            }
        }
        private String _libelle;
        [DisplayName("AGREGE_DS__LIBELLE")]
        public String Libelle
        {
            get
            {
                return this._libelle;
            }
            set
            {
                this._libelle = value;
                RaisePropertyChange("Libelle");
            }
        }
        private String _srcAgr;
        [DisplayName("AGREGE_DS__SRC_AGR")]
        public String SrcAgr
        {
            get
            {
                return this._srcAgr;
            }
            set
            {
                this._srcAgr = value;
                RaisePropertyChange("SrcAgr");
            }
        }
        private String _srcIndic;
        [DisplayName("AGREGE_DS__SRC_INDIC")]
        public String SrcIndic
        {
            get
            {
                return this._srcIndic;
            }
            set
            {
                this._srcIndic = value;
                RaisePropertyChange("SrcIndic");
            }
        }
        private Nullable<Double> _seuil1;
        [DisplayName("AGREGE_DS__SEUIL1")]
        public Nullable<Double> Seuil1
        {
            get
            {
                return this._seuil1;
            }
            set
            {
                this._seuil1 = value;
                RaisePropertyChange("Seuil1");
            }
        }
        
        private Nullable<Double> _seuil2;
        [DisplayName("AGREGE_DS__SEUIL2")]
        public Nullable<Double> Seuil2
        {
            get
            {
                return this._seuil2;
            }
            set
            {
                this._seuil2 = value;
                RaisePropertyChange("Seuil2");
            }
        }
        
        private Nullable<Double> _seuil3;
        [DisplayName("AGREGE_DS__SEUIL3")]
        public Nullable<Double> Seuil3
        {
            get
            {
                return this._seuil3;
            }
            set
            {
                this._seuil3 = value;
                RaisePropertyChange("Seuil3");
            }
        }
        
        private Nullable<Double> _seuil4;
        [DisplayName("AGREGE_DS__SEUIL4")]
        public Nullable<Double> Seuil4
        {
            get
            {
                return this._seuil4;
            }
            set
            {
                this._seuil4 = value;
                RaisePropertyChange("Seuil4");
            }
        }
        
        private String _valeurSens;
        [DisplayName("AGREGE_DS__VALEUR_SENS")]
        public String ValeurSens
        {
            get
            {
                return this._valeurSens;
            }
            set
            {
                this._valeurSens = value;
                RaisePropertyChange("ValeurSens");
            }
        }
        private Nullable<Boolean> _valeurAbs;
        [DisplayName("AGREGE_DS__VALEUR_ABS")]
        public Nullable<Boolean> ValeurAbs
        {
            get
            {
                return this._valeurAbs;
            }
            set
            {
                this._valeurAbs = value;
                RaisePropertyChange("ValeurAbs");
            }
        }
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Code"] != null)
                {
                    errors.Add("AGREGE_DS__CODE : "+this["Code"]);
                }
                if (this["Libelle"] != null)
                {
                    errors.Add("AGREGE_DS__LIBELLE : "+this["Libelle"]);
                }
                if (this["SrcAgr"] != null)
                {
                    errors.Add("AGREGE_DS__SRC_AGR : "+this["SrcAgr"]);
                }
                if (this["SrcIndic"] != null)
                {
                    errors.Add("AGREGE_DS__SRC_INDIC : "+this["SrcIndic"]);
                }
                if (this["Seuil1"] != null)
                {
                    errors.Add("AGREGE_DS__SEUIL1 : "+this["Seuil1"]);
                }
                if (this["Seuil2"] != null)
                {
                    errors.Add("AGREGE_DS__SEUIL2 : "+this["Seuil2"]);
                }
                if (this["Seuil3"] != null)
                {
                    errors.Add("AGREGE_DS__SEUIL3 : "+this["Seuil3"]);
                }
                if (this["Seuil4"] != null)
                {
                    errors.Add("AGREGE_DS__SEUIL4 : "+this["Seuil4"]);
                }
                if (this["ValeurSens"] != null)
                {
                    errors.Add("AGREGE_DS__VALEUR_SENS : "+this["ValeurSens"]);
                }
                if (this["ValeurAbs"] != null)
                {
                    errors.Add("AGREGE_DS__VALEUR_ABS : "+this["ValeurAbs"]);
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
                if (columnName.Equals("Code"))
                {
                    if (String.IsNullOrEmpty(this.Code))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("Libelle"))
                {
                    if (String.IsNullOrEmpty(this.Libelle))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("SrcAgr"))
                {
                }
                if (columnName.Equals("SrcIndic"))
                {
                }
                if (columnName.Equals("Seuil1"))
                {
                }
                if (columnName.Equals("Seuil2"))
                {
                }
                if (columnName.Equals("Seuil3"))
                {
                }
                if (columnName.Equals("Seuil4"))
                {
                }
                if (columnName.Equals("ValeurSens"))
                {
                }
                if (columnName.Equals("ValeurAbs"))
                {
                }
                return null;
            }
        }
    }
}
