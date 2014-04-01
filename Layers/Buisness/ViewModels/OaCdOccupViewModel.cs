using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaCdOccupViewModel : ViewModelBase<OaCdOccup>
    {
        public OaCdOccupViewModel(OaCdOccup model) : base(model)
        {
            this.OaOccupations = new  ObservableCollection<OaOccupationViewModel>();
            
        }
        public override void Read()
        {
            this.Type=this.Model.Type;
        }
        public override void Write()
        {
            this.Model.Type=this.Type;
        }
        public virtual ObservableCollection<OaOccupationViewModel> OaOccupations { get; set; }
        
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
