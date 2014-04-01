using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnPhotoInspTmpViewModel : ViewModelBase
    {
        public BsnPhotoInspTmp Model {get; set;}
        public BsnPhotoInspTmpViewModel(BsnPhotoInspTmp model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.BsnInspTmp=new BsnInspTmpViewModel( this.Model.BsnInspTmp);
            this.Id=this.Model.Id;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.BsnInspTmp=this. BsnInspTmp.Model;
            this.Model.Id=this.Id;
            this.Model.Commentaire=this.Commentaire;
        }
        private BsnInspTmpViewModel _bsnInspTmp;
        [DisplayName("Inspection temporaire")]
        public virtual BsnInspTmpViewModel BsnInspTmp
        {
            get
            {
                return this._bsnInspTmp;
            }
            set
            {
                this._bsnInspTmp = value;
                RaisePropertyChange("BsnInspTmp");
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
