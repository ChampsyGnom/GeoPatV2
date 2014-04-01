using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhPhotoSprtVstViewModel : ViewModelBase
    {
        public OhPhotoSprtVst Model {get; set;}
        public OhPhotoSprtVstViewModel(OhPhotoSprtVst model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.OhSprtVst=new OhSprtVstViewModel( this.Model.OhSprtVst);
            this.Id=this.Model.Id;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.OhSprtVst=this. OhSprtVst.Model;
            this.Model.Id=this.Id;
            this.Model.Commentaire=this.Commentaire;
        }
        private OhSprtVstViewModel _ohSprtVst;
        [DisplayName("Détail visite")]
        public virtual OhSprtVstViewModel OhSprtVst
        {
            get
            {
                return this._ohSprtVst;
            }
            set
            {
                this._ohSprtVst = value;
                RaisePropertyChange("OhSprtVst");
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
