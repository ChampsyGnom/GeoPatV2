using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnPhotoInspViewModel : ViewModelBase<BsnPhotoInsp>
    {
        public BsnPhotoInspViewModel(BsnPhotoInsp model) : base(model)
        {
        }
        public override void Read()
        {
            this.BsnInsp=new BsnInspViewModel( this.Model.BsnInsp);
            this.Id=this.Model.Id;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.BsnInsp=this. BsnInsp.Model;
            this.Model.Id=this.Id;
            this.Model.Commentaire=this.Commentaire;
        }
        private BsnInspViewModel _bsnInsp;
        [DisplayName("Inspection")]
        public virtual BsnInspViewModel BsnInsp
        {
            get
            {
                return this._bsnInsp;
            }
            set
            {
                this._bsnInsp = value;
                RaisePropertyChange("BsnInsp");
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
