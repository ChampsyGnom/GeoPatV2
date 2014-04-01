using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfCdTalusViewModel : ViewModelBase<InfCdTalus>
    {
        public InfCdTalusViewModel(InfCdTalus model) : base(model)
        {
            this.InfTaluss = new  ObservableCollection<InfTalusViewModel>();
            
        }
        public override void Read()
        {
            this.Type=this.Model.Type;
        }
        public override void Write()
        {
            this.Model.Type=this.Type;
        }
        public virtual ObservableCollection<InfTalusViewModel> InfTaluss { get; set; }
        
        private String _type;
        [DisplayName("Type Talus")]
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
