using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnCdTypeqpViewModel : ViewModelBase<BsnCdTypeqp>
    {
        public BsnCdTypeqpViewModel(BsnCdTypeqp model) : base(model)
        {
            this.BsnEquipements = new  ObservableCollection<BsnEquipementViewModel>();
            
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
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Type"] != null)
                {
                    errors.Add("Type EQP : "+this["Type"]);
                }
                if (this["Garantie"] != null)
                {
                    errors.Add("Garantie (mois) : "+this["Garantie"]);
                }
                if (this["Dvt"] != null)
                {
                    errors.Add("Durée de vie (mois) : "+this["Dvt"]);
                }
                if (errors.Count > 0)
                {
                    return String.Join("\r\n",errors);
                }
                else return null;
            }
        }
        public override string this[string columnName]
        {
            get
            {
                if (columnName.Equals("Type"))
                {
                    if (String.IsNullOrEmpty(this.Type))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("Garantie"))
                {
                }
                if (columnName.Equals("Dvt"))
                {
                }
                return null;
            }
        }
    }
}
