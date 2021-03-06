using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhDscCampViewModel : ViewModelBase<OhDscCamp>
    {
        public OhDscCampViewModel(OhDscCamp model) : base(model)
        {
        }
        public override void Read()
        {
            this.OhDsc=new OhDscViewModel( this.Model.OhDsc);
            this.OhCamp=new OhCampViewModel( this.Model.OhCamp);
            this.Realiser=this.Model.Realiser;
        }
        public override void Write()
        {
            this.Model.OhDsc=this. OhDsc.Model;
            this.Model.OhCamp=this. OhCamp.Model;
            this.Model.Realiser=this.Realiser;
        }
        private OhDscViewModel _ohDsc;
        [DisplayName("Ouvrage Hydraulique")]
        public virtual OhDscViewModel OhDsc
        {
            get
            {
                return this._ohDsc;
            }
            set
            {
                this._ohDsc = value;
                RaisePropertyChange("OhDsc");
            }
        }
        
        private OhCampViewModel _ohCamp;
        [DisplayName("Campagne")]
        public virtual OhCampViewModel OhCamp
        {
            get
            {
                return this._ohCamp;
            }
            set
            {
                this._ohCamp = value;
                RaisePropertyChange("OhCamp");
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
