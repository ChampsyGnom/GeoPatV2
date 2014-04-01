using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhPhotoInspTmpViewModel : ViewModelBase
    {
        public OhPhotoInspTmp Model {get; set;}
        public OhPhotoInspTmpViewModel(OhPhotoInspTmp model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.OhInspTmp=new OhInspTmpViewModel( this.Model.OhInspTmp);
            this.Id=this.Model.Id;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.OhInspTmp=this. OhInspTmp.Model;
            this.Model.Id=this.Id;
            this.Model.Commentaire=this.Commentaire;
        }
        private OhInspTmpViewModel _ohInspTmp;
        [DisplayName("Inspection temporaire")]
        public virtual OhInspTmpViewModel OhInspTmp
        {
            get
            {
                return this._ohInspTmp;
            }
            set
            {
                this._ohInspTmp = value;
                RaisePropertyChange("OhInspTmp");
            }
        }
        
        private String _id;
        [DisplayName("Identifiant2")]
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
