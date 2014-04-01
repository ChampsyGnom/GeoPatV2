using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaTablierViewModel : ViewModelBase<OaTablier>
    {
        public OaTablierViewModel(OaTablier model) : base(model)
        {
            this.OaJoints = new  ObservableCollection<OaJointViewModel>();
            
            this.OaEquipements = new  ObservableCollection<OaEquipementViewModel>();
            
        }
        public override void Read()
        {
            this.OaCdChape=new OaCdChapeViewModel( this.Model.OaCdChape);
            this.OaCdTech=new OaCdTechViewModel( this.Model.OaCdTech);
            this.OaCdEntp=new OaCdEntpViewModel( this.Model.OaCdEntp);
            this.DscOaNumOa=this.Model.DscOaNumOa;
            this.NumTab=this.Model.NumTab;
            this.DateMsChape=this.Model.DateMsChape;
            this.SurfChape=this.Model.SurfChape;
            this.EpaisChape=this.Model.EpaisChape;
            this.DateMsBb=this.Model.DateMsBb;
            this.Epais=this.Model.Epais;
            this.Granulo=this.Model.Granulo;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.OaCdChape=this. OaCdChape.Model;
            this.Model.OaCdTech=this. OaCdTech.Model;
            this.Model.OaCdEntp=this. OaCdEntp.Model;
            this.Model.DscOaNumOa=this.DscOaNumOa;
            this.Model.NumTab=this.NumTab;
            this.Model.DateMsChape=this.DateMsChape;
            this.Model.SurfChape=this.SurfChape;
            this.Model.EpaisChape=this.EpaisChape;
            this.Model.DateMsBb=this.DateMsBb;
            this.Model.Epais=this.Epais;
            this.Model.Granulo=this.Granulo;
            this.Model.Commentaire=this.Commentaire;
        }
        private OaCdChapeViewModel _oaCdChape;
        [DisplayName("Types de chape")]
        public virtual OaCdChapeViewModel OaCdChape
        {
            get
            {
                return this._oaCdChape;
            }
            set
            {
                this._oaCdChape = value;
                RaisePropertyChange("OaCdChape");
            }
        }
        
        private OaCdTechViewModel _oaCdTech;
        [DisplayName("Code Technique")]
        public virtual OaCdTechViewModel OaCdTech
        {
            get
            {
                return this._oaCdTech;
            }
            set
            {
                this._oaCdTech = value;
                RaisePropertyChange("OaCdTech");
            }
        }
        
        private OaCdEntpViewModel _oaCdEntp;
        [DisplayName("Entreprise")]
        public virtual OaCdEntpViewModel OaCdEntp
        {
            get
            {
                return this._oaCdEntp;
            }
            set
            {
                this._oaCdEntp = value;
                RaisePropertyChange("OaCdEntp");
            }
        }
        
        public virtual ObservableCollection<OaJointViewModel> OaJoints { get; set; }
        
        public virtual ObservableCollection<OaEquipementViewModel> OaEquipements { get; set; }
        
        private String _dscOaNumOa;
        [DisplayName("NumOA")]
        public String DscOaNumOa
        {
            get
            {
                return this._dscOaNumOa;
            }
            set
            {
                this._dscOaNumOa = value;
                RaisePropertyChange("DscOaNumOa");
            }
        }
        private Int64 _numTab;
        [DisplayName("N° Tablier")]
        public Int64 NumTab
        {
            get
            {
                return this._numTab;
            }
            set
            {
                this._numTab = value;
                RaisePropertyChange("NumTab");
            }
        }
        
        private Nullable<DateTime> _dateMsChape;
        [DisplayName("Date MS chape")]
        public Nullable<DateTime> DateMsChape
        {
            get
            {
                return this._dateMsChape;
            }
            set
            {
                this._dateMsChape = value;
                RaisePropertyChange("DateMsChape");
            }
        }
        
        private Nullable<Double> _surfChape;
        [DisplayName("Surf chape (m²)")]
        public Nullable<Double> SurfChape
        {
            get
            {
                return this._surfChape;
            }
            set
            {
                this._surfChape = value;
                RaisePropertyChange("SurfChape");
            }
        }
        
        private Nullable<Double> _epaisChape;
        [DisplayName("Epaisseur Chape (cm)")]
        public Nullable<Double> EpaisChape
        {
            get
            {
                return this._epaisChape;
            }
            set
            {
                this._epaisChape = value;
                RaisePropertyChange("EpaisChape");
            }
        }
        
        private Nullable<DateTime> _dateMsBb;
        [DisplayName("Date_MS Enrobé")]
        public Nullable<DateTime> DateMsBb
        {
            get
            {
                return this._dateMsBb;
            }
            set
            {
                this._dateMsBb = value;
                RaisePropertyChange("DateMsBb");
            }
        }
        
        private Nullable<Double> _epais;
        [DisplayName("Epaisseur enrobé(cm)")]
        public Nullable<Double> Epais
        {
            get
            {
                return this._epais;
            }
            set
            {
                this._epais = value;
                RaisePropertyChange("Epais");
            }
        }
        
        private String _granulo;
        [DisplayName("Granulométrie")]
        public String Granulo
        {
            get
            {
                return this._granulo;
            }
            set
            {
                this._granulo = value;
                RaisePropertyChange("Granulo");
            }
        }
        private String _commentaire;
        [DisplayName("Commentaire")]
        public String Commentaire
        {
            get
            {
                return this._commentaire;
            }
            set
            {
                this._commentaire = value;
                RaisePropertyChange("Commentaire");
            }
        }
    }
}
