using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotCdContrainteViewModel : ViewModelBase<GotCdContrainte>
    {
        public GotCdContrainteViewModel(GotCdContrainte model) : base(model)
        {
            this.GotPrevisions = new  ObservableCollection<GotPrevisionViewModel>();
            
        }
        public override void Read()
        {
            this.Type=this.Model.Type;
        }
        public override void Write()
        {
            this.Model.Type=this.Type;
        }
        public virtual ObservableCollection<GotPrevisionViewModel> GotPrevisions { get; set; }
        
        private String _type;
        [DisplayName("Contrainte exploit")]
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
