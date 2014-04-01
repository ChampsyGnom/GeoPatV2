using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfCdOccupViewModel : ViewModelBase
    {
        public InfCdOccup Model {get; set;}
        public InfCdOccupViewModel(InfCdOccup model)
        {
            this.InfOccupations = new  ObservableCollection<InfOccupationViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.Type=this.Model.Type;
        }
        public override void Write()
        {
            this.Model.Type=this.Type;
        }
        public virtual ObservableCollection<InfOccupationViewModel> InfOccupations { get; set; }
        
        private String _type;
        [DisplayName("Type Occupation")]
        public String Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
                RaisePropertyChange("Type");
            }
        }
    }
}
