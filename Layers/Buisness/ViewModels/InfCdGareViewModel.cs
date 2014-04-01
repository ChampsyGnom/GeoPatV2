using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfCdGareViewModel : ViewModelBase<InfCdGare>
    {
        public InfCdGareViewModel(InfCdGare model) : base(model)
        {
            this.InfGares = new  ObservableCollection<InfGareViewModel>();
            
        }
        public override void Read()
        {
            this.Type=this.Model.Type;
        }
        public override void Write()
        {
            this.Model.Type=this.Type;
        }
        public virtual ObservableCollection<InfGareViewModel> InfGares { get; set; }
        
        private String _type;
        [DisplayName("Type Gare")]
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
