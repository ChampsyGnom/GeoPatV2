using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhCdContrainteViewModel : ViewModelBase
    {
        public OhCdContrainte Model {get; set;}
        public OhCdContrainteViewModel(OhCdContrainte model)
        {
            this.OhPrevisions = new  ObservableCollection<OhPrevisionViewModel>();
            
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
        public virtual ObservableCollection<OhPrevisionViewModel> OhPrevisions { get; set; }
        
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
