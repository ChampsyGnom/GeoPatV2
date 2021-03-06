using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GmsCdProtecViewModel : ViewModelBase<GmsCdProtec>
    {
        public GmsCdProtecViewModel(GmsCdProtec model) : base(model)
        {
            this.GmsDscs = new  ObservableCollection<GmsDscViewModel>();
            
            this.GmsDscTemps = new  ObservableCollection<GmsDscTempViewModel>();
            
        }
        public override void Read()
        {
            this.Protec=this.Model.Protec;
        }
        public override void Write()
        {
            this.Model.Protec=this.Protec;
        }
        public virtual ObservableCollection<GmsDscViewModel> GmsDscs { get; set; }
        
        public virtual ObservableCollection<GmsDscTempViewModel> GmsDscTemps { get; set; }
        
        private String _protec;
        [DisplayName("Type protection")]
        public String Protec
        {
            get
            {
                return this._protec;
            }
            set
            {
                this._protec = value;
                RaisePropertyChange("Protec");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Protec"] != null)
                {
                    errors.Add("Type protection : "+this["Protec"]);
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
                if (columnName.Equals("Protec"))
                {
                    if (String.IsNullOrEmpty(this.Protec))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
