using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotPhotoInspTmpViewModel : ViewModelBase
    {
        public GotPhotoInspTmp Model {get; set;}
        public GotPhotoInspTmpViewModel(GotPhotoInspTmp model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.GotInspTmp=new GotInspTmpViewModel( this.Model.GotInspTmp);
            this.Id=this.Model.Id;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.GotInspTmp=this. GotInspTmp.Model;
            this.Model.Id=this.Id;
            this.Model.Commentaire=this.Commentaire;
        }
        private GotInspTmpViewModel _gotInspTmp;
        [DisplayName("Inspection temporaire")]
        public virtual GotInspTmpViewModel GotInspTmp
        {
            get
            {
                return this._gotInspTmp;
            }
            set
            {
                this._gotInspTmp = value;
                RaisePropertyChange("GotInspTmp");
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
