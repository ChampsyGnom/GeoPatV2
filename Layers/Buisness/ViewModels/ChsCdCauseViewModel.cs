using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsCdCauseViewModel : ViewModelBase
    {
        public ChsCdCause Model {get; set;}
        public ChsCdCauseViewModel(ChsCdCause model)
        {
            this.ChsPaves = new  ObservableCollection<ChsPaveViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.Cause=this.Model.Cause;
        }
        public override void Write()
        {
            this.Model.Cause=this.Cause;
        }
        public virtual ObservableCollection<ChsPaveViewModel> ChsPaves { get; set; }
        
        private String _cause;
        [DisplayName("Cause")]
        public String Cause
        {
            get
            {
                return this._cause;
            }
            set
            {
                this._cause = value;
                RaisePropertyChange("Cause");
            }
        }
    }
}
