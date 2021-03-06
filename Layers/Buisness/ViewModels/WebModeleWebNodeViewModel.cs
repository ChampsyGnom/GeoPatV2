using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class WebModeleWebNodeViewModel : ViewModelBase<WebModeleWebNode>
    {
        public WebModeleWebNodeViewModel(WebModeleWebNode model) : base(model)
        {
        }
        public override void Read()
        {
            this.WebNode=new WebNodeViewModel( this.Model.WebNode);
            this.WebModele=new WebModeleViewModel( this.Model.WebModele);
            this.MapOrder=this.Model.MapOrder;
            this.StyleWebId=this.Model.StyleWebId;
        }
        public override void Write()
        {
            this.Model.WebNode=this. WebNode.Model;
            this.Model.WebModele=this. WebModele.Model;
            this.Model.MapOrder=this.MapOrder;
            this.Model.StyleWebId=this.StyleWebId;
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
        
        private WebModeleViewModel _webModele;
        [DisplayName("Modèle")]
        public virtual WebModeleViewModel WebModele
        {
            get
            {
                return this._webModele;
            }
            set
            {
                this._webModele = value;
                RaisePropertyChange("WebModele");
            }
        }
        
        private Nullable<Int64> _mapOrder;
        [DisplayName("Ordre de la couche dans la carte")]
        public Nullable<Int64> MapOrder
        {
            get
            {
                return this._mapOrder;
            }
            set
            {
                this._mapOrder = value;
                RaisePropertyChange("MapOrder");
            }
        }
        
        private Nullable<Int64> _styleWebId;
        [DisplayName("Style du noeud pour le modèle")]
        public Nullable<Int64> StyleWebId
        {
            get
            {
                return this._styleWebId;
            }
            set
            {
                this._styleWebId = value;
                RaisePropertyChange("StyleWebId");
            }
        }
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["MapOrder"] != null)
                {
                    errors.Add("Ordre de la couche dans la carte : "+this["MapOrder"]);
                }
                if (this["StyleWebId"] != null)
                {
                    errors.Add("Style du noeud pour le modèle : "+this["StyleWebId"]);
                }
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
                if (columnName.Equals("MapOrder"))
                {
                }
                if (columnName.Equals("StyleWebId"))
                {
                }
                return null;
            }
        }
    }
}
