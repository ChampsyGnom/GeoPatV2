using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhPhotoVstViewModel : ViewModelBase<OhPhotoVst>
    {
        public OhPhotoVstViewModel(OhPhotoVst model) : base(model)
        {
        }
        public override void Read()
        {
            this.OhVst=new OhVstViewModel( this.Model.OhVst);
            this.Id=this.Model.Id;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.OhVst=this. OhVst.Model;
            this.Model.Id=this.Id;
            this.Model.Commentaire=this.Commentaire;
        }
        private OhVstViewModel _ohVst;
        [DisplayName("Visite")]
        public virtual OhVstViewModel OhVst
        {
            get
            {
                return this._ohVst;
            }
            set
            {
                this._ohVst = value;
                RaisePropertyChange("OhVst");
            }
        }
        
        private String _id;
        [DisplayName("photo vst oh id")]
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
        [DisplayName("photo vst oh commentaire")]
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
