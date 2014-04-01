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
    }
}
