using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaEnteteViewModel : ViewModelBase<OaEntete>
    {
        public OaEnteteViewModel(OaEntete model) : base(model)
        {
        }
        public override void Read()
        {
            this.OaCdEntete=new OaCdEnteteViewModel( this.Model.OaCdEntete);
            this.OaVst=new OaVstViewModel( this.Model.OaVst);
            this.Valeur=this.Model.Valeur;
        }
        public override void Write()
        {
            this.Model.OaCdEntete=this. OaCdEntete.Model;
            this.Model.OaVst=this. OaVst.Model;
            this.Model.Valeur=this.Valeur;
        }
        private OaCdEnteteViewModel _oaCdEntete;
        [DisplayName("Entête")]
        public virtual OaCdEnteteViewModel OaCdEntete
        {
            get
            {
                return this._oaCdEntete;
            }
            set
            {
                this._oaCdEntete = value;
                RaisePropertyChange("OaCdEntete");
            }
        }
        
        private OaVstViewModel _oaVst;
        [DisplayName("Visite")]
        public virtual OaVstViewModel OaVst
        {
            get
            {
                return this._oaVst;
            }
            set
            {
                this._oaVst = value;
                RaisePropertyChange("OaVst");
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
