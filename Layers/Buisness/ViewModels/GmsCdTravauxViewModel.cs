using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GmsCdTravauxViewModel : ViewModelBase<GmsCdTravaux>
    {
        public GmsCdTravauxViewModel(GmsCdTravaux model) : base(model)
        {
            this.GmsNatureTravs = new  ObservableCollection<GmsNatureTravViewModel>();
            
            this.GmsBpus = new  ObservableCollection<GmsBpuViewModel>();
            
        }
        public override void Read()
        {
            this.Code=this.Model.Code;
        }
        public override void Write()
        {
            this.Model.Code=this.Code;
        }
        public virtual ObservableCollection<GmsNatureTravViewModel> GmsNatureTravs { get; set; }
        
        public virtual ObservableCollection<GmsBpuViewModel> GmsBpus { get; set; }
        
        private String _code;
        [DisplayName("Type Travaux")]
        public String Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
                RaisePropertyChange("Code");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Code"] != null)
                {
                    errors.Add("Type Travaux : "+this["Code"]);
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
                if (columnName.Equals("Code"))
                {
                    if (String.IsNullOrEmpty(this.Code))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                return null;
            }
        }
    }
}
