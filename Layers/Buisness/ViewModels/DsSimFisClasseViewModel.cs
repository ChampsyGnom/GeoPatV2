using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class DsSimFisClasseViewModel : ViewModelBase<DsSimFisClasse>
    {
        public DsSimFisClasseViewModel(DsSimFisClasse model) : base(model)
        {
            this.DsSimFisValuess = new  ObservableCollection<DsSimFisValuesViewModel>();
            
        }
        public override void Read()
        {
            this.DsSimFis=new DsSimFisViewModel( this.Model.DsSimFis);
            this.Id=this.Model.Id;
            this.Couleur=this.Model.Couleur;
            this.PercentMin=this.Model.PercentMin;
            this.PercentMax=this.Model.PercentMax;
        }
        public override void Write()
        {
            this.Model.DsSimFis=this. DsSimFis.Model;
            this.Model.Id=this.Id;
            this.Model.Couleur=this.Couleur;
            this.Model.PercentMin=this.PercentMin;
            this.Model.PercentMax=this.PercentMax;
        }
        private DsSimFisViewModel _dsSimFis;
        [DisplayName("SIM_FIS_DS")]
        public virtual DsSimFisViewModel DsSimFis
        {
            get
            {
                return this._dsSimFis;
            }
            set
            {
                this._dsSimFis = value;
                RaisePropertyChange("DsSimFis");
            }
        }
        
        public virtual ObservableCollection<DsSimFisValuesViewModel> DsSimFisValuess { get; set; }
        
        private Int64 _id;
        [DisplayName("SIM_FIS_CLASSE_DS__ID")]
        public Int64 Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
                RaisePropertyChange("Id");
            }
        }
        
        private String _couleur;
        [DisplayName("SIM_FIS_CLASSE_DS__COULEUR")]
        public String Couleur
        {
            get
            {
                return this._couleur;
            }
            set
            {
                this._couleur = value;
                RaisePropertyChange("Couleur");
            }
        }
        private Int64 _percentMin;
        [DisplayName("SIM_FIS_CLASSE_DS__PERCENT_MIN")]
        public Int64 PercentMin
        {
            get
            {
                return this._percentMin;
            }
            set
            {
                this._percentMin = value;
                RaisePropertyChange("PercentMin");
            }
        }
        
        private Int64 _percentMax;
        [DisplayName("SIM_FIS_CLASSE_DS__PERCENT_MAX")]
        public Int64 PercentMax
        {
            get
            {
                return this._percentMax;
            }
            set
            {
                this._percentMax = value;
                RaisePropertyChange("PercentMax");
            }
        }
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Id"] != null)
                {
                    errors.Add("SIM_FIS_CLASSE_DS__ID : "+this["Id"]);
                }
                if (this["Couleur"] != null)
                {
                    errors.Add("SIM_FIS_CLASSE_DS__COULEUR : "+this["Couleur"]);
                }
                if (this["PercentMin"] != null)
                {
                    errors.Add("SIM_FIS_CLASSE_DS__PERCENT_MIN : "+this["PercentMin"]);
                }
                if (this["PercentMax"] != null)
                {
                    errors.Add("SIM_FIS_CLASSE_DS__PERCENT_MAX : "+this["PercentMax"]);
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
                if (columnName.Equals("Id"))
                {
                }
                if (columnName.Equals("Couleur"))
                {
                    if (String.IsNullOrEmpty(this.Couleur))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("PercentMin"))
                {
                }
                if (columnName.Equals("PercentMax"))
                {
                }
                return null;
            }
        }
    }
}
