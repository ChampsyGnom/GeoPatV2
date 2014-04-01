using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaPhotoInspViewModel : ViewModelBase<OaPhotoInsp>
    {
        public OaPhotoInspViewModel(OaPhotoInsp model) : base(model)
        {
        }
        public override void Read()
        {
            this.OaInsp=new OaInspViewModel( this.Model.OaInsp);
            this.Id=this.Model.Id;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.OaInsp=this. OaInsp.Model;
            this.Model.Id=this.Id;
            this.Model.Commentaire=this.Commentaire;
        }
        private OaInspViewModel _oaInsp;
        [DisplayName("Inspection")]
        public virtual OaInspViewModel OaInsp
        {
            get
            {
                return this._oaInsp;
            }
            set
            {
                this._oaInsp = value;
                RaisePropertyChange("OaInsp");
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
