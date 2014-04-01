using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotCdTravauxViewModel : ViewModelBase
    {
        public GotCdTravaux Model {get; set;}
        public GotCdTravauxViewModel(GotCdTravaux model)
        {
            this.GotNatureTravs = new  ObservableCollection<GotNatureTravViewModel>();
            
            this.GotBpus = new  ObservableCollection<GotBpuViewModel>();
            
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
        public virtual ObservableCollection<GotNatureTravViewModel> GotNatureTravs { get; set; }
        
        public virtual ObservableCollection<GotBpuViewModel> GotBpus { get; set; }
        
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
