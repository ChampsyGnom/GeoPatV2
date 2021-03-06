using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class DsSimResultViewModel : ViewModelBase<DsSimResult>
    {
        public DsSimResultViewModel(DsSimResult model) : base(model)
        {
        }
        public override void Read()
        {
            this.DsSimCalculFis=new DsSimCalculFisViewModel( this.Model.DsSimCalculFis);
            this.Liaison=this.Model.Liaison;
            this.Sens=this.Model.Sens;
            this.AbsDeb=this.Model.AbsDeb;
            this.Annee=this.Model.Annee;
            this.AbsFin=this.Model.AbsFin;
            this.Dvr=this.Model.Dvr;
            this.Fis=this.Model.Fis;
            this.Lineaire=this.Model.Lineaire;
            this.Surface=this.Model.Surface;
            this.Epaisseur=this.Model.Epaisseur;
        }
        public override void Write()
        {
            this.Model.DsSimCalculFis=this. DsSimCalculFis.Model;
            this.Model.Liaison=this.Liaison;
            this.Model.Sens=this.Sens;
            this.Model.AbsDeb=this.AbsDeb;
            this.Model.Annee=this.Annee;
            this.Model.AbsFin=this.AbsFin;
            this.Model.Dvr=this.Dvr;
            this.Model.Fis=this.Fis;
            this.Model.Lineaire=this.Lineaire;
            this.Model.Surface=this.Surface;
            this.Model.Epaisseur=this.Epaisseur;
        }
        private DsSimCalculFisViewModel _dsSimCalculFis;
        [DisplayName("SIM_CALCUL_FIS_DS")]
        public virtual DsSimCalculFisViewModel DsSimCalculFis
        {
            get
            {
                return this._dsSimCalculFis;
            }
            set
            {
                this._dsSimCalculFis = value;
                RaisePropertyChange("DsSimCalculFis");
            }
        }
        
        private String _liaison;
        [DisplayName("SIM_RESULT_DS__LIAISON")]
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
        [DisplayName("SIM_RESULT_DS__SENS")]
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
        [DisplayName("SIM_RESULT_DS__ABS_DEB")]
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
        
        private Int64 _annee;
        [DisplayName("SIM_RESULT_DS__ANNEE")]
        public Int64 Annee
        {
            get
            {
                return this._annee;
            }
            set
            {
                this._annee = value;
                RaisePropertyChange("Annee");
            }
        }
        
        private Int64 _absFin;
        [DisplayName("SIM_RESULT_DS__ABS_FIN")]
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
        
        private Int64 _dvr;
        [DisplayName("SIM_RESULT_DS__DVP")]
        public Int64 Dvr
        {
            get
            {
                return this._dvr;
            }
            set
            {
                this._dvr = value;
                RaisePropertyChange("Dvr");
            }
        }
        
        private Int64 _fis;
        [DisplayName("SIM_RESULT_DS__FIS")]
        public Int64 Fis
        {
            get
            {
                return this._fis;
            }
            set
            {
                this._fis = value;
                RaisePropertyChange("Fis");
            }
        }
        
        private Int64 _lineaire;
        [DisplayName("SIM_RESULT_DS__LINEAIRE")]
        public Int64 Lineaire
        {
            get
            {
                return this._lineaire;
            }
            set
            {
                this._lineaire = value;
                RaisePropertyChange("Lineaire");
            }
        }
        
        private Int64 _surface;
        [DisplayName("SIM_RESULT_DS__SURFACE")]
        public Int64 Surface
        {
            get
            {
                return this._surface;
            }
            set
            {
                this._surface = value;
                RaisePropertyChange("Surface");
            }
        }
        
        private Int64 _epaisseur;
        [DisplayName("SIM_RESULT_DS__EPAISSEUR")]
        public Int64 Epaisseur
        {
            get
            {
                return this._epaisseur;
            }
            set
            {
                this._epaisseur = value;
                RaisePropertyChange("Epaisseur");
            }
        }
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Liaison"] != null)
                {
                    errors.Add("SIM_RESULT_DS__LIAISON : "+this["Liaison"]);
                }
                if (this["Sens"] != null)
                {
                    errors.Add("SIM_RESULT_DS__SENS : "+this["Sens"]);
                }
                if (this["AbsDeb"] != null)
                {
                    errors.Add("SIM_RESULT_DS__ABS_DEB : "+this["AbsDeb"]);
                }
                if (this["Annee"] != null)
                {
                    errors.Add("SIM_RESULT_DS__ANNEE : "+this["Annee"]);
                }
                if (this["AbsFin"] != null)
                {
                    errors.Add("SIM_RESULT_DS__ABS_FIN : "+this["AbsFin"]);
                }
                if (this["Dvr"] != null)
                {
                    errors.Add("SIM_RESULT_DS__DVP : "+this["Dvr"]);
                }
                if (this["Fis"] != null)
                {
                    errors.Add("SIM_RESULT_DS__FIS : "+this["Fis"]);
                }
                if (this["Lineaire"] != null)
                {
                    errors.Add("SIM_RESULT_DS__LINEAIRE : "+this["Lineaire"]);
                }
                if (this["Surface"] != null)
                {
                    errors.Add("SIM_RESULT_DS__SURFACE : "+this["Surface"]);
                }
                if (this["Epaisseur"] != null)
                {
                    errors.Add("SIM_RESULT_DS__EPAISSEUR : "+this["Epaisseur"]);
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
                if (columnName.Equals("Annee"))
                {
                }
                if (columnName.Equals("AbsFin"))
                {
                }
                if (columnName.Equals("Dvr"))
                {
                }
                if (columnName.Equals("Fis"))
                {
                }
                if (columnName.Equals("Lineaire"))
                {
                }
                if (columnName.Equals("Surface"))
                {
                }
                if (columnName.Equals("Epaisseur"))
                {
                }
                return null;
            }
        }
    }
}
