using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class MapinfoTbTemplateCfgViewModel : ViewModelBase
    {
        public MapinfoTbTemplateCfg Model {get; set;}
        public MapinfoTbTemplateCfgViewModel(MapinfoTbTemplateCfg model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.MapinfoTbTemplate=new MapinfoTbTemplateViewModel( this.Model.MapinfoTbTemplate);
            this.Usercode=this.Model.Usercode;
            this.CodePrp=this.Model.CodePrp;
            this.ValPrp=this.Model.ValPrp;
        }
        public override void Write()
        {
            this.Model.MapinfoTbTemplate=this. MapinfoTbTemplate.Model;
            this.Model.Usercode=this.Usercode;
            this.Model.CodePrp=this.CodePrp;
            this.Model.ValPrp=this.ValPrp;
        }
        private MapinfoTbTemplateViewModel _mapinfoTbTemplate;
        [DisplayName("Template")]
        public virtual MapinfoTbTemplateViewModel MapinfoTbTemplate
        {
            get
            {
                return this._mapinfoTbTemplate;
            }
            set
            {
                this._mapinfoTbTemplate = value;
                RaisePropertyChange("MapinfoTbTemplate");
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
        [DisplayName("Propriétée")]
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
