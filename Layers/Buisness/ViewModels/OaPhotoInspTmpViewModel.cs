using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaPhotoInspTmpViewModel : ViewModelBase<OaPhotoInspTmp>
    {
        public OaPhotoInspTmpViewModel(OaPhotoInspTmp model) : base(model)
        {
        }
        public override void Read()
        {
            this.OaInspTmp=new OaInspTmpViewModel( this.Model.OaInspTmp);
            this.Id=this.Model.Id;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.OaInspTmp=this. OaInspTmp.Model;
            this.Model.Id=this.Id;
            this.Model.Commentaire=this.Commentaire;
        }
        private OaInspTmpViewModel _oaInspTmp;
        [DisplayName("Inspection temporaire")]
        public virtual OaInspTmpViewModel OaInspTmp
        {
            get
            {
                return this._oaInspTmp;
            }
            set
            {
                this._oaInspTmp = value;
                RaisePropertyChange("OaInspTmp");
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
