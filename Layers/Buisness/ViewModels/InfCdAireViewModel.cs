using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfCdAireViewModel : ViewModelBase<InfCdAire>
    {
        public InfCdAireViewModel(InfCdAire model) : base(model)
        {
            this.InfAires = new  ObservableCollection<InfAireViewModel>();
            
        }
        public override void Read()
        {
            this.Type=this.Model.Type;
        }
        public override void Write()
        {
            this.Model.Type=this.Type;
        }
        public virtual ObservableCollection<InfAireViewModel> InfAires { get; set; }
        
        private String _type;
        [DisplayName("Type Aire")]
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
