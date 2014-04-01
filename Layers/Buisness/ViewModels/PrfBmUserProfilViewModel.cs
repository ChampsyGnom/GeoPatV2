using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class PrfBmUserProfilViewModel : ViewModelBase
    {
        public PrfBmUserProfil Model {get; set;}
        public PrfBmUserProfilViewModel(PrfBmUserProfil model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.PrfBmUser=new PrfBmUserViewModel( this.Model.PrfBmUser);
            this.PrfBmProfil=new PrfBmProfilViewModel( this.Model.PrfBmProfil);
        }
        public override void Write()
        {
            this.Model.PrfBmUser=this. PrfBmUser.Model;
            this.Model.PrfBmProfil=this. PrfBmProfil.Model;
        }
        private PrfBmUserViewModel _prfBmUser;
        [DisplayName("Utilisateur BM")]
        public virtual PrfBmUserViewModel PrfBmUser
        {
            get
            {
                return this._prfBmUser;
            }
            set
            {
                this._prfBmUser = value;
                RaisePropertyChange("PrfBmUser");
            }
        }
        
        private PrfBmProfilViewModel _prfBmProfil;
        [DisplayName("Profil BM")]
        public virtual PrfBmProfilViewModel PrfBmProfil
        {
            get
            {
                return this._prfBmProfil;
            }
            set
            {
                this._prfBmProfil = value;
                RaisePropertyChange("PrfBmProfil");
            }
        }
        
    }
}
