using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnCdFrequenceViewModel : ViewModelBase<BsnCdFrequence>
    {
        public BsnCdFrequenceViewModel(BsnCdFrequence model) : base(model)
        {
            this.BsnDscs = new  ObservableCollection<BsnDscViewModel>();
            
            this.BsnDscTemps = new  ObservableCollection<BsnDscTempViewModel>();
            
        }
        public override void Read()
        {
            this.Freq=this.Model.Freq;
        }
        public override void Write()
        {
            this.Model.Freq=this.Freq;
        }
        public virtual ObservableCollection<BsnDscViewModel> BsnDscs { get; set; }
        
        public virtual ObservableCollection<BsnDscTempViewModel> BsnDscTemps { get; set; }
        
        private String _freq;
        [DisplayName("Fréquence")]
        public String Freq
        {
            get
            {
                return this._freq;
            }
            set
            {
                this._freq = value;
                RaisePropertyChange("Freq");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Freq"] != null)
                {
                    errors.Add("Fréquence : "+this["Freq"]);
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
                if (columnName.Equals("Freq"))
                {
                    if (String.IsNullOrEmpty(this.Freq))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
