using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GmsEnteteViewModel : ViewModelBase<GmsEntete>
    {
        public GmsEnteteViewModel(GmsEntete model) : base(model)
        {
        }
        public override void Read()
        {
            this.GmsCdEntete=new GmsCdEnteteViewModel( this.Model.GmsCdEntete);
            this.GmsVst=new GmsVstViewModel( this.Model.GmsVst);
            this.Valeur=this.Model.Valeur;
        }
        public override void Write()
        {
            this.Model.GmsCdEntete=this. GmsCdEntete.Model;
            this.Model.GmsVst=this. GmsVst.Model;
            this.Model.Valeur=this.Valeur;
        }
        private GmsCdEnteteViewModel _gmsCdEntete;
        [DisplayName("Entête")]
        public virtual GmsCdEnteteViewModel GmsCdEntete
        {
            get
            {
                return this._gmsCdEntete;
            }
            set
            {
                this._gmsCdEntete = value;
                RaisePropertyChange("GmsCdEntete");
            }
        }
        
        private GmsVstViewModel _gmsVst;
        [DisplayName("Visite")]
        public virtual GmsVstViewModel GmsVst
        {
            get
            {
                return this._gmsVst;
            }
            set
            {
                this._gmsVst = value;
                RaisePropertyChange("GmsVst");
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
