using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class MapinfoTbModeleCfgViewModel : ViewModelBase<MapinfoTbModeleCfg>
    {
        public MapinfoTbModeleCfgViewModel(MapinfoTbModeleCfg model) : base(model)
        {
        }
        public override void Read()
        {
            this.MapinfoTbModele=new MapinfoTbModeleViewModel( this.Model.MapinfoTbModele);
            this.Usercode=this.Model.Usercode;
            this.CodePrp=this.Model.CodePrp;
            this.ValPrp=this.Model.ValPrp;
        }
        public override void Write()
        {
            this.Model.MapinfoTbModele=this. MapinfoTbModele.Model;
            this.Model.Usercode=this.Usercode;
            this.Model.CodePrp=this.CodePrp;
            this.Model.ValPrp=this.ValPrp;
        }
        private MapinfoTbModeleViewModel _mapinfoTbModele;
        [DisplayName("Modèle")]
        public virtual MapinfoTbModeleViewModel MapinfoTbModele
        {
            get
            {
                return this._mapinfoTbModele;
            }
            set
            {
                this._mapinfoTbModele = value;
                RaisePropertyChange("MapinfoTbModele");
            }
        }
        
        private String _usercode;
        [DisplayName("Utilisateur")]
        public String Usercode
        {
            get
            {
                return this._usercode;
            }
            set
            {
                this._usercode = value;
                RaisePropertyChange("Usercode");
            }
        }
        private String _codePrp;
        [DisplayName("Propriété")]
        public String CodePrp
        {
            get
            {
                return this._codePrp;
            }
            set
            {
                this._codePrp = value;
                RaisePropertyChange("CodePrp");
            }
        }
        private String _valPrp;
        [DisplayName("Valeur")]
        public String ValPrp
        {
            get
            {
                return this._valPrp;
            }
            set
            {
                this._valPrp = value;
                RaisePropertyChange("ValPrp");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Usercode"] != null)
                {
                    errors.Add("Utilisateur : "+this["Usercode"]);
                }
                if (this["CodePrp"] != null)
                {
                    errors.Add("Propriété : "+this["CodePrp"]);
                }
                if (this["ValPrp"] != null)
                {
                    errors.Add("Valeur : "+this["ValPrp"]);
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
                if (columnName.Equals("Usercode"))
                {
                    if (String.IsNullOrEmpty(this.Usercode))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("CodePrp"))
                {
                    if (String.IsNullOrEmpty(this.CodePrp))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("ValPrp"))
                {
                    if (String.IsNullOrEmpty(this.ValPrp))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
