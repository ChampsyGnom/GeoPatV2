using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsCdContrainteViewModel : ViewModelBase<ChsCdContrainte>
    {
        public ChsCdContrainteViewModel(ChsCdContrainte model) : base(model)
        {
            this.ChsPrevisions = new  ObservableCollection<ChsPrevisionViewModel>();
            
        }
        public override void Read()
        {
            this.Type=this.Model.Type;
        }
        public override void Write()
        {
            this.Model.Type=this.Type;
        }
        public virtual ObservableCollection<ChsPrevisionViewModel> ChsPrevisions { get; set; }
        
        private String _type;
        [DisplayName("Contrainte")]
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
