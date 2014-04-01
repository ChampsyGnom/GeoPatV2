using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class MapinfoTbAnaThemaViewModel : ViewModelBase
    {
        public MapinfoTbAnaThema Model {get; set;}
        public MapinfoTbAnaThemaViewModel(MapinfoTbAnaThema model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.Usercode=this.Model.Usercode;
            this.Map=this.Model.Map;
            this.Modele=this.Model.Modele;
            this.CodePrp=this.Model.CodePrp;
            this.ValPrp=this.Model.ValPrp;
        }
        public override void Write()
        {
            this.Model.Usercode=this.Usercode;
            this.Model.Map=this.Map;
            this.Model.Modele=this.Modele;
            this.Model.CodePrp=this.CodePrp;
            this.Model.ValPrp=this.ValPrp;
        }
        private String _usercode;
        [DisplayName("Nom User")]
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
        private String _map;
        [DisplayName("Carte")]
        public String Map
        {
            get
            {
                return this._map;
            }
            set
            {
                this._map = value;
                RaisePropertyChange("Map");
            }
        }
        private String _modele;
        [DisplayName("Nom Modele")]
        public String Modele
        {
            get
            {
                return this._modele;
            }
            set
            {
                this._modele = value;
                RaisePropertyChange("Modele");
            }
        }
        private String _codePrp;
        [DisplayName("Code Prp")]
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
        [DisplayName("Valeur Prp")]
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
