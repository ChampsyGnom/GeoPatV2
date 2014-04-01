using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class WebCdNodeViewModel : ViewModelBase
    {
        public WebCdNode Model {get; set;}
        public WebCdNodeViewModel(WebCdNode model)
        {
            this.WebNodes = new  ObservableCollection<WebNodeViewModel>();
            
            this.Model = model;
            this.Read();
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
