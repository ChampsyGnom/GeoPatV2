using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnCdExtViewModel : ViewModelBase<BsnCdExt>
    {
        public BsnCdExtViewModel(BsnCdExt model) : base(model)
        {
            this.BsnDscs = new  ObservableCollection<BsnDscViewModel>();
            
            this.BsnDscTemps = new  ObservableCollection<BsnDscTempViewModel>();
            
        }
        public override void Read()
        {
            this.Type=this.Model.Type;
            this.IsBsn=this.Model.IsBsn;
            this.IsOh=this.Model.IsOh;
        }
        public override void Write()
        {
            this.Model.Type=this.Type;
            this.Model.IsBsn=this.IsBsn;
            this.Model.IsOh=this.IsOh;
        }
        public virtual ObservableCollection<BsnDscViewModel> BsnDscs { get; set; }
        
        public virtual ObservableCollection<BsnDscTempViewModel> BsnDscTemps { get; set; }
        
        private String _type;
        [DisplayName("Exutoire")]
        public String Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
                RaisePropertyChange("Type");
            }
        }
        private Boolean _isBsn;
        [DisplayName("Bassin")]
        public Boolean IsBsn
        {
            get
            {
                return this._isBsn;
            }
            set
            {
                this._isBsn = value;
                RaisePropertyChange("IsBsn");
            }
        }
        
        private Boolean _isOh;
        [DisplayName("Ouvrage hydraulique")]
        public Boolean IsOh
        {
            get
            {
                return this._isOh;
            }
            set
            {
                this._isOh = value;
                RaisePropertyChange("IsOh");
            }
        }
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Type"] != null)
                {
                    errors.Add("Exutoire : "+this["Type"]);
                }
                if (this["IsBsn"] != null)
                {
                    errors.Add("Bassin : "+this["IsBsn"]);
                }
                if (this["IsOh"] != null)
                {
                    errors.Add("Ouvrage hydraulique : "+this["IsOh"]);
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
                if (columnName.Equals("Type"))
                {
                    if (String.IsNullOrEmpty(this.Type))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("IsBsn"))
                {
                }
                if (columnName.Equals("IsOh"))
                {
                }
                return null;
            }
        }
    }
}
