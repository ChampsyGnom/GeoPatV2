using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class PrfBmUserProfilViewModel : ViewModelBase<PrfBmUserProfil>
    {
        public PrfBmUserProfilViewModel(PrfBmUserProfil model) : base(model)
        {
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
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (errors.Count > 0)
                {
                    return String.Join("\r\n",errors);
                }
                else return null;
            }
        }
        public override string this[string columnName]
        {
            get
            {
                return null;
            }
        }
    }
}
