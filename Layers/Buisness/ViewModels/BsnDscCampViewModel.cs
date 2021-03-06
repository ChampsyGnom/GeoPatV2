using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnDscCampViewModel : ViewModelBase<BsnDscCamp>
    {
        public BsnDscCampViewModel(BsnDscCamp model) : base(model)
        {
        }
        public override void Read()
        {
            this.BsnDsc=new BsnDscViewModel( this.Model.BsnDsc);
            this.BsnCamp=new BsnCampViewModel( this.Model.BsnCamp);
            this.Realiser=this.Model.Realiser;
        }
        public override void Write()
        {
            this.Model.BsnDsc=this. BsnDsc.Model;
            this.Model.BsnCamp=this. BsnCamp.Model;
            this.Model.Realiser=this.Realiser;
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
        
        private BsnCampViewModel _bsnCamp;
        [DisplayName("Campagne")]
        public virtual BsnCampViewModel BsnCamp
        {
            get
            {
                return this._bsnCamp;
            }
            set
            {
                this._bsnCamp = value;
                RaisePropertyChange("BsnCamp");
            }
        }
        
        private Nullable<Boolean> _realiser;
        [DisplayName("Contrôle Réalisé")]
        public Nullable<Boolean> Realiser
        {
            get
            {
                return this._realiser;
            }
            set
            {
                this._realiser = value;
                RaisePropertyChange("Realiser");
            }
        }
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Realiser"] != null)
                {
                    errors.Add("Contrôle Réalisé : "+this["Realiser"]);
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
                if (columnName.Equals("Realiser"))
                {
                }
                return null;
            }
        }
    }
}
