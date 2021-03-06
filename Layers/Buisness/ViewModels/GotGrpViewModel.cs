using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotGrpViewModel : ViewModelBase<GotGrp>
    {
        public GotGrpViewModel(GotGrp model) : base(model)
        {
            this.GotPrts = new  ObservableCollection<GotPrtViewModel>();
            
        }
        public override void Read()
        {
            this.IdGrp=this.Model.IdGrp;
            this.Libg=this.Model.Libg;
            this.Ordre=this.Model.Ordre;
        }
        public override void Write()
        {
            this.Model.IdGrp=this.IdGrp;
            this.Model.Libg=this.Libg;
            this.Model.Ordre=this.Ordre;
        }
        public virtual ObservableCollection<GotPrtViewModel> GotPrts { get; set; }
        
        private Int64 _idGrp;
        [DisplayName("Identifiant Groupe")]
        public Int64 IdGrp
        {
            get
            {
                return this._idGrp;
            }
            set
            {
                this._idGrp = value;
                RaisePropertyChange("IdGrp");
            }
        }
        
        private String _libg;
        [DisplayName("Groupe")]
        public String Libg
        {
            get
            {
                return this._libg;
            }
            set
            {
                this._libg = value;
                RaisePropertyChange("Libg");
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
                if (this["IdGrp"] != null)
                {
                    errors.Add("Identifiant Groupe : "+this["IdGrp"]);
                }
                if (this["Libg"] != null)
                {
                    errors.Add("Groupe : "+this["Libg"]);
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
                if (columnName.Equals("IdGrp"))
                {
                }
                if (columnName.Equals("Libg"))
                {
                    if (String.IsNullOrEmpty(this.Libg))
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
