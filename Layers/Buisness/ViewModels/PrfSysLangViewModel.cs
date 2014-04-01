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
        
    }
}
