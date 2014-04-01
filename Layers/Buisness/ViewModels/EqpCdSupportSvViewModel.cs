using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpCdSupportSvViewModel : ViewModelBase
    {
        public EqpCdSupportSv Model {get; set;}
        public EqpCdSupportSvViewModel(EqpCdSupportSv model)
        {
            this.EqpDscSvs = new  ObservableCollection<EqpDscSvViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.Support=this.Model.Support;
            this.Garantie=this.Model.Garantie;
            this.Dvt=this.Model.Dvt;
        }
        public override void Write()
        {
            this.Model.Support=this.Support;
            this.Model.Garantie=this.Garantie;
            this.Model.Dvt=this.Dvt;
        }
        public virtual ObservableCollection<EqpDscSvViewModel> EqpDscSvs { get; set; }
        
        private String _support;
        [DisplayName("Type support")]
        public String Support
        {
            get
            {
                return this._support;
            }
            set
            {
                this._support = value;
                RaisePropertyChange("Support");
            }
        }
        private Nullable<Int64> _garantie;
        [DisplayName("Garantie")]
        public Nullable<Int64> Garantie
        {
            get
            {
                return this._garantie;
            }
            set
            {
                this._garantie = value;
                RaisePropertyChange("Garantie");
            }
        }
        
        private Nullable<Int64> _dvt;
        [DisplayName("Durée de vie (mois)")]
        public Nullable<Int64> Dvt
        {
            get
            {
                return this._dvt;
            }
            set
            {
                this._dvt = value;
                RaisePropertyChange("Dvt");
            }
        }
        
    }
}
