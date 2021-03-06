using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class DsPonParamViewModel : ViewModelBase<DsPonParam>
    {
        public DsPonParamViewModel(DsPonParam model) : base(model)
        {
        }
        public override void Read()
        {
            this.DsPon=new DsPonViewModel( this.Model.DsPon);
            this.Indic=this.Model.Indic;
            this.Poid=this.Model.Poid;
        }
        public override void Write()
        {
            this.Model.DsPon=this. DsPon.Model;
            this.Model.Indic=this.Indic;
            this.Model.Poid=this.Poid;
        }
        private DsPonViewModel _dsPon;
        [DisplayName("PON_DS")]
        public virtual DsPonViewModel DsPon
        {
            get
            {
                return this._dsPon;
            }
            set
            {
                this._dsPon = value;
                RaisePropertyChange("DsPon");
            }
        }
        
        private String _indic;
        [DisplayName("PON_PARAM_DS__INDIC")]
        public String Indic
        {
            get
            {
                return this._indic;
            }
            set
            {
                this._indic = value;
                RaisePropertyChange("Indic");
            }
        }
        private Int64 _poid;
        [DisplayName("PON_PARAM_DS__POID")]
        public Int64 Poid
        {
            get
            {
                return this._poid;
            }
            set
            {
                this._poid = value;
                RaisePropertyChange("Poid");
            }
        }
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Indic"] != null)
                {
                    errors.Add("PON_PARAM_DS__INDIC : "+this["Indic"]);
                }
                if (this["Poid"] != null)
                {
                    errors.Add("PON_PARAM_DS__POID : "+this["Poid"]);
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
                if (columnName.Equals("Indic"))
                {
                    if (String.IsNullOrEmpty(this.Indic))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("Poid"))
                {
                }
                return null;
            }
        }
    }
}
