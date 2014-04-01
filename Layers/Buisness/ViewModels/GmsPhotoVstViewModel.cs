using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GmsPhotoVstViewModel : ViewModelBase<GmsPhotoVst>
    {
        public GmsPhotoVstViewModel(GmsPhotoVst model) : base(model)
        {
        }
        public override void Read()
        {
            this.GmsVst=new GmsVstViewModel( this.Model.GmsVst);
            this.Id=this.Model.Id;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.GmsVst=this. GmsVst.Model;
            this.Model.Id=this.Id;
            this.Model.Commentaire=this.Commentaire;
        }
        private GmsVstViewModel _gmsVst;
        [DisplayName("Visite")]
        public virtual GmsVstViewModel GmsVst
        {
            get
            {
                return this._gmsVst;
            }
            set
            {
                this._gmsVst = value;
                RaisePropertyChange("GmsVst");
            }
        }
        
        private String _id;
        [DisplayName("Id photo")]
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
        [DisplayName("Commentaire photo")]
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
