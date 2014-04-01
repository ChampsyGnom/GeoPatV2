using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaCdDprViewModel : ViewModelBase
    {
        public OaCdDpr Model {get; set;}
        public OaCdDprViewModel(OaCdDpr model)
        {
            this.OaEquipements = new  ObservableCollection<OaEquipementViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.Dpr=this.Model.Dpr;
            this.Garantie=this.Model.Garantie;
            this.Dvt=this.Model.Dvt;
        }
        public override void Write()
        {
            this.Model.Dpr=this.Dpr;
            this.Model.Garantie=this.Garantie;
            this.Model.Dvt=this.Dvt;
        }
        public virtual ObservableCollection<OaEquipementViewModel> OaEquipements { get; set; }
        
        private String _dpr;
        [DisplayName("Dispositif de retenue")]
        public String Dpr
        {
            get
            {
                return this._dpr;
            }
            set
            {
                this._dpr = value;
                RaisePropertyChange("Dpr");
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
