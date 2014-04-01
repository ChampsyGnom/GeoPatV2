using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnGeometrieViewModel : ViewModelBase
    {
        public BsnGeometrie Model {get; set;}
        public BsnGeometrieViewModel(BsnGeometrie model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.BsnDsc=new BsnDscViewModel( this.Model.BsnDsc);
            this.Surf=this.Model.Surf;
            this.Prof=this.Model.Prof;
            this.Pente=this.Model.Pente;
            this.Perimetre=this.Model.Perimetre;
        }
        public override void Write()
        {
            this.Model.BsnDsc=this. BsnDsc.Model;
            this.Model.Surf=this.Surf;
            this.Model.Prof=this.Prof;
            this.Model.Pente=this.Pente;
            this.Model.Perimetre=this.Perimetre;
        }
        private BsnDscViewModel _bsnDsc;
        [DisplayName("Bassin")]
        public virtual BsnDscViewModel BsnDsc
        {
            get
            {
                return this._bsnDsc;
            }
            set
            {
                this._bsnDsc = value;
                RaisePropertyChange("BsnDsc");
            }
        }
        
        private Nullable<Double> _surf;
        [DisplayName("Surf. Bassin (m²)")]
        public Nullable<Double> Surf
        {
            get
            {
                return this._surf;
            }
            set
            {
                this._surf = value;
                RaisePropertyChange("Surf");
            }
        }
        
        private Nullable<Double> _prof;
        [DisplayName("Prof. Bassin (m)")]
        public Nullable<Double> Prof
        {
            get
            {
                return this._prof;
            }
            set
            {
                this._prof = value;
                RaisePropertyChange("Prof");
            }
        }
        
        private Nullable<Double> _pente;
        [DisplayName("Pente Talus (%)")]
        public Nullable<Double> Pente
        {
            get
            {
                return this._pente;
            }
            set
            {
                this._pente = value;
                RaisePropertyChange("Pente");
            }
        }
        
        private Nullable<Double> _perimetre;
        [DisplayName("Périmètre clôture (m)")]
        public Nullable<Double> Perimetre
        {
            get
            {
                return this._perimetre;
            }
            set
            {
                this._perimetre = value;
                RaisePropertyChange("Perimetre");
            }
        }
        
    }
}
