using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotDscCampViewModel : ViewModelBase
    {
        public GotDscCamp Model {get; set;}
        public GotDscCampViewModel(GotDscCamp model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.GotDsc=new GotDscViewModel( this.Model.GotDsc);
            this.GotCamp=new GotCampViewModel( this.Model.GotCamp);
            this.Realiser=this.Model.Realiser;
        }
        public override void Write()
        {
            this.Model.GotDsc=this. GotDsc.Model;
            this.Model.GotCamp=this. GotCamp.Model;
            this.Model.Realiser=this.Realiser;
        }
        private GotDscViewModel _gotDsc;
        [DisplayName("Terrassement")]
        public virtual GotDscViewModel GotDsc
        {
            get
            {
                return this._gotDsc;
            }
            set
            {
                this._gotDsc = value;
                RaisePropertyChange("GotDsc");
            }
        }
        
        private GotCampViewModel _gotCamp;
        [DisplayName("Campagne")]
        public virtual GotCampViewModel GotCamp
        {
            get
            {
                return this._gotCamp;
            }
            set
            {
                this._gotCamp = value;
                RaisePropertyChange("GotCamp");
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
