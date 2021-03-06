using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class DsSimRecValuesViewModel : ViewModelBase<DsSimRecValues>
    {
        public DsSimRecValuesViewModel(DsSimRecValues model) : base(model)
        {
        }
        public override void Read()
        {
            this.DsSimRec=new DsSimRecViewModel( this.Model.DsSimRec);
            this.Annee=this.Model.Annee;
            this.Valeur=this.Model.Valeur;
        }
        public override void Write()
        {
            this.Model.DsSimRec=this. DsSimRec.Model;
            this.Model.Annee=this.Annee;
            this.Model.Valeur=this.Valeur;
        }
        private DsSimRecViewModel _dsSimRec;
        [DisplayName("SIM_REC_DS")]
        public virtual DsSimRecViewModel DsSimRec
        {
            get
            {
                return this._dsSimRec;
            }
            set
            {
                this._dsSimRec = value;
                RaisePropertyChange("DsSimRec");
            }
        }
        
        private Int64 _annee;
        [DisplayName("SIM_REC_VALUES_DS__ANNEE")]
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
        [DisplayName("SIM_REC_VALUES_DS__VALEUR")]
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
                    errors.Add("SIM_REC_VALUES_DS__ANNEE : "+this["Annee"]);
                }
                if (this["Valeur"] != null)
                {
                    errors.Add("SIM_REC_VALUES_DS__VALEUR : "+this["Valeur"]);
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
