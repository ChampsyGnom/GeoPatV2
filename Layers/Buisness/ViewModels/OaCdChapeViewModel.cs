using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaCdChapeViewModel : ViewModelBase<OaCdChape>
    {
        public OaCdChapeViewModel(OaCdChape model) : base(model)
        {
            this.OaTabliers = new  ObservableCollection<OaTablierViewModel>();
            
        }
        public override void Read()
        {
            this.Chape=this.Model.Chape;
            this.Garantie=this.Model.Garantie;
            this.Dvt=this.Model.Dvt;
        }
        public override void Write()
        {
            this.Model.Chape=this.Chape;
            this.Model.Garantie=this.Garantie;
            this.Model.Dvt=this.Dvt;
        }
        public virtual ObservableCollection<OaTablierViewModel> OaTabliers { get; set; }
        
        private String _chape;
        [DisplayName("Type chape d'étanchéité")]
        public String Chape
        {
            get
            {
                return this._chape;
            }
            set
            {
                this._chape = value;
                RaisePropertyChange("Chape");
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
