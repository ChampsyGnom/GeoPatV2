using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaCdFondViewModel : ViewModelBase<OaCdFond>
    {
        public OaCdFondViewModel(OaCdFond model) : base(model)
        {
            this.OaDscs = new  ObservableCollection<OaDscViewModel>();
            
            this.OaDscTemps = new  ObservableCollection<OaDscTempViewModel>();
            
        }
        public override void Read()
        {
            this.Type=this.Model.Type;
        }
        public override void Write()
        {
            this.Model.Type=this.Type;
        }
        public virtual ObservableCollection<OaDscViewModel> OaDscs { get; set; }
        
        public virtual ObservableCollection<OaDscTempViewModel> OaDscTemps { get; set; }
        
        private String _type;
        [DisplayName("Fondation")]
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
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Type"] != null)
                {
                    errors.Add("Fondation : "+this["Type"]);
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
                return null;
            }
        }
    }
}
