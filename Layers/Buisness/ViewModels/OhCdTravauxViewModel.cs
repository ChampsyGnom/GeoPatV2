using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhCdTravauxViewModel : ViewModelBase<OhCdTravaux>
    {
        public OhCdTravauxViewModel(OhCdTravaux model) : base(model)
        {
            this.OhNatureTravs = new  ObservableCollection<OhNatureTravViewModel>();
            
            this.OhBpus = new  ObservableCollection<OhBpuViewModel>();
            
        }
        public override void Read()
        {
            this.Code=this.Model.Code;
        }
        public override void Write()
        {
            this.Model.Code=this.Code;
        }
        public virtual ObservableCollection<OhNatureTravViewModel> OhNatureTravs { get; set; }
        
        public virtual ObservableCollection<OhBpuViewModel> OhBpus { get; set; }
        
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
