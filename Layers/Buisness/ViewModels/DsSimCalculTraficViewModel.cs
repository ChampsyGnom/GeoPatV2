using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class DsSimCalculTraficViewModel : ViewModelBase<DsSimCalculTrafic>
    {
        public DsSimCalculTraficViewModel(DsSimCalculTrafic model) : base(model)
        {
            this.DsSimCalculFiss = new  ObservableCollection<DsSimCalculFisViewModel>();
            
        }
        public override void Read()
        {
            this.DsSimDvp=new DsSimDvpViewModel( this.Model.DsSimDvp);
            this.DsSimRec=new DsSimRecViewModel( this.Model.DsSimRec);
            this.DsSimEntretien=new DsSimEntretienViewModel( this.Model.DsSimEntretien);
            this.DsSimCalcul=new DsSimCalculViewModel( this.Model.DsSimCalcul);
            this.Id=this.Model.Id;
            this.Trafic=this.Model.Trafic;
        }
        public override void Write()
        {
            this.Model.DsSimDvp=this. DsSimDvp.Model;
            this.Model.DsSimRec=this. DsSimRec.Model;
            this.Model.DsSimEntretien=this. DsSimEntretien.Model;
            this.Model.DsSimCalcul=this. DsSimCalcul.Model;
            this.Model.Id=this.Id;
            this.Model.Trafic=this.Trafic;
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
        
        private DsSimEntretienViewModel _dsSimEntretien;
        [DisplayName("SIM_ENTRETIEN_DS")]
        public virtual DsSimEntretienViewModel DsSimEntretien
        {
            get
            {
                return this._dsSimEntretien;
            }
            set
            {
                this._dsSimEntretien = value;
                RaisePropertyChange("DsSimEntretien");
            }
        }
        
        private DsSimCalculViewModel _dsSimCalcul;
        [DisplayName("SIM_CALCUL_DS")]
        public virtual DsSimCalculViewModel DsSimCalcul
        {
            get
            {
                return this._dsSimCalcul;
            }
            set
            {
                this._dsSimCalcul = value;
                RaisePropertyChange("DsSimCalcul");
            }
        }
        
        public virtual ObservableCollection<DsSimCalculFisViewModel> DsSimCalculFiss { get; set; }
        
        private Int64 _id;
        [DisplayName("SIM_CALCUL_TRAFIC_DS__ID")]
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
        
        private String _trafic;
        [DisplayName("SIM_CALCUL_TRAFIC_DS__TRAFIC")]
        public String Trafic
        {
            get
            {
                return this._trafic;
            }
            set
            {
                this._trafic = value;
                RaisePropertyChange("Trafic");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Id"] != null)
                {
                    errors.Add("SIM_CALCUL_TRAFIC_DS__ID : "+this["Id"]);
                }
                if (this["Trafic"] != null)
                {
                    errors.Add("SIM_CALCUL_TRAFIC_DS__TRAFIC : "+this["Trafic"]);
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
                if (columnName.Equals("Trafic"))
                {
                    if (String.IsNullOrEmpty(this.Trafic))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
