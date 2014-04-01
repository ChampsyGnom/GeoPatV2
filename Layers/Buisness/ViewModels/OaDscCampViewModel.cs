using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaDscCampViewModel : ViewModelBase
    {
        public OaDscCamp Model {get; set;}
        public OaDscCampViewModel(OaDscCamp model)
        {
            this.Model = model;
            this.Read();
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
        
    }
}
