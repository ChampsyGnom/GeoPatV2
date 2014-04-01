using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhPhotoEltInspViewModel : ViewModelBase<OhPhotoEltInsp>
    {
        public OhPhotoEltInspViewModel(OhPhotoEltInsp model) : base(model)
        {
        }
        public override void Read()
        {
            this.OhEltInsp=new OhEltInspViewModel( this.Model.OhEltInsp);
            this.Id=this.Model.Id;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.OhEltInsp=this. OhEltInsp.Model;
            this.Model.Id=this.Id;
            this.Model.Commentaire=this.Commentaire;
        }
        private OhEltInspViewModel _ohEltInsp;
        [DisplayName("Détail Inspection")]
        public virtual OhEltInspViewModel OhEltInsp
        {
            get
            {
                return this._ohEltInsp;
            }
            set
            {
                this._ohEltInsp = value;
                RaisePropertyChange("OhEltInsp");
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
