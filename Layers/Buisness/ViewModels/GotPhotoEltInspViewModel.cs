using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotPhotoEltInspViewModel : ViewModelBase
    {
        public GotPhotoEltInsp Model {get; set;}
        public GotPhotoEltInspViewModel(GotPhotoEltInsp model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.GotEltInsp=new GotEltInspViewModel( this.Model.GotEltInsp);
            this.Id=this.Model.Id;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.GotEltInsp=this. GotEltInsp.Model;
            this.Model.Id=this.Id;
            this.Model.Commentaire=this.Commentaire;
        }
        private GotEltInspViewModel _gotEltInsp;
        [DisplayName("Détail Inspection")]
        public virtual GotEltInspViewModel GotEltInsp
        {
            get
            {
                return this._gotEltInsp;
            }
            set
            {
                this._gotEltInsp = value;
                RaisePropertyChange("GotEltInsp");
            }
        }
        
        private String _id;
        [DisplayName("Identifiant")]
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
