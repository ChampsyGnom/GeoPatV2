using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhEnteteViewModel : ViewModelBase<OhEntete>
    {
        public OhEnteteViewModel(OhEntete model) : base(model)
        {
        }
        public override void Read()
        {
            this.OhCdEntete=new OhCdEnteteViewModel( this.Model.OhCdEntete);
            this.OhVst=new OhVstViewModel( this.Model.OhVst);
            this.Valeur=this.Model.Valeur;
        }
        public override void Write()
        {
            this.Model.OhCdEntete=this. OhCdEntete.Model;
            this.Model.OhVst=this. OhVst.Model;
            this.Model.Valeur=this.Valeur;
        }
        private OhCdEnteteViewModel _ohCdEntete;
        [DisplayName("Entête")]
        public virtual OhCdEnteteViewModel OhCdEntete
        {
            get
            {
                return this._ohCdEntete;
            }
            set
            {
                this._ohCdEntete = value;
                RaisePropertyChange("OhCdEntete");
            }
        }
        
        private OhVstViewModel _ohVst;
        [DisplayName("Visite")]
        public virtual OhVstViewModel OhVst
        {
            get
            {
                return this._ohVst;
            }
            set
            {
                this._ohVst = value;
                RaisePropertyChange("OhVst");
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
