using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnEnteteViewModel : ViewModelBase<BsnEntete>
    {
        public BsnEnteteViewModel(BsnEntete model) : base(model)
        {
        }
        public override void Read()
        {
            this.BsnCdEntete=new BsnCdEnteteViewModel( this.Model.BsnCdEntete);
            this.BsnVst=new BsnVstViewModel( this.Model.BsnVst);
            this.Valeur=this.Model.Valeur;
        }
        public override void Write()
        {
            this.Model.BsnCdEntete=this. BsnCdEntete.Model;
            this.Model.BsnVst=this. BsnVst.Model;
            this.Model.Valeur=this.Valeur;
        }
        private BsnCdEnteteViewModel _bsnCdEntete;
        [DisplayName("Entête")]
        public virtual BsnCdEnteteViewModel BsnCdEntete
        {
            get
            {
                return this._bsnCdEntete;
            }
            set
            {
                this._bsnCdEntete = value;
                RaisePropertyChange("BsnCdEntete");
            }
        }
        
        private BsnVstViewModel _bsnVst;
        [DisplayName("Visite")]
        public virtual BsnVstViewModel BsnVst
        {
            get
            {
                return this._bsnVst;
            }
            set
            {
                this._bsnVst = value;
                RaisePropertyChange("BsnVst");
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
