using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsCdTravauxViewModel : ViewModelBase
    {
        public ChsCdTravaux Model {get; set;}
        public ChsCdTravauxViewModel(ChsCdTravaux model)
        {
            this.ChsBpus = new  ObservableCollection<ChsBpuViewModel>();
            
            this.ChsPaves = new  ObservableCollection<ChsPaveViewModel>();
            
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
        public virtual ObservableCollection<ChsBpuViewModel> ChsBpus { get; set; }
        
        public virtual ObservableCollection<ChsPaveViewModel> ChsPaves { get; set; }
        
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
