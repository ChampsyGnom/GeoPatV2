using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaCdTravauxViewModel : ViewModelBase<OaCdTravaux>
    {
        public OaCdTravauxViewModel(OaCdTravaux model) : base(model)
        {
            this.OaBpus = new  ObservableCollection<OaBpuViewModel>();
            
            this.OaNatureTravs = new  ObservableCollection<OaNatureTravViewModel>();
            
        }
        public override void Read()
        {
            this.Code=this.Model.Code;
        }
        public override void Write()
        {
            this.Model.Code=this.Code;
        }
        public virtual ObservableCollection<OaBpuViewModel> OaBpus { get; set; }
        
        public virtual ObservableCollection<OaNatureTravViewModel> OaNatureTravs { get; set; }
        
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
