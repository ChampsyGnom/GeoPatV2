using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotEnteteViewModel : ViewModelBase<GotEntete>
    {
        public GotEnteteViewModel(GotEntete model) : base(model)
        {
        }
        public override void Read()
        {
            this.GotCdEntete=new GotCdEnteteViewModel( this.Model.GotCdEntete);
            this.GotVst=new GotVstViewModel( this.Model.GotVst);
            this.Valeur=this.Model.Valeur;
        }
        public override void Write()
        {
            this.Model.GotCdEntete=this. GotCdEntete.Model;
            this.Model.GotVst=this. GotVst.Model;
            this.Model.Valeur=this.Valeur;
        }
        private GotCdEnteteViewModel _gotCdEntete;
        [DisplayName("Entête")]
        public virtual GotCdEnteteViewModel GotCdEntete
        {
            get
            {
                return this._gotCdEntete;
            }
            set
            {
                this._gotCdEntete = value;
                RaisePropertyChange("GotCdEntete");
            }
        }
        
        private GotVstViewModel _gotVst;
        [DisplayName("Visite")]
        public virtual GotVstViewModel GotVst
        {
            get
            {
                return this._gotVst;
            }
            set
            {
                this._gotVst = value;
                RaisePropertyChange("GotVst");
            }
        }
        
        private String _valeur;
        [DisplayName("Valeur")]
        public String Valeur
        {
            get
            {
                return this._valeur;
            }
            set
            {
                this._valeur = value;
                RaisePropertyChange("Valeur");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Valeur"] != null)
                {
                    errors.Add("Valeur : "+this["Valeur"]);
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
                if (columnName.Equals("Valeur"))
                {
                }
                return null;
            }
        }
    }
}
