using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class WebModeleViewModel : ViewModelBase<WebModele>
    {
        public WebModeleViewModel(WebModele model) : base(model)
        {
            this.WebModeleWebNodes = new  ObservableCollection<WebModeleWebNodeViewModel>();
            
        }
        public override void Read()
        {
            this.WebCdModele=new WebCdModeleViewModel( this.Model.WebCdModele);
            this.Id=this.Model.Id;
            this.Libelle=this.Model.Libelle;
            this.IsPublic=this.Model.IsPublic;
        }
        public override void Write()
        {
            this.Model.WebCdModele=this. WebCdModele.Model;
            this.Model.Id=this.Id;
            this.Model.Libelle=this.Libelle;
            this.Model.IsPublic=this.IsPublic;
        }
        private WebCdModeleViewModel _webCdModele;
        [DisplayName("Type de modèle (détail schématique synoptique)")]
        public virtual WebCdModeleViewModel WebCdModele
        {
            get
            {
                return this._webCdModele;
            }
            set
            {
                this._webCdModele = value;
                RaisePropertyChange("WebCdModele");
            }
        }
        
        public virtual ObservableCollection<WebModeleWebNodeViewModel> WebModeleWebNodes { get; set; }
        
        private Int64 _id;
        [DisplayName("Identifiant du modèle")]
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
        [DisplayName("Libellé du modèle")]
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
        private Nullable<Boolean> _isPublic;
        [DisplayName("Public")]
        public Nullable<Boolean> IsPublic
        {
            get
            {
                return this._isPublic;
            }
            set
            {
                this._isPublic = value;
                RaisePropertyChange("IsPublic");
            }
        }
        
    }
}
