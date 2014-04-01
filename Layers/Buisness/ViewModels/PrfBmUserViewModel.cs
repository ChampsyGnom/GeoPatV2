using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class PrfBmUserViewModel : ViewModelBase
    {
        public PrfBmUser Model {get; set;}
        public PrfBmUserViewModel(PrfBmUser model)
        {
            this.PrfBmUserProfils = new  ObservableCollection<PrfBmUserProfilViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.Login=this.Model.Login;
            this.Nom=this.Model.Nom;
            this.Prenom=this.Model.Prenom;
            this.Passwords=this.Model.Passwords;
            this.FamDecInf=this.Model.FamDecInf;
            this.CdDecInf=this.Model.CdDecInf;
        }
        public override void Write()
        {
            this.Model.Login=this.Login;
            this.Model.Nom=this.Nom;
            this.Model.Prenom=this.Prenom;
            this.Model.Passwords=this.Passwords;
            this.Model.FamDecInf=this.FamDecInf;
            this.Model.CdDecInf=this.CdDecInf;
        }
        public virtual ObservableCollection<PrfBmUserProfilViewModel> PrfBmUserProfils { get; set; }
        
        private String _login;
        [DisplayName("Domaine_Login")]
        public String Login
        {
            get
            {
                return this._login;
            }
            set
            {
                this._login = value;
                RaisePropertyChange("Login");
            }
        }
        private String _nom;
        [DisplayName("Nom")]
        public String Nom
        {
            get
            {
                return this._nom;
            }
            set
            {
                this._nom = value;
                RaisePropertyChange("Nom");
            }
        }
        private String _prenom;
        [DisplayName("Prénom")]
        public String Prenom
        {
            get
            {
                return this._prenom;
            }
            set
            {
                this._prenom = value;
                RaisePropertyChange("Prenom");
            }
        }
        private String _passwords;
        [DisplayName("Passwords")]
        public String Passwords
        {
            get
            {
                return this._passwords;
            }
            set
            {
                this._passwords = value;
                RaisePropertyChange("Passwords");
            }
        }
        private String _famDecInf;
        [DisplayName("Famille de découpage")]
        public String FamDecInf
        {
            get
            {
                return this._famDecInf;
            }
            set
            {
                this._famDecInf = value;
                RaisePropertyChange("FamDecInf");
            }
        }
        private String _cdDecInf;
        [DisplayName("Code de découpage")]
        public String CdDecInf
        {
            get
            {
                return this._cdDecInf;
            }
            set
            {
                this._cdDecInf = value;
                RaisePropertyChange("CdDecInf");
            }
        }
    }
}
