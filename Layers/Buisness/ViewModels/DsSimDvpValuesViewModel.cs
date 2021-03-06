using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class DsSimDvpValuesViewModel : ViewModelBase<DsSimDvpValues>
    {
        public DsSimDvpValuesViewModel(DsSimDvpValues model) : base(model)
        {
        }
        public override void Read()
        {
            this.DsSimDvp=new DsSimDvpViewModel( this.Model.DsSimDvp);
            this.Annee=this.Model.Annee;
            this.Valeur=this.Model.Valeur;
        }
        public override void Write()
        {
            this.Model.DsSimDvp=this. DsSimDvp.Model;
            this.Model.Annee=this.Annee;
            this.Model.Valeur=this.Valeur;
        }
        private DsSimDvpViewModel _dsSimDvp;
        [DisplayName("SIM_DVP_DS")]
        public virtual DsSimDvpViewModel DsSimDvp
        {
            get
            {
                return this._dsSimDvp;
            }
            set
            {
                this._dsSimDvp = value;
                RaisePropertyChange("DsSimDvp");
            }
        }
        
        private Int64 _annee;
        [DisplayName("SIM_DVP_VALUES_DS__ANNEE")]
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
        
        private Int64 _valeur;
        [DisplayName("SIM_DVP_VALUES_DS__VALEUR")]
        public Int64 Valeur
        {
            get
            {
                return this._valeur;
            }
            set
            {
                this._valeur = value;
                RaisePropertyChange("Valeur");
            }
        }
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Annee"] != null)
                {
                    errors.Add("SIM_DVP_VALUES_DS__ANNEE : "+this["Annee"]);
                }
                if (this["Valeur"] != null)
                {
                    errors.Add("SIM_DVP_VALUES_DS__VALEUR : "+this["Valeur"]);
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
                if (columnName.Equals("Annee"))
                {
                }
                if (columnName.Equals("Valeur"))
                {
                }
                return null;
            }
        }
    }
}
