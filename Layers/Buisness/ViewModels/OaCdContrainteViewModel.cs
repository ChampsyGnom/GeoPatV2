using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaCdContrainteViewModel : ViewModelBase
    {
        public OaCdContrainte Model {get; set;}
        public OaCdContrainteViewModel(OaCdContrainte model)
        {
            this.OaPrevisions = new  ObservableCollection<OaPrevisionViewModel>();
            
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
        public virtual ObservableCollection<OaPrevisionViewModel> OaPrevisions { get; set; }
        
        private String _type;
        [DisplayName("Contrainte Exploit.")]
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
