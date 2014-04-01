using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhPhotoEltInspTmpViewModel : ViewModelBase
    {
        public OhPhotoEltInspTmp Model {get; set;}
        public OhPhotoEltInspTmpViewModel(OhPhotoEltInspTmp model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.OhEltInspTmp=new OhEltInspTmpViewModel( this.Model.OhEltInspTmp);
            this.Id=this.Model.Id;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.OhEltInspTmp=this. OhEltInspTmp.Model;
            this.Model.Id=this.Id;
            this.Model.Commentaire=this.Commentaire;
        }
        private OhEltInspTmpViewModel _ohEltInspTmp;
        [DisplayName("Détail Inspection temporaire")]
        public virtual OhEltInspTmpViewModel OhEltInspTmp
        {
            get
            {
                return this._ohEltInspTmp;
            }
            set
            {
                this._ohEltInspTmp = value;
                RaisePropertyChange("OhEltInspTmp");
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
