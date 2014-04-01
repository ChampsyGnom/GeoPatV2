using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaPhotoSprtVstViewModel : ViewModelBase<OaPhotoSprtVst>
    {
        public OaPhotoSprtVstViewModel(OaPhotoSprtVst model) : base(model)
        {
        }
        public override void Read()
        {
            this.OaSprtVst=new OaSprtVstViewModel( this.Model.OaSprtVst);
            this.Id=this.Model.Id;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.OaSprtVst=this. OaSprtVst.Model;
            this.Model.Id=this.Id;
            this.Model.Commentaire=this.Commentaire;
        }
        private OaSprtVstViewModel _oaSprtVst;
        [DisplayName("Détail visite")]
        public virtual OaSprtVstViewModel OaSprtVst
        {
            get
            {
                return this._oaSprtVst;
            }
            set
            {
                this._oaSprtVst = value;
                RaisePropertyChange("OaSprtVst");
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
