using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhPhotoInspViewModel : ViewModelBase
    {
        public OhPhotoInsp Model {get; set;}
        public OhPhotoInspViewModel(OhPhotoInsp model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.OhInsp=new OhInspViewModel( this.Model.OhInsp);
            this.Id=this.Model.Id;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.OhInsp=this. OhInsp.Model;
            this.Model.Id=this.Id;
            this.Model.Commentaire=this.Commentaire;
        }
        private OhInspViewModel _ohInsp;
        [DisplayName("Inspection")]
        public virtual OhInspViewModel OhInsp
        {
            get
            {
                return this._ohInsp;
            }
            set
            {
                this._ohInsp = value;
                RaisePropertyChange("OhInsp");
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
