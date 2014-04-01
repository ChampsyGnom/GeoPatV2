using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class DsSimFisClasseViewModel : ViewModelBase
    {
        public DsSimFisClasse Model {get; set;}
        public DsSimFisClasseViewModel(DsSimFisClasse model)
        {
            this.DsSimFisValuess = new  ObservableCollection<DsSimFisValuesViewModel>();
            
            this.Model = model;
            this.Read();
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
        
    }
}
