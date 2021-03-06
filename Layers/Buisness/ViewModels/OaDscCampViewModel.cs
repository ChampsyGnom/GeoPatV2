using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaDscCampViewModel : ViewModelBase<OaDscCamp>
    {
        public OaDscCampViewModel(OaDscCamp model) : base(model)
        {
        }
        public override void Read()
        {
            this.OaDsc=new OaDscViewModel( this.Model.OaDsc);
            this.OaCamp=new OaCampViewModel( this.Model.OaCamp);
            this.Realiser=this.Model.Realiser;
        }
        public override void Write()
        {
            this.Model.OaDsc=this. OaDsc.Model;
            this.Model.OaCamp=this. OaCamp.Model;
            this.Model.Realiser=this.Realiser;
        }
        private OaDscViewModel _oaDsc;
        [DisplayName("Ouvrages d'Art")]
        public virtual OaDscViewModel OaDsc
        {
            get
            {
                return this._oaDsc;
            }
            set
            {
                this._oaDsc = value;
                RaisePropertyChange("OaDsc");
            }
        }
        
        private OaCampViewModel _oaCamp;
        [DisplayName("Campagne")]
        public virtual OaCampViewModel OaCamp
        {
            get
            {
                return this._oaCamp;
            }
            set
            {
                this._oaCamp = value;
                RaisePropertyChange("OaCamp");
            }
        }
        
        private Nullable<Boolean> _realiser;
        [DisplayName("Contrôle réalisé")]
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
                    errors.Add("Contrôle réalisé : "+this["Realiser"]);
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
