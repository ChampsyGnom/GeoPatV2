using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnPhotoSprtVstViewModel : ViewModelBase<BsnPhotoSprtVst>
    {
        public BsnPhotoSprtVstViewModel(BsnPhotoSprtVst model) : base(model)
        {
        }
        public override void Read()
        {
            this.BsnSprtVst=new BsnSprtVstViewModel( this.Model.BsnSprtVst);
            this.Id=this.Model.Id;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.BsnSprtVst=this. BsnSprtVst.Model;
            this.Model.Id=this.Id;
            this.Model.Commentaire=this.Commentaire;
        }
        private BsnSprtVstViewModel _bsnSprtVst;
        [DisplayName("Détail visite")]
        public virtual BsnSprtVstViewModel BsnSprtVst
        {
            get
            {
                return this._bsnSprtVst;
            }
            set
            {
                this._bsnSprtVst = value;
                RaisePropertyChange("BsnSprtVst");
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
