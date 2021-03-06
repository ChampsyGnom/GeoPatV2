using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class WebNodeWebStyleViewModel : ViewModelBase<WebNodeWebStyle>
    {
        public WebNodeWebStyleViewModel(WebNodeWebStyle model) : base(model)
        {
        }
        public override void Read()
        {
            this.WebNode=new WebNodeViewModel( this.Model.WebNode);
            this.WebStyle=new WebStyleViewModel( this.Model.WebStyle);
        }
        public override void Write()
        {
            this.Model.WebNode=this. WebNode.Model;
            this.Model.WebStyle=this. WebStyle.Model;
        }
        private WebNodeViewModel _webNode;
        [DisplayName("Noeuds du tableau de bord")]
        public virtual WebNodeViewModel WebNode
        {
            get
            {
                return this._webNode;
            }
            set
            {
                this._webNode = value;
                RaisePropertyChange("WebNode");
            }
        }
        
        private WebStyleViewModel _webStyle;
        [DisplayName("Style d'un couche")]
        public virtual WebStyleViewModel WebStyle
        {
            get
            {
                return this._webStyle;
            }
            set
            {
                this._webStyle = value;
                RaisePropertyChange("WebStyle");
            }
        }
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (errors.Count > 0)
                {
                    return String.Join("\r\n",errors);
                }
                else return null;
            }
        }
        public override string this[string columnName]
        {
            get
            {
                return null;
            }
        }
    }
}
