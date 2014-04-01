using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpCdPortailViewModel : ViewModelBase
    {
        public EqpCdPortail Model {get; set;}
        public EqpCdPortailViewModel(EqpCdPortail model)
        {
            this.EqpDscPos = new  ObservableCollection<EqpDscPoViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.Portail=this.Model.Portail;
            this.Garantie=this.Model.Garantie;
            this.Dvt=this.Model.Dvt;
        }
        public override void Write()
        {
            this.Model.Portail=this.Portail;
            this.Model.Garantie=this.Garantie;
            this.Model.Dvt=this.Dvt;
        }
        public virtual ObservableCollection<EqpDscPoViewModel> EqpDscPos { get; set; }
        
        private String _portail;
        [DisplayName("Portail")]
        public String Portail
        {
            get
            {
                return this._portail;
            }
            set
            {
                this._portail = value;
                RaisePropertyChange("Portail");
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
