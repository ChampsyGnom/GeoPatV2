using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class DsSimEtudeViewModel : ViewModelBase
    {
        public DsSimEtude Model {get; set;}
        public DsSimEtudeViewModel(DsSimEtude model)
        {
            this.DsSimFiss = new  ObservableCollection<DsSimFisViewModel>();
            
            this.DsSimDvps = new  ObservableCollection<DsSimDvpViewModel>();
            
            this.DsSimRecs = new  ObservableCollection<DsSimRecViewModel>();
            
            this.DsSimEntretiens = new  ObservableCollection<DsSimEntretienViewModel>();
            
            this.DsSimCalculs = new  ObservableCollection<DsSimCalculViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.Id=this.Model.Id;
            this.Libelle=this.Model.Libelle;
            this.AnneeMin=this.Model.AnneeMin;
            this.AnneeMax=this.Model.AnneeMax;
            this.AnneeMinCalcul=this.Model.AnneeMinCalcul;
            this.AnneeMaxCalcul=this.Model.AnneeMaxCalcul;
        }
        public override void Write()
        {
            this.Model.Id=this.Id;
            this.Model.Libelle=this.Libelle;
            this.Model.AnneeMin=this.AnneeMin;
            this.Model.AnneeMax=this.AnneeMax;
            this.Model.AnneeMinCalcul=this.AnneeMinCalcul;
            this.Model.AnneeMaxCalcul=this.AnneeMaxCalcul;
        }
        public virtual ObservableCollection<DsSimFisViewModel> DsSimFiss { get; set; }
        
        public virtual ObservableCollection<DsSimDvpViewModel> DsSimDvps { get; set; }
        
        public virtual ObservableCollection<DsSimRecViewModel> DsSimRecs { get; set; }
        
        public virtual ObservableCollection<DsSimEntretienViewModel> DsSimEntretiens { get; set; }
        
        public virtual ObservableCollection<DsSimCalculViewModel> DsSimCalculs { get; set; }
        
        private Int64 _id;
        [DisplayName("SIM_ETUDE_DS__ID")]
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
        [DisplayName("SIM_ETUDE_DS__LIBELLE")]
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
        private Int64 _anneeMin;
        [DisplayName("SIM_ETUDE_DS__ANNEE_MIN")]
        public Int64 AnneeMin
        {
            get
            {
                return this._anneeMin;
            }
            set
            {
                this._anneeMin = value;
                RaisePropertyChange("AnneeMin");
            }
        }
        
        private Int64 _anneeMax;
        [DisplayName("SIM_ETUDE_DS__ANNEE_MAX")]
        public Int64 AnneeMax
        {
            get
            {
                return this._anneeMax;
            }
            set
            {
                this._anneeMax = value;
                RaisePropertyChange("AnneeMax");
            }
        }
        
        private Int64 _anneeMinCalcul;
        [DisplayName("SIM_ETUDE_DS__ANNEE_MIN_CALCUL")]
        public Int64 AnneeMinCalcul
        {
            get
            {
                return this._anneeMinCalcul;
            }
            set
            {
                this._anneeMinCalcul = value;
                RaisePropertyChange("AnneeMinCalcul");
            }
        }
        
        private Int64 _anneeMaxCalcul;
        [DisplayName("SIM_ETUDE_DS__ANNEE_MAX_CALCUL")]
        public Int64 AnneeMaxCalcul
        {
            get
            {
                return this._anneeMaxCalcul;
            }
            set
            {
                this._anneeMaxCalcul = value;
                RaisePropertyChange("AnneeMaxCalcul");
            }
        }
        
    }
}
