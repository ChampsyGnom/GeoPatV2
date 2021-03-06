using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaCdTablierViewModel : ViewModelBase<OaCdTablier>
    {
        public OaCdTablierViewModel(OaCdTablier model) : base(model)
        {
            this.OaDscs = new  ObservableCollection<OaDscViewModel>();
            
            this.OaDscTemps = new  ObservableCollection<OaDscTempViewModel>();
            
        }
        public override void Read()
        {
            this.Tablier=this.Model.Tablier;
        }
        public override void Write()
        {
            this.Model.Tablier=this.Tablier;
        }
        public virtual ObservableCollection<OaDscViewModel> OaDscs { get; set; }
        
        public virtual ObservableCollection<OaDscTempViewModel> OaDscTemps { get; set; }
        
        private String _tablier;
        [DisplayName("Type tablier")]
        public String Tablier
        {
            get
            {
                return this._tablier;
            }
            set
            {
                this._tablier = value;
                RaisePropertyChange("Tablier");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Tablier"] != null)
                {
                    errors.Add("Type tablier : "+this["Tablier"]);
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
                if (columnName.Equals("Tablier"))
                {
                    if (String.IsNullOrEmpty(this.Tablier))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
