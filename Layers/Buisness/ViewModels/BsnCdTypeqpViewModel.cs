using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnCdTypeqpViewModel : ViewModelBase
    {
        public BsnCdTypeqp Model {get; set;}
        public BsnCdTypeqpViewModel(BsnCdTypeqp model)
        {
            this.BsnEquipements = new  ObservableCollection<BsnEquipementViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.BsnCdFameqp=new BsnCdFameqpViewModel( this.Model.BsnCdFameqp);
            this.Type=this.Model.Type;
            this.Garantie=this.Model.Garantie;
            this.Dvt=this.Model.Dvt;
        }
        public override void Write()
        {
            this.Model.BsnCdFameqp=this. BsnCdFameqp.Model;
            this.Model.Type=this.Type;
            this.Model.Garantie=this.Garantie;
            this.Model.Dvt=this.Dvt;
        }
        private BsnCdFameqpViewModel _bsnCdFameqp;
        [DisplayName("Famille Equipement")]
        public virtual BsnCdFameqpViewModel BsnCdFameqp
        {
            get
            {
                return this._bsnCdFameqp;
            }
            set
            {
                this._bsnCdFameqp = value;
                RaisePropertyChange("BsnCdFameqp");
            }
        }
        
        public virtual ObservableCollection<BsnEquipementViewModel> BsnEquipements { get; set; }
        
        private String _type;
        [DisplayName("Type EQP")]
        public String Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
                RaisePropertyChange("Type");
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
