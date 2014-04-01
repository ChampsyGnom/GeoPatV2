using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnCdTravauxViewModel : ViewModelBase
    {
        public BsnCdTravaux Model {get; set;}
        public BsnCdTravauxViewModel(BsnCdTravaux model)
        {
            this.BsnNatureTravs = new  ObservableCollection<BsnNatureTravViewModel>();
            
            this.BsnBpus = new  ObservableCollection<BsnBpuViewModel>();
            
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
        public virtual ObservableCollection<BsnNatureTravViewModel> BsnNatureTravs { get; set; }
        
        public virtual ObservableCollection<BsnBpuViewModel> BsnBpus { get; set; }
        
        private String _code;
        [DisplayName("Type travaux")]
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
