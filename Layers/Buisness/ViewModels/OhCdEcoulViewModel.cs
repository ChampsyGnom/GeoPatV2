using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhCdEcoulViewModel : ViewModelBase<OhCdEcoul>
    {
        public OhCdEcoulViewModel(OhCdEcoul model) : base(model)
        {
            this.OhDscs = new  ObservableCollection<OhDscViewModel>();
            
            this.OhDscTemps = new  ObservableCollection<OhDscTempViewModel>();
            
        }
        public override void Read()
        {
            this.Ecoul=this.Model.Ecoul;
        }
        public override void Write()
        {
            this.Model.Ecoul=this.Ecoul;
        }
        public virtual ObservableCollection<OhDscViewModel> OhDscs { get; set; }
        
        public virtual ObservableCollection<OhDscTempViewModel> OhDscTemps { get; set; }
        
        private String _ecoul;
        [DisplayName("Ecoulement")]
        public String Ecoul
        {
            get
            {
                return this._ecoul;
            }
            set
            {
                this._ecoul = value;
                RaisePropertyChange("Ecoul");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Ecoul"] != null)
                {
                    errors.Add("Ecoulement : "+this["Ecoul"]);
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
                if (columnName.Equals("Ecoul"))
                {
                    if (String.IsNullOrEmpty(this.Ecoul))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
