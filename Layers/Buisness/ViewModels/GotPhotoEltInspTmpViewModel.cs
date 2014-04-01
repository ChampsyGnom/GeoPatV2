using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotPhotoEltInspTmpViewModel : ViewModelBase
    {
        public GotPhotoEltInspTmp Model {get; set;}
        public GotPhotoEltInspTmpViewModel(GotPhotoEltInspTmp model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.GotEltInspTmp=new GotEltInspTmpViewModel( this.Model.GotEltInspTmp);
            this.Id=this.Model.Id;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.GotEltInspTmp=this. GotEltInspTmp.Model;
            this.Model.Id=this.Id;
            this.Model.Commentaire=this.Commentaire;
        }
        private GotEltInspTmpViewModel _gotEltInspTmp;
        [DisplayName("Détail Inspection temporaire")]
        public virtual GotEltInspTmpViewModel GotEltInspTmp
        {
            get
            {
                return this._gotEltInspTmp;
            }
            set
            {
                this._gotEltInspTmp = value;
                RaisePropertyChange("GotEltInspTmp");
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
