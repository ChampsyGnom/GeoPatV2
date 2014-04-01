using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotPhotoVstViewModel : ViewModelBase
    {
        public GotPhotoVst Model {get; set;}
        public GotPhotoVstViewModel(GotPhotoVst model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.GotVst=new GotVstViewModel( this.Model.GotVst);
            this.Id=this.Model.Id;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.GotVst=this. GotVst.Model;
            this.Model.Id=this.Id;
            this.Model.Commentaire=this.Commentaire;
        }
        private GotVstViewModel _gotVst;
        [DisplayName("Visite")]
        public virtual GotVstViewModel GotVst
        {
            get
            {
                return this._gotVst;
            }
            set
            {
                this._gotVst = value;
                RaisePropertyChange("GotVst");
            }
        }
        
        private String _id;
        [DisplayName("Id photo vst")]
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
        [DisplayName("photo vst commentaire")]
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
