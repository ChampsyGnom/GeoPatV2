using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class WebModeleWebNodeViewModel : ViewModelBase
    {
        public WebModeleWebNode Model {get; set;}
        public WebModeleWebNodeViewModel(WebModeleWebNode model)
        {
            this.Model = model;
            this.Read();
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
        
    }
}
