using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotCdContrainteViewModel : ViewModelBase
    {
        public GotCdContrainte Model {get; set;}
        public GotCdContrainteViewModel(GotCdContrainte model)
        {
            this.GotPrevisions = new  ObservableCollection<GotPrevisionViewModel>();
            
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
