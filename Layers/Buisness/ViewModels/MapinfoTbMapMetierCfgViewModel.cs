using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class MapinfoTbMapMetierCfgViewModel : ViewModelBase<MapinfoTbMapMetierCfg>
    {
        public MapinfoTbMapMetierCfgViewModel(MapinfoTbMapMetierCfg model) : base(model)
        {
        }
        public override void Read()
        {
            this.MapinfoTbMapMetier=new MapinfoTbMapMetierViewModel( this.Model.MapinfoTbMapMetier);
            this.Usercode=this.Model.Usercode;
            this.CodePrp=this.Model.CodePrp;
            this.ValPrp=this.Model.ValPrp;
        }
        public override void Write()
        {
            this.Model.MapinfoTbMapMetier=this. MapinfoTbMapMetier.Model;
            this.Model.Usercode=this.Usercode;
            this.Model.CodePrp=this.CodePrp;
            this.Model.ValPrp=this.ValPrp;
        }
        private MapinfoTbMapMetierViewModel _mapinfoTbMapMetier;
        [DisplayName("Tb Map Metier")]
        public virtual MapinfoTbMapMetierViewModel MapinfoTbMapMetier
        {
            get
            {
                return this._mapinfoTbMapMetier;
            }
            set
            {
                this._mapinfoTbMapMetier = value;
                RaisePropertyChange("MapinfoTbMapMetier");
            }
        }
        
        private String _usercode;
        [DisplayName("Tb Map Metier Cfg  Usercode")]
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
        [DisplayName("Tb Map Metier Cfg  Code Prp")]
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
        [DisplayName("Tb Map Metier Cfg  Val Prp")]
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
                    errors.Add("Tb Map Metier Cfg  Usercode : "+this["Usercode"]);
                }
                if (this["CodePrp"] != null)
                {
                    errors.Add("Tb Map Metier Cfg  Code Prp : "+this["CodePrp"]);
                }
                if (this["ValPrp"] != null)
                {
                    errors.Add("Tb Map Metier Cfg  Val Prp : "+this["ValPrp"]);
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
