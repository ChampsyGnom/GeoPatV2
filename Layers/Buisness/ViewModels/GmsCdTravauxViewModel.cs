using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GmsCdTravauxViewModel : ViewModelBase
    {
        public GmsCdTravaux Model {get; set;}
        public GmsCdTravauxViewModel(GmsCdTravaux model)
        {
            this.GmsNatureTravs = new  ObservableCollection<GmsNatureTravViewModel>();
            
            this.GmsBpus = new  ObservableCollection<GmsBpuViewModel>();
            
            this.Model = model;
            this.Read();
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
    }
}
