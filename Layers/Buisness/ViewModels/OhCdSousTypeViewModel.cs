using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhCdSousTypeViewModel : ViewModelBase<OhCdSousType>
    {
        public OhCdSousTypeViewModel(OhCdSousType model) : base(model)
        {
            this.OhDscs = new  ObservableCollection<OhDscViewModel>();
            
            this.OhDscTemps = new  ObservableCollection<OhDscTempViewModel>();
            
        }
        public override void Read()
        {
            this.SousType=this.Model.SousType;
        }
        public override void Write()
        {
            this.Model.SousType=this.SousType;
        }
        public virtual ObservableCollection<OhDscViewModel> OhDscs { get; set; }
        
        public virtual ObservableCollection<OhDscTempViewModel> OhDscTemps { get; set; }
        
        private String _sousType;
        [DisplayName("Sous type OH")]
        public String SousType
        {
            get
            {
                return this._sousType;
            }
            set
            {
                this._sousType = value;
                RaisePropertyChange("SousType");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["SousType"] != null)
                {
                    errors.Add("Sous type OH : "+this["SousType"]);
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
                if (columnName.Equals("SousType"))
                {
                    if (String.IsNullOrEmpty(this.SousType))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
