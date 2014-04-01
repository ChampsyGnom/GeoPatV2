using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class WebNodeViewModel : ViewModelBase<WebNode>
    {
        public WebNodeViewModel(WebNode model) : base(model)
        {
            this.WebNodeParams = new  ObservableCollection<WebNodeParamViewModel>();
            
            this.WebModeleWebNodes = new  ObservableCollection<WebModeleWebNodeViewModel>();
            
            this.WebNodeWebStyles = new  ObservableCollection<WebNodeWebStyleViewModel>();
            
        }
        public override void Read()
        {
            this.WebCdNode=new WebCdNodeViewModel( this.Model.WebCdNode);
            this.Id=this.Model.Id;
            this.Libelle=this.Model.Libelle;
            this.ParentId=this.Model.ParentId;
            this.TreeOrder=this.Model.TreeOrder;
        }
        public override void Write()
        {
            this.Model.WebCdNode=this. WebCdNode.Model;
            this.Model.Id=this.Id;
            this.Model.Libelle=this.Libelle;
            this.Model.ParentId=this.ParentId;
            this.Model.TreeOrder=this.TreeOrder;
        }
        private WebCdNodeViewModel _webCdNode;
        [DisplayName("Type de noeud du tableau de bord")]
        public virtual WebCdNodeViewModel WebCdNode
        {
            get
            {
                return this._webCdNode;
            }
            set
            {
                this._webCdNode = value;
                RaisePropertyChange("WebCdNode");
            }
        }
        
        public virtual ObservableCollection<WebNodeParamViewModel> WebNodeParams { get; set; }
        
        public virtual ObservableCollection<WebModeleWebNodeViewModel> WebModeleWebNodes { get; set; }
        
        public virtual ObservableCollection<WebNodeWebStyleViewModel> WebNodeWebStyles { get; set; }
        
        private Int64 _id;
        [DisplayName("Identifiant du noeud")]
        public Int64 Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
                RaisePropertyChange("Id");
            }
        }
        
        private String _libelle;
        [DisplayName("Libellé")]
        public String Libelle
        {
            get
            {
                return this._libelle;
            }
            set
            {
                this._libelle = value;
                RaisePropertyChange("Libelle");
            }
        }
        private Nullable<Int64> _parentId;
        [DisplayName("Identifiant du noeud parent")]
        public Nullable<Int64> ParentId
        {
            get
            {
                return this._parentId;
            }
            set
            {
                this._parentId = value;
                RaisePropertyChange("ParentId");
            }
        }
        
        private Nullable<Int64> _treeOrder;
        [DisplayName("Ordre du noeud dans le parent")]
        public Nullable<Int64> TreeOrder
        {
            get
            {
                return this._treeOrder;
            }
            set
            {
                this._treeOrder = value;
                RaisePropertyChange("TreeOrder");
            }
        }
        
    }
}
