using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class MapinfoTbAnaThemaViewModel : ViewModelBase<MapinfoTbAnaThema>
    {
        public MapinfoTbAnaThemaViewModel(MapinfoTbAnaThema model) : base(model)
        {
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
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Usercode"] != null)
                {
                    errors.Add("Nom User : "+this["Usercode"]);
                }
                if (this["Map"] != null)
                {
                    errors.Add("Carte : "+this["Map"]);
                }
                if (this["Modele"] != null)
                {
                    errors.Add("Nom Modele : "+this["Modele"]);
                }
                if (this["CodePrp"] != null)
                {
                    errors.Add("Code Prp : "+this["CodePrp"]);
                }
                if (this["ValPrp"] != null)
                {
                    errors.Add("Valeur Prp : "+this["ValPrp"]);
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
                if (columnName.Equals("Map"))
                {
                    if (String.IsNullOrEmpty(this.Map))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("Modele"))
                {
                    if (String.IsNullOrEmpty(this.Modele))
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
                }
                return null;
            }
        }
    }
}
