using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhCdProAvViewModel : ViewModelBase<OhCdProAv>
    {
        public OhCdProAvViewModel(OhCdProAv model) : base(model)
        {
            this.OhDscs = new  ObservableCollection<OhDscViewModel>();
            
            this.OhDscTemps = new  ObservableCollection<OhDscTempViewModel>();
            
        }
        public override void Read()
        {
            this.Protect=this.Model.Protect;
        }
        public override void Write()
        {
            this.Model.Protect=this.Protect;
        }
        public virtual ObservableCollection<OhDscViewModel> OhDscs { get; set; }
        
        public virtual ObservableCollection<OhDscTempViewModel> OhDscTemps { get; set; }
        
        private String _protect;
        [DisplayName("Protection Aval")]
        public String Protect
        {
            get
            {
                return this._protect;
            }
            set
            {
                this._protect = value;
                RaisePropertyChange("Protect");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Protect"] != null)
                {
                    errors.Add("Protection Aval : "+this["Protect"]);
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
                if (columnName.Equals("Protect"))
                {
                    if (String.IsNullOrEmpty(this.Protect))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
