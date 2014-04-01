using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class DsSimEntretienViewModel : ViewModelBase<DsSimEntretien>
    {
        public DsSimEntretienViewModel(DsSimEntretien model) : base(model)
        {
            this.DsSimCalculTrafics = new  ObservableCollection<DsSimCalculTraficViewModel>();
            
        }
        public override void Read()
        {
            this.DsSimEtude=new DsSimEtudeViewModel( this.Model.DsSimEtude);
            this.Id=this.Model.Id;
            this.Age=this.Model.Age;
            this.Epaisseur=this.Model.Epaisseur;
            this.Libelle=this.Model.Libelle;
            this.Couleur=this.Model.Couleur;
        }
        public override void Write()
        {
            this.Model.DsSimEtude=this. DsSimEtude.Model;
            this.Model.Id=this.Id;
            this.Model.Age=this.Age;
            this.Model.Epaisseur=this.Epaisseur;
            this.Model.Libelle=this.Libelle;
            this.Model.Couleur=this.Couleur;
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
        [DisplayName("SIM_ENTRETIEN_DS__ID")]
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
        
        private Int64 _age;
        [DisplayName("SIM_ENTRETIEN_DS__AGE")]
        public Int64 Age
        {
            get
            {
                return this._age;
            }
            set
            {
                this._age = value;
                RaisePropertyChange("Age");
            }
        }
        
        private Nullable<Double> _epaisseur;
        [DisplayName("SIM_ENTRETIEN_DS__EPAISSEUR")]
        public Nullable<Double> Epaisseur
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
        
        private String _libelle;
        [DisplayName("SIM_ENTRETIEN_DS__LIBELLE")]
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
        [DisplayName("SIM_ENTRETIEN_DS__COULEUR")]
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
    }
}
