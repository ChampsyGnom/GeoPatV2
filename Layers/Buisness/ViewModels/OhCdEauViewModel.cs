using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhCdEauViewModel : ViewModelBase<OhCdEau>
    {
        public OhCdEauViewModel(OhCdEau model) : base(model)
        {
            this.OhDscs = new  ObservableCollection<OhDscViewModel>();
            
            this.OhDscTemps = new  ObservableCollection<OhDscTempViewModel>();
            
        }
        public override void Read()
        {
            this.Eau=this.Model.Eau;
        }
        public override void Write()
        {
            this.Model.Eau=this.Eau;
        }
        public virtual ObservableCollection<OhDscViewModel> OhDscs { get; set; }
        
        public virtual ObservableCollection<OhDscTempViewModel> OhDscTemps { get; set; }
        
        private String _eau;
        [DisplayName("Eaux collectées")]
        public String Eau
        {
            get
            {
                return this._eau;
            }
            set
            {
                this._eau = value;
                RaisePropertyChange("Eau");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Eau"] != null)
                {
                    errors.Add("Eaux collectées : "+this["Eau"]);
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
                if (columnName.Equals("Eau"))
                {
                    if (String.IsNullOrEmpty(this.Eau))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
