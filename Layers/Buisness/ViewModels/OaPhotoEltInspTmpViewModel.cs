using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaPhotoEltInspTmpViewModel : ViewModelBase
    {
        public OaPhotoEltInspTmp Model {get; set;}
        public OaPhotoEltInspTmpViewModel(OaPhotoEltInspTmp model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.OaEltInspTmp=new OaEltInspTmpViewModel( this.Model.OaEltInspTmp);
            this.Id=this.Model.Id;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.OaEltInspTmp=this. OaEltInspTmp.Model;
            this.Model.Id=this.Id;
            this.Model.Commentaire=this.Commentaire;
        }
        private OaEltInspTmpViewModel _oaEltInspTmp;
        [DisplayName("Détail inspection temporaire")]
        public virtual OaEltInspTmpViewModel OaEltInspTmp
        {
            get
            {
                return this._oaEltInspTmp;
            }
            set
            {
                this._oaEltInspTmp = value;
                RaisePropertyChange("OaEltInspTmp");
            }
        }
        
        private String _id;
        [DisplayName("Identifiant de la photo")]
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
