using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnPhotoEltInspViewModel : ViewModelBase<BsnPhotoEltInsp>
    {
        public BsnPhotoEltInspViewModel(BsnPhotoEltInsp model) : base(model)
        {
        }
        public override void Read()
        {
            this.BsnEltInsp=new BsnEltInspViewModel( this.Model.BsnEltInsp);
            this.Id=this.Model.Id;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.BsnEltInsp=this. BsnEltInsp.Model;
            this.Model.Id=this.Id;
            this.Model.Commentaire=this.Commentaire;
        }
        private BsnEltInspViewModel _bsnEltInsp;
        [DisplayName("Détail Inspection")]
        public virtual BsnEltInspViewModel BsnEltInsp
        {
            get
            {
                return this._bsnEltInsp;
            }
            set
            {
                this._bsnEltInsp = value;
                RaisePropertyChange("BsnEltInsp");
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
