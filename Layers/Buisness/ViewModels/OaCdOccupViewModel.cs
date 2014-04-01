using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaCdOccupViewModel : ViewModelBase
    {
        public OaCdOccup Model {get; set;}
        public OaCdOccupViewModel(OaCdOccup model)
        {
            this.OaOccupations = new  ObservableCollection<OaOccupationViewModel>();
            
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
