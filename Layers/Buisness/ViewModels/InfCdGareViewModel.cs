using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfCdGareViewModel : ViewModelBase
    {
        public InfCdGare Model {get; set;}
        public InfCdGareViewModel(InfCdGare model)
        {
            this.InfGares = new  ObservableCollection<InfGareViewModel>();
            
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
