using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnCdSousTypeViewModel : ViewModelBase<BsnCdSousType>
    {
        public BsnCdSousTypeViewModel(BsnCdSousType model) : base(model)
        {
            this.BsnDscs = new  ObservableCollection<BsnDscViewModel>();
            
            this.BsnDscTemps = new  ObservableCollection<BsnDscTempViewModel>();
            
        }
        public override void Read()
        {
            this.NatSensib=this.Model.NatSensib;
        }
        public override void Write()
        {
            this.Model.NatSensib=this.NatSensib;
        }
        public virtual ObservableCollection<BsnDscViewModel> BsnDscs { get; set; }
        
        public virtual ObservableCollection<BsnDscTempViewModel> BsnDscTemps { get; set; }
        
        private String _natSensib;
        [DisplayName("Nature sensibilité")]
        public String NatSensib
        {
            get
            {
                return this._natSensib;
            }
            set
            {
                this._natSensib = value;
                RaisePropertyChange("NatSensib");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["NatSensib"] != null)
                {
                    errors.Add("Nature sensibilité : "+this["NatSensib"]);
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
                if (columnName.Equals("NatSensib"))
                {
                    if (String.IsNullOrEmpty(this.NatSensib))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
