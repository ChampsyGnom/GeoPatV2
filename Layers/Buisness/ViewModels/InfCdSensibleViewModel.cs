using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfCdSensibleViewModel : ViewModelBase<InfCdSensible>
    {
        public InfCdSensibleViewModel(InfCdSensible model) : base(model)
        {
            this.InfSensibles = new  ObservableCollection<InfSensibleViewModel>();
            
        }
        public override void Read()
        {
            this.Code=this.Model.Code;
        }
        public override void Write()
        {
            this.Model.Code=this.Code;
        }
        public virtual ObservableCollection<InfSensibleViewModel> InfSensibles { get; set; }
        
        private String _code;
        [DisplayName("Type sensible")]
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
