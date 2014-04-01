using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfCdSensibleViewModel : ViewModelBase
    {
        public InfCdSensible Model {get; set;}
        public InfCdSensibleViewModel(InfCdSensible model)
        {
            this.InfSensibles = new  ObservableCollection<InfSensibleViewModel>();
            
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
