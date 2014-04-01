using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotPhotoInspViewModel : ViewModelBase
    {
        public GotPhotoInsp Model {get; set;}
        public GotPhotoInspViewModel(GotPhotoInsp model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.GotInsp=new GotInspViewModel( this.Model.GotInsp);
            this.Id=this.Model.Id;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.GotInsp=this. GotInsp.Model;
            this.Model.Id=this.Id;
            this.Model.Commentaire=this.Commentaire;
        }
        private GotInspViewModel _gotInsp;
        [DisplayName("Inspection")]
        public virtual GotInspViewModel GotInsp
        {
            get
            {
                return this._gotInsp;
            }
            set
            {
                this._gotInsp = value;
                RaisePropertyChange("GotInsp");
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
