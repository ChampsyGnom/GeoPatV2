using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GmsPhotoInspTmpViewModel : ViewModelBase
    {
        public GmsPhotoInspTmp Model {get; set;}
        public GmsPhotoInspTmpViewModel(GmsPhotoInspTmp model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.GmsInspTmp=new GmsInspTmpViewModel( this.Model.GmsInspTmp);
            this.Id=this.Model.Id;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.GmsInspTmp=this. GmsInspTmp.Model;
            this.Model.Id=this.Id;
            this.Model.Commentaire=this.Commentaire;
        }
        private GmsInspTmpViewModel _gmsInspTmp;
        [DisplayName("Inspection temporaire")]
        public virtual GmsInspTmpViewModel GmsInspTmp
        {
            get
            {
                return this._gmsInspTmp;
            }
            set
            {
                this._gmsInspTmp = value;
                RaisePropertyChange("GmsInspTmp");
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
