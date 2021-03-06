using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnSprtViewModel : ViewModelBase<BsnSprt>
    {
        public BsnSprtViewModel(BsnSprt model) : base(model)
        {
            this.BsnElts = new  ObservableCollection<BsnEltViewModel>();
            
        }
        public override void Read()
        {
            this.BsnPrt=new BsnPrtViewModel( this.Model.BsnPrt);
            this.IdSprt=this.Model.IdSprt;
            this.Libs=this.Model.Libs;
            this.Ordre=this.Model.Ordre;
        }
        public override void Write()
        {
            this.Model.BsnPrt=this. BsnPrt.Model;
            this.Model.IdSprt=this.IdSprt;
            this.Model.Libs=this.Libs;
            this.Model.Ordre=this.Ordre;
        }
        private BsnPrtViewModel _bsnPrt;
        [DisplayName("Partie")]
        public virtual BsnPrtViewModel BsnPrt
        {
            get
            {
                return this._bsnPrt;
            }
            set
            {
                this._bsnPrt = value;
                RaisePropertyChange("BsnPrt");
            }
        }
        
        public virtual ObservableCollection<BsnEltViewModel> BsnElts { get; set; }
        
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
