using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnPrtViewModel : ViewModelBase<BsnPrt>
    {
        public BsnPrtViewModel(BsnPrt model) : base(model)
        {
            this.BsnSprts = new  ObservableCollection<BsnSprtViewModel>();
            
        }
        public override void Read()
        {
            this.BsnGrp=new BsnGrpViewModel( this.Model.BsnGrp);
            this.IdPrt=this.Model.IdPrt;
            this.Libp=this.Model.Libp;
            this.Ordre=this.Model.Ordre;
        }
        public override void Write()
        {
            this.Model.BsnGrp=this. BsnGrp.Model;
            this.Model.IdPrt=this.IdPrt;
            this.Model.Libp=this.Libp;
            this.Model.Ordre=this.Ordre;
        }
        private BsnGrpViewModel _bsnGrp;
        [DisplayName("Groupe")]
        public virtual BsnGrpViewModel BsnGrp
        {
            get
            {
                return this._bsnGrp;
            }
            set
            {
                this._bsnGrp = value;
                RaisePropertyChange("BsnGrp");
            }
        }
        
        public virtual ObservableCollection<BsnSprtViewModel> BsnSprts { get; set; }
        
        private Int64 _idPrt;
        [DisplayName("Identifiant Partie")]
        public Int64 IdPrt
        {
            get
            {
                return this._idPrt;
            }
            set
            {
                this._idPrt = value;
                RaisePropertyChange("IdPrt");
            }
        }
        
        private String _libp;
        [DisplayName("Partie")]
        public String Libp
        {
            get
            {
                return this._libp;
            }
            set
            {
                this._libp = value;
                RaisePropertyChange("Libp");
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
                if (this["IdPrt"] != null)
                {
                    errors.Add("Identifiant Partie : "+this["IdPrt"]);
                }
                if (this["Libp"] != null)
                {
                    errors.Add("Partie : "+this["Libp"]);
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
                if (columnName.Equals("IdPrt"))
                {
                }
                if (columnName.Equals("Libp"))
                {
                    if (String.IsNullOrEmpty(this.Libp))
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
