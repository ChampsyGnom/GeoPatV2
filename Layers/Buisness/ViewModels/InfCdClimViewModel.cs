using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfCdClimViewModel : ViewModelBase<InfCdClim>
    {
        public InfCdClimViewModel(InfCdClim model) : base(model)
        {
            this.InfClims = new  ObservableCollection<InfClimViewModel>();
            
        }
        public override void Read()
        {
            this.Code=this.Model.Code;
        }
        public override void Write()
        {
            this.Model.Code=this.Code;
        }
        public virtual ObservableCollection<InfClimViewModel> InfClims { get; set; }
        
        private String _code;
        [DisplayName("Type Climat")]
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
