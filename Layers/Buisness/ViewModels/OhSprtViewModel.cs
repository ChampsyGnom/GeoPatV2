using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhSprtViewModel : ViewModelBase<OhSprt>
    {
        public OhSprtViewModel(OhSprt model) : base(model)
        {
            this.OhElts = new  ObservableCollection<OhEltViewModel>();
            
        }
        public override void Read()
        {
            this.OhPrt=new OhPrtViewModel( this.Model.OhPrt);
            this.IdSprt=this.Model.IdSprt;
            this.Libs=this.Model.Libs;
            this.Ordre=this.Model.Ordre;
        }
        public override void Write()
        {
            this.Model.OhPrt=this. OhPrt.Model;
            this.Model.IdSprt=this.IdSprt;
            this.Model.Libs=this.Libs;
            this.Model.Ordre=this.Ordre;
        }
        private OhPrtViewModel _ohPrt;
        [DisplayName("Partie")]
        public virtual OhPrtViewModel OhPrt
        {
            get
            {
                return this._ohPrt;
            }
            set
            {
                this._ohPrt = value;
                RaisePropertyChange("OhPrt");
            }
        }
        
        public virtual ObservableCollection<OhEltViewModel> OhElts { get; set; }
        
        private Int64 _idSprt;
        [DisplayName("Identifiant Sous Partie")]
        public Int64 IdSprt
        {
            get
            {
                return this._idSprt;
            }
            set
            {
                this._idSprt = value;
                RaisePropertyChange("IdSprt");
            }
        }
        
        private String _libs;
        [DisplayName("Sous Partie")]
        public String Libs
        {
            get
            {
                return this._libs;
            }
            set
            {
                this._libs = value;
                RaisePropertyChange("Libs");
            }
        }
        private Int64 _ordre;
        [DisplayName("N° Ordre")]
        public Int64 Ordre
        {
            get
            {
                return this._ordre;
            }
            set
            {
                this._ordre = value;
                RaisePropertyChange("Ordre");
            }
        }
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["IdSprt"] != null)
                {
                    errors.Add("Identifiant Sous Partie : "+this["IdSprt"]);
                }
                if (this["Libs"] != null)
                {
                    errors.Add("Sous Partie : "+this["Libs"]);
                }
                if (this["Ordre"] != null)
                {
                    errors.Add("N° Ordre : "+this["Ordre"]);
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
                if (columnName.Equals("IdSprt"))
                {
                }
                if (columnName.Equals("Libs"))
                {
                    if (String.IsNullOrEmpty(this.Libs))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("Ordre"))
                {
                }
                return null;
            }
        }
    }
}
