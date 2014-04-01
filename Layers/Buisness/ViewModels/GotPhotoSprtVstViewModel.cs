using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotPhotoSprtVstViewModel : ViewModelBase<GotPhotoSprtVst>
    {
        public GotPhotoSprtVstViewModel(GotPhotoSprtVst model) : base(model)
        {
        }
        public override void Read()
        {
            this.GotSprtVst=new GotSprtVstViewModel( this.Model.GotSprtVst);
            this.Id=this.Model.Id;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.GotSprtVst=this. GotSprtVst.Model;
            this.Model.Id=this.Id;
            this.Model.Commentaire=this.Commentaire;
        }
        private GotSprtVstViewModel _gotSprtVst;
        [DisplayName("Détail visite")]
        public virtual GotSprtVstViewModel GotSprtVst
        {
            get
            {
                return this._gotSprtVst;
            }
            set
            {
                this._gotSprtVst = value;
                RaisePropertyChange("GotSprtVst");
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
