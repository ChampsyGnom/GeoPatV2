using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class MapinfoTbGroupeCfgViewModel : ViewModelBase
    {
        public MapinfoTbGroupeCfg Model {get; set;}
        public MapinfoTbGroupeCfgViewModel(MapinfoTbGroupeCfg model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.MapinfoTbGroupe=new MapinfoTbGroupeViewModel( this.Model.MapinfoTbGroupe);
            this.Usercode=this.Model.Usercode;
            this.CodePrp=this.Model.CodePrp;
            this.ValPrp=this.Model.ValPrp;
        }
        public override void Write()
        {
            this.Model.MapinfoTbGroupe=this. MapinfoTbGroupe.Model;
            this.Model.Usercode=this.Usercode;
            this.Model.CodePrp=this.CodePrp;
            this.Model.ValPrp=this.ValPrp;
        }
        private MapinfoTbGroupeViewModel _mapinfoTbGroupe;
        [DisplayName("Groupe")]
        public virtual MapinfoTbGroupeViewModel MapinfoTbGroupe
        {
            get
            {
                return this._mapinfoTbGroupe;
            }
            set
            {
                this._mapinfoTbGroupe = value;
                RaisePropertyChange("MapinfoTbGroupe");
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
    }
}
