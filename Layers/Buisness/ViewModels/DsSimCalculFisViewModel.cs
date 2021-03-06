using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class DsSimCalculFisViewModel : ViewModelBase<DsSimCalculFis>
    {
        public DsSimCalculFisViewModel(DsSimCalculFis model) : base(model)
        {
            this.DsSimResults = new  ObservableCollection<DsSimResultViewModel>();
            
        }
        public override void Read()
        {
            this.DsSimCalculTrafic=new DsSimCalculTraficViewModel( this.Model.DsSimCalculTrafic);
            this.DsSimFis=new DsSimFisViewModel( this.Model.DsSimFis);
        }
        public override void Write()
        {
            this.Model.DsSimCalculTrafic=this. DsSimCalculTrafic.Model;
            this.Model.DsSimFis=this. DsSimFis.Model;
        }
        private DsSimCalculTraficViewModel _dsSimCalculTrafic;
        [DisplayName("SIM_CALCUL_TRAFIC_DS")]
        public virtual DsSimCalculTraficViewModel DsSimCalculTrafic
        {
            get
            {
                return this._dsSimCalculTrafic;
            }
            set
            {
                this._dsSimCalculTrafic = value;
                RaisePropertyChange("DsSimCalculTrafic");
            }
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
        
        public virtual ObservableCollection<DsSimResultViewModel> DsSimResults { get; set; }
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
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
                return null;
            }
        }
    }
}
