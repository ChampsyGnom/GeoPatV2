using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GmsPhotoEltInspViewModel : ViewModelBase
    {
        public GmsPhotoEltInsp Model {get; set;}
        public GmsPhotoEltInspViewModel(GmsPhotoEltInsp model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.GmsEltInsp=new GmsEltInspViewModel( this.Model.GmsEltInsp);
            this.Id=this.Model.Id;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.GmsEltInsp=this. GmsEltInsp.Model;
            this.Model.Id=this.Id;
            this.Model.Commentaire=this.Commentaire;
        }
        private GmsEltInspViewModel _gmsEltInsp;
        [DisplayName("Détail inspection")]
        public virtual GmsEltInspViewModel GmsEltInsp
        {
            get
            {
                return this._gmsEltInsp;
            }
            set
            {
                this._gmsEltInsp = value;
                RaisePropertyChange("GmsEltInsp");
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
