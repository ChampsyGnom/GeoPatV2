using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhCdExtViewModel : ViewModelBase<OhCdExt>
    {
        public OhCdExtViewModel(OhCdExt model) : base(model)
        {
            this.OhDscs = new  ObservableCollection<OhDscViewModel>();
            
            this.OhDscTemps = new  ObservableCollection<OhDscTempViewModel>();
            
        }
        public override void Read()
        {
            this.Type=this.Model.Type;
            this.IsOh=this.Model.IsOh;
            this.IsBsn=this.Model.IsBsn;
        }
        public override void Write()
        {
            this.Model.Type=this.Type;
            this.Model.IsOh=this.IsOh;
            this.Model.IsBsn=this.IsBsn;
        }
        public virtual ObservableCollection<OhDscViewModel> OhDscs { get; set; }
        
        public virtual ObservableCollection<OhDscTempViewModel> OhDscTemps { get; set; }
        
        private String _type;
        [DisplayName("Type exutoire")]
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
        private Boolean _isOh;
        [DisplayName("Exutoire OH")]
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
        
        private Boolean _isBsn;
        [DisplayName("Exétoire Bassin")]
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
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Type"] != null)
                {
                    errors.Add("Type exutoire : "+this["Type"]);
                }
                if (this["IsOh"] != null)
                {
                    errors.Add("Exutoire OH : "+this["IsOh"]);
                }
                if (this["IsBsn"] != null)
                {
                    errors.Add("Exétoire Bassin : "+this["IsBsn"]);
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
                if (columnName.Equals("IsOh"))
                {
                }
                if (columnName.Equals("IsBsn"))
                {
                }
                return null;
            }
        }
    }
}
