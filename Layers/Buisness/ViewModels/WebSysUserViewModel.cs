using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class WebSysUserViewModel : ViewModelBase<WebSysUser>
    {
        public WebSysUserViewModel(WebSysUser model) : base(model)
        {
        }
        public override void Read()
        {
            this.CodeDbs=this.Model.CodeDbs;
            this.CodeTable=this.Model.CodeTable;
            this.CodeColonne=this.Model.CodeColonne;
            this.NomUser=this.Model.NomUser;
            this.CodePrp=this.Model.CodePrp;
            this.ValPrp=this.Model.ValPrp;
        }
        public override void Write()
        {
            this.Model.CodeDbs=this.CodeDbs;
            this.Model.CodeTable=this.CodeTable;
            this.Model.CodeColonne=this.CodeColonne;
            this.Model.NomUser=this.NomUser;
            this.Model.CodePrp=this.CodePrp;
            this.Model.ValPrp=this.ValPrp;
        }
        private String _codeDbs;
        [DisplayName("Code dbs")]
        public String CodeDbs
        {
            get
            {
                return this._codeDbs;
            }
            set
            {
                this._codeDbs = value;
                RaisePropertyChange("CodeDbs");
            }
        }
        private String _codeTable;
        [DisplayName("Code table")]
        public String CodeTable
        {
            get
            {
                return this._codeTable;
            }
            set
            {
                this._codeTable = value;
                RaisePropertyChange("CodeTable");
            }
        }
        private String _codeColonne;
        [DisplayName("Code colonne")]
        public String CodeColonne
        {
            get
            {
                return this._codeColonne;
            }
            set
            {
                this._codeColonne = value;
                RaisePropertyChange("CodeColonne");
            }
        }
        private String _nomUser;
        [DisplayName("Code utilisateur")]
        public String NomUser
        {
            get
            {
                return this._nomUser;
            }
            set
            {
                this._nomUser = value;
                RaisePropertyChange("NomUser");
            }
        }
        private String _codePrp;
        [DisplayName("Code propriétée")]
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
        [DisplayName("Valeur propriétée")]
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
                if (this["CodeDbs"] != null)
                {
                    errors.Add("Code dbs : "+this["CodeDbs"]);
                }
                if (this["CodeTable"] != null)
                {
                    errors.Add("Code table : "+this["CodeTable"]);
                }
                if (this["CodeColonne"] != null)
                {
                    errors.Add("Code colonne : "+this["CodeColonne"]);
                }
                if (this["NomUser"] != null)
                {
                    errors.Add("Code utilisateur : "+this["NomUser"]);
                }
                if (this["CodePrp"] != null)
                {
                    errors.Add("Code propriétée : "+this["CodePrp"]);
                }
                if (this["ValPrp"] != null)
                {
                    errors.Add("Valeur propriétée : "+this["ValPrp"]);
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
                if (columnName.Equals("CodeDbs"))
                {
                    if (String.IsNullOrEmpty(this.CodeDbs))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("CodeTable"))
                {
                    if (String.IsNullOrEmpty(this.CodeTable))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("CodeColonne"))
                {
                    if (String.IsNullOrEmpty(this.CodeColonne))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("NomUser"))
                {
                    if (String.IsNullOrEmpty(this.NomUser))
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
