using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpCdClotureViewModel : ViewModelBase<EqpCdCloture>
    {
        public EqpCdClotureViewModel(EqpCdCloture model) : base(model)
        {
            this.EqpDscCls = new  ObservableCollection<EqpDscClViewModel>();
            
        }
        public override void Read()
        {
            this.Cloture=this.Model.Cloture;
            this.Garantie=this.Model.Garantie;
            this.Dvt=this.Model.Dvt;
        }
        public override void Write()
        {
            this.Model.Cloture=this.Cloture;
            this.Model.Garantie=this.Garantie;
            this.Model.Dvt=this.Dvt;
        }
        public virtual ObservableCollection<EqpDscClViewModel> EqpDscCls { get; set; }
        
        private String _cloture;
        [DisplayName("Clôture")]
        public String Cloture
        {
            get
            {
                return this._cloture;
            }
            set
            {
                this._cloture = value;
                RaisePropertyChange("Cloture");
            }
        }
        private Nullable<Int64> _garantie;
        [DisplayName("Garantie (mois)")]
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
