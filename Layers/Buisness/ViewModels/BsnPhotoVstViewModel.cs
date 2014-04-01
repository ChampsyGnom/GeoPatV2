using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnPhotoVstViewModel : ViewModelBase
    {
        public BsnPhotoVst Model {get; set;}
        public BsnPhotoVstViewModel(BsnPhotoVst model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.BsnVst=new BsnVstViewModel( this.Model.BsnVst);
            this.Id=this.Model.Id;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.BsnVst=this. BsnVst.Model;
            this.Model.Id=this.Id;
            this.Model.Commentaire=this.Commentaire;
        }
        private BsnVstViewModel _bsnVst;
        [DisplayName("Visite")]
        public virtual BsnVstViewModel BsnVst
        {
            get
            {
                return this._bsnVst;
            }
            set
            {
                this._bsnVst = value;
                RaisePropertyChange("BsnVst");
            }
        }
        
        private String _id;
        [DisplayName("photo vst BSN id")]
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
        [DisplayName("photo vst BSN commentaire")]
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
