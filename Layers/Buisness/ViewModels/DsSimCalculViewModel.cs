using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class DsSimCalculViewModel : ViewModelBase<DsSimCalcul>
    {
        public DsSimCalculViewModel(DsSimCalcul model) : base(model)
        {
            this.DsSimCalculTrafics = new  ObservableCollection<DsSimCalculTraficViewModel>();
            
        }
        public override void Read()
        {
            this.DsSimEtude=new DsSimEtudeViewModel( this.Model.DsSimEtude);
            this.Id=this.Model.Id;
            this.Libelle=this.Model.Libelle;
            this.Comment=this.Model.Comment;
        }
        public override void Write()
        {
            this.Model.DsSimEtude=this. DsSimEtude.Model;
            this.Model.Id=this.Id;
            this.Model.Libelle=this.Libelle;
            this.Model.Comment=this.Comment;
        }
        private DsSimEtudeViewModel _dsSimEtude;
        [DisplayName("SIM_ETUDE_DS")]
        public virtual DsSimEtudeViewModel DsSimEtude
        {
            get
            {
                return this._dsSimEtude;
            }
            set
            {
                this._dsSimEtude = value;
                RaisePropertyChange("DsSimEtude");
            }
        }
        
        public virtual ObservableCollection<DsSimCalculTraficViewModel> DsSimCalculTrafics { get; set; }
        
        private Int64 _id;
        [DisplayName("SIM_CALCUL_DS__ID")]
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
        
        private String _libelle;
        [DisplayName("SIM_CALCUL_DS__LIBELLE")]
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
        private String _comment;
        [DisplayName("SIM_CALCUL_DS__COMMENT")]
        public String Comment
        {
            get
            {
                return this._comment;
            }
            set
            {
                this._comment = value;
                RaisePropertyChange("Comment");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Id"] != null)
                {
                    errors.Add("SIM_CALCUL_DS__ID : "+this["Id"]);
                }
                if (this["Libelle"] != null)
                {
                    errors.Add("SIM_CALCUL_DS__LIBELLE : "+this["Libelle"]);
                }
                if (this["Comment"] != null)
                {
                    errors.Add("SIM_CALCUL_DS__COMMENT : "+this["Comment"]);
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
                if (columnName.Equals("Libelle"))
                {
                }
                if (columnName.Equals("Comment"))
                {
                }
                return null;
            }
        }
    }
}
