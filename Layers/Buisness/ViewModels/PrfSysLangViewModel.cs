using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class PrfSysLangViewModel : ViewModelBase<PrfSysLang>
    {
        public PrfSysLangViewModel(PrfSysLang model) : base(model)
        {
        }
        public override void Read()
        {
            this.CodeApp=this.Model.CodeApp;
            this.CodePrp=this.Model.CodePrp;
            this.ValPrp=this.Model.ValPrp;
            this.SortTrad=this.Model.SortTrad;
        }
        public override void Write()
        {
            this.Model.CodeApp=this.CodeApp;
            this.Model.CodePrp=this.CodePrp;
            this.Model.ValPrp=this.ValPrp;
            this.Model.SortTrad=this.SortTrad;
        }
        private String _codeApp;
        [DisplayName("CODE_APP")]
        public String CodeApp
        {
            get
            {
                return this._codeApp;
            }
            set
            {
                this._codeApp = value;
                RaisePropertyChange("CodeApp");
            }
        }
        private String _codePrp;
        [DisplayName("CODE_PRP")]
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
        [DisplayName("VAL_PRP")]
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
        private Nullable<Int64> _sortTrad;
        [DisplayName("SORT_TRAD")]
        public Nullable<Int64> SortTrad
        {
            get
            {
                return this._sortTrad;
            }
            set
            {
                this._sortTrad = value;
                RaisePropertyChange("SortTrad");
            }
        }
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["CodeApp"] != null)
                {
                    errors.Add("CODE_APP : "+this["CodeApp"]);
                }
                if (this["CodePrp"] != null)
                {
                    errors.Add("CODE_PRP : "+this["CodePrp"]);
                }
                if (this["ValPrp"] != null)
                {
                    errors.Add("VAL_PRP : "+this["ValPrp"]);
                }
                if (this["SortTrad"] != null)
                {
                    errors.Add("SORT_TRAD : "+this["SortTrad"]);
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
                if (columnName.Equals("CodeApp"))
                {
                    if (String.IsNullOrEmpty(this.CodeApp))
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
                if (columnName.Equals("SortTrad"))
                {
                }
                return null;
            }
        }
    }
}
