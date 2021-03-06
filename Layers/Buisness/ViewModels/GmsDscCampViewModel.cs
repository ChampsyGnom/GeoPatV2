using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GmsDscCampViewModel : ViewModelBase<GmsDscCamp>
    {
        public GmsDscCampViewModel(GmsDscCamp model) : base(model)
        {
        }
        public override void Read()
        {
            this.GmsDsc=new GmsDscViewModel( this.Model.GmsDsc);
            this.GmsCamp=new GmsCampViewModel( this.Model.GmsCamp);
            this.Realiser=this.Model.Realiser;
        }
        public override void Write()
        {
            this.Model.GmsDsc=this. GmsDsc.Model;
            this.Model.GmsCamp=this. GmsCamp.Model;
            this.Model.Realiser=this.Realiser;
        }
        private GmsDscViewModel _gmsDsc;
        [DisplayName("Grand Matériel de Signalisation")]
        public virtual GmsDscViewModel GmsDsc
        {
            get
            {
                return this._gmsDsc;
            }
            set
            {
                this._gmsDsc = value;
                RaisePropertyChange("GmsDsc");
            }
        }
        
        private GmsCampViewModel _gmsCamp;
        [DisplayName("Campagne")]
        public virtual GmsCampViewModel GmsCamp
        {
            get
            {
                return this._gmsCamp;
            }
            set
            {
                this._gmsCamp = value;
                RaisePropertyChange("GmsCamp");
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
