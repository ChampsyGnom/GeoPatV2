using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class DsSimRecViewModel : ViewModelBase<DsSimRec>
    {
        public DsSimRecViewModel(DsSimRec model) : base(model)
        {
            this.DsSimCalculTrafics = new  ObservableCollection<DsSimCalculTraficViewModel>();
            
            this.DsSimRecValuess = new  ObservableCollection<DsSimRecValuesViewModel>();
            
        }
        public override void Read()
        {
            this.DsSimEtude=new DsSimEtudeViewModel( this.Model.DsSimEtude);
            this.Id=this.Model.Id;
            this.Libelle=this.Model.Libelle;
            this.Couleur=this.Model.Couleur;
            this.DurreeService=this.Model.DurreeService;
        }
        public override void Write()
        {
            this.Model.DsSimEtude=this. DsSimEtude.Model;
            this.Model.Id=this.Id;
            this.Model.Libelle=this.Libelle;
            this.Model.Couleur=this.Couleur;
            this.Model.DurreeService=this.DurreeService;
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
        
        public virtual ObservableCollection<DsSimRecValuesViewModel> DsSimRecValuess { get; set; }
        
        private Int64 _id;
        [DisplayName("SIM_REC_DS__ID")]
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
        [DisplayName("SIM_REC_DS__LIBELLE")]
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
        private String _couleur;
        [DisplayName("SIM_REC_DS__COULEUR")]
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
        private Int64 _durreeService;
        [DisplayName("SIM_REC_DS__DURREE_SERVICE")]
        public Int64 DurreeService
        {
            get
            {
                return this._durreeService;
            }
            set
            {
                this._durreeService = value;
                RaisePropertyChange("DurreeService");
            }
        }
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Id"] != null)
                {
                    errors.Add("SIM_REC_DS__ID : "+this["Id"]);
                }
                if (this["Libelle"] != null)
                {
                    errors.Add("SIM_REC_DS__LIBELLE : "+this["Libelle"]);
                }
                if (this["Couleur"] != null)
                {
                    errors.Add("SIM_REC_DS__COULEUR : "+this["Couleur"]);
                }
                if (this["DurreeService"] != null)
                {
                    errors.Add("SIM_REC_DS__DURREE_SERVICE : "+this["DurreeService"]);
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
                if (columnName.Equals("Couleur"))
                {
                    if (String.IsNullOrEmpty(this.Couleur))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("DurreeService"))
                {
                }
                return null;
            }
        }
    }
}
