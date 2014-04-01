using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfCdBifViewModel : ViewModelBase<InfCdBif>
    {
        public InfCdBifViewModel(InfCdBif model) : base(model)
        {
            this.InfBifurcations = new  ObservableCollection<InfBifurcationViewModel>();
            
        }
        public override void Read()
        {
            this.Type=this.Model.Type;
        }
        public override void Write()
        {
            this.Model.Type=this.Type;
        }
        public virtual ObservableCollection<InfBifurcationViewModel> InfBifurcations { get; set; }
        
        private String _type;
        [DisplayName("Type Bifurcation")]
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
