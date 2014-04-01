using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GmsPhotoSprtVstViewModel : ViewModelBase<GmsPhotoSprtVst>
    {
        public GmsPhotoSprtVstViewModel(GmsPhotoSprtVst model) : base(model)
        {
        }
        public override void Read()
        {
            this.GmsSprtVst=new GmsSprtVstViewModel( this.Model.GmsSprtVst);
            this.Id=this.Model.Id;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.GmsSprtVst=this. GmsSprtVst.Model;
            this.Model.Id=this.Id;
            this.Model.Commentaire=this.Commentaire;
        }
        private GmsSprtVstViewModel _gmsSprtVst;
        [DisplayName("Détail visite")]
        public virtual GmsSprtVstViewModel GmsSprtVst
        {
            get
            {
                return this._gmsSprtVst;
            }
            set
            {
                this._gmsSprtVst = value;
                RaisePropertyChange("GmsSprtVst");
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
