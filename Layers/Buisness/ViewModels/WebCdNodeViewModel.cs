using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class WebCdNodeViewModel : ViewModelBase<WebCdNode>
    {
        public WebCdNodeViewModel(WebCdNode model) : base(model)
        {
            this.WebNodes = new  ObservableCollection<WebNodeViewModel>();
            
        }
        public override void Read()
        {
            this.Name=this.Model.Name;
        }
        public override void Write()
        {
            this.Model.Name=this.Name;
        }
        public virtual ObservableCollection<WebNodeViewModel> WebNodes { get; set; }
        
        private String _name;
        [DisplayName("Type de noeud")]
        public String Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
                RaisePropertyChange("Name");
            }
        }
    }
}
