using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfCdServiceViewModel : ViewModelBase<InfCdService>
    {
        public InfCdServiceViewModel(InfCdService model) : base(model)
        {
            this.InfAireServices = new  ObservableCollection<InfAireServiceViewModel>();
            
        }
        public override void Read()
        {
            this.Service=this.Model.Service;
        }
        public override void Write()
        {
            this.Model.Service=this.Service;
        }
        public virtual ObservableCollection<InfAireServiceViewModel> InfAireServices { get; set; }
        
        private String _service;
        [DisplayName("Type Service")]
        public String Service
        {
            get
            {
                return this._service;
            }
            set
            {
                this._service = value;
                RaisePropertyChange("Service");
            }
        }
    }
}
