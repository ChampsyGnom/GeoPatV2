using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GmsSprtViewModel : ViewModelBase<GmsSprt>
    {
        public GmsSprtViewModel(GmsSprt model) : base(model)
        {
            this.GmsElts = new  ObservableCollection<GmsEltViewModel>();
            
        }
        public override void Read()
        {
            this.GmsPrt=new GmsPrtViewModel( this.Model.GmsPrt);
            this.IdSprt=this.Model.IdSprt;
            this.Libs=this.Model.Libs;
            this.Ordre=this.Model.Ordre;
        }
        public override void Write()
        {
            this.Model.GmsPrt=this. GmsPrt.Model;
            this.Model.IdSprt=this.IdSprt;
            this.Model.Libs=this.Libs;
            this.Model.Ordre=this.Ordre;
        }
        private GmsPrtViewModel _gmsPrt;
        [DisplayName("Partie")]
        public virtual GmsPrtViewModel GmsPrt
        {
            get
            {
                return this._gmsPrt;
            }
            set
            {
                this._gmsPrt = value;
                RaisePropertyChange("GmsPrt");
            }
        }
        
        public virtual ObservableCollection<GmsEltViewModel> GmsElts { get; set; }
        
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
        [DisplayName("Sous partie")]
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
                    errors.Add("Sous partie : "+this["Libs"]);
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
