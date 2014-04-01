using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaPhotoVstViewModel : ViewModelBase<OaPhotoVst>
    {
        public OaPhotoVstViewModel(OaPhotoVst model) : base(model)
        {
        }
        public override void Read()
        {
            this.OaVst=new OaVstViewModel( this.Model.OaVst);
            this.Id=this.Model.Id;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.OaVst=this. OaVst.Model;
            this.Model.Id=this.Id;
            this.Model.Commentaire=this.Commentaire;
        }
        private OaVstViewModel _oaVst;
        [DisplayName("Visite")]
        public virtual OaVstViewModel OaVst
        {
            get
            {
                return this._oaVst;
            }
            set
            {
                this._oaVst = value;
                RaisePropertyChange("OaVst");
            }
        }
        
        private String _id;
        [DisplayName("Identifiant")]
        public String Id
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
        private String _commentaire;
        [DisplayName("Commentaire")]
        public String Commentaire
        {
            get
            {
                return this._commentaire;
            }
            set
            {
                this._commentaire = value;
                RaisePropertyChange("Commentaire");
            }
        }
    }
}
