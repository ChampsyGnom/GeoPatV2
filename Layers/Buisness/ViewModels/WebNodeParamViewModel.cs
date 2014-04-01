using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class WebNodeParamViewModel : ViewModelBase<WebNodeParam>
    {
        public WebNodeParamViewModel(WebNodeParam model) : base(model)
        {
        }
        public override void Read()
        {
            this.WebNode=new WebNodeViewModel( this.Model.WebNode);
            this.Code=this.Model.Code;
            this.Valeur=this.Model.Valeur;
        }
        public override void Write()
        {
            this.Model.WebNode=this. WebNode.Model;
            this.Model.Code=this.Code;
            this.Model.Valeur=this.Valeur;
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
        
        private String _code;
        [DisplayName("Code du paramètre")]
        public String Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
                RaisePropertyChange("Code");
            }
        }
        private String _valeur;
        [DisplayName("Valeur du paramètre")]
        public String Valeur
        {
            get
            {
                return this._valeur;
            }
            set
            {
                this._valeur = value;
                RaisePropertyChange("Valeur");
            }
        }
    }
}
