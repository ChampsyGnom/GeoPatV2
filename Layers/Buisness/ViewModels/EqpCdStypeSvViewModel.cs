using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpCdStypeSvViewModel : ViewModelBase
    {
        public EqpCdStypeSv Model {get; set;}
        public EqpCdStypeSvViewModel(EqpCdStypeSv model)
        {
            this.EqpPanneaus = new  ObservableCollection<EqpPanneauViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.EqpCdTypeSv=new EqpCdTypeSvViewModel( this.Model.EqpCdTypeSv);
            this.SType=this.Model.SType;
            this.Libelle=this.Model.Libelle;
            this.NOrdre=this.Model.NOrdre;
        }
        public override void Write()
        {
            this.Model.EqpCdTypeSv=this. EqpCdTypeSv.Model;
            this.Model.SType=this.SType;
            this.Model.Libelle=this.Libelle;
            this.Model.NOrdre=this.NOrdre;
        }
        private EqpCdTypeSvViewModel _eqpCdTypeSv;
        [DisplayName("Type Ouvrage")]
        public virtual EqpCdTypeSvViewModel EqpCdTypeSv
        {
            get
            {
                return this._eqpCdTypeSv;
            }
            set
            {
                this._eqpCdTypeSv = value;
                RaisePropertyChange("EqpCdTypeSv");
            }
        }
        
        public virtual ObservableCollection<EqpPanneauViewModel> EqpPanneaus { get; set; }
        
        private String _sType;
        [DisplayName("Sous type")]
        public String SType
        {
            get
            {
                return this._sType;
            }
            set
            {
                this._sType = value;
                RaisePropertyChange("SType");
            }
        }
        private String _libelle;
        [DisplayName("Libellé")]
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
        private Int64 _nOrdre;
        [DisplayName("Num Ordre")]
        public Int64 NOrdre
        {
            get
            {
                return this._nOrdre;
            }
            set
            {
                this._nOrdre = value;
                RaisePropertyChange("NOrdre");
            }
        }
        
    }
}
