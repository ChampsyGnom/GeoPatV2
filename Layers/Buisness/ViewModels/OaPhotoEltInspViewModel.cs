using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaPhotoEltInspViewModel : ViewModelBase
    {
        public OaPhotoEltInsp Model {get; set;}
        public OaPhotoEltInspViewModel(OaPhotoEltInsp model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.OaEltInsp=new OaEltInspViewModel( this.Model.OaEltInsp);
            this.Id=this.Model.Id;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.OaEltInsp=this. OaEltInsp.Model;
            this.Model.Id=this.Id;
            this.Model.Commentaire=this.Commentaire;
        }
        private OaEltInspViewModel _oaEltInsp;
        [DisplayName("Détail inspection")]
        public virtual OaEltInspViewModel OaEltInsp
        {
            get
            {
                return this._oaEltInsp;
            }
            set
            {
                this._oaEltInsp = value;
                RaisePropertyChange("OaEltInsp");
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
