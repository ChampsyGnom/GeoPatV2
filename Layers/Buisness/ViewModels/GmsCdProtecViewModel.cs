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
    }
}
