using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GmsPhotoEltInspTmpViewModel : ViewModelBase<GmsPhotoEltInspTmp>
    {
        public GmsPhotoEltInspTmpViewModel(GmsPhotoEltInspTmp model) : base(model)
        {
        }
        public override void Read()
        {
            this.GmsEltInspTmp=new GmsEltInspTmpViewModel( this.Model.GmsEltInspTmp);
            this.Id=this.Model.Id;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.GmsEltInspTmp=this. GmsEltInspTmp.Model;
            this.Model.Id=this.Id;
            this.Model.Commentaire=this.Commentaire;
        }
        private GmsEltInspTmpViewModel _gmsEltInspTmp;
        [DisplayName("Détail inspection temporaire")]
        public virtual GmsEltInspTmpViewModel GmsEltInspTmp
        {
            get
            {
                return this._gmsEltInspTmp;
            }
            set
            {
                this._gmsEltInspTmp = value;
                RaisePropertyChange("GmsEltInspTmp");
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
