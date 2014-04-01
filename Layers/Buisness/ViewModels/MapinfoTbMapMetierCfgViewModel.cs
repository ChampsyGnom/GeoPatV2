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
    }
}
