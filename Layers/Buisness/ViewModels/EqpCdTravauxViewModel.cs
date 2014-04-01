using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class EqpCdTravauxViewModel : ViewModelBase
    {
        public EqpCdTravaux Model {get; set;}
        public EqpCdTravauxViewModel(EqpCdTravaux model)
        {
            this.EqpNatureTravs = new  ObservableCollection<EqpNatureTravViewModel>();
            
            this.EqpBpus = new  ObservableCollection<EqpBpuViewModel>();
            
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
        public virtual ObservableCollection<EqpNatureTravViewModel> EqpNatureTravs { get; set; }
        
        public virtual ObservableCollection<EqpBpuViewModel> EqpBpus { get; set; }
        
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
