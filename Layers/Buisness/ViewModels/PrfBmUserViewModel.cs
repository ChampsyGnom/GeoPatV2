using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class PrfBmUserViewModel : ViewModelBase<PrfBmUser>
    {
        public PrfBmUserViewModel(PrfBmUser model) : base(model)
        {
            this.PrfBmUserProfils = new  ObservableCollection<PrfBmUserProfilViewModel>();
            
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
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Login"] != null)
                {
                    errors.Add("Domaine_Login : "+this["Login"]);
                }
                if (this["Nom"] != null)
                {
                    errors.Add("Nom : "+this["Nom"]);
                }
                if (this["Prenom"] != null)
                {
                    errors.Add("Prénom : "+this["Prenom"]);
                }
                if (this["Passwords"] != null)
                {
                    errors.Add("Passwords : "+this["Passwords"]);
                }
                if (this["FamDecInf"] != null)
                {
                    errors.Add("Famille de découpage : "+this["FamDecInf"]);
                }
                if (this["CdDecInf"] != null)
                {
                    errors.Add("Code de découpage : "+this["CdDecInf"]);
                }
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
                if (columnName.Equals("Login"))
                {
                    if (String.IsNullOrEmpty(this.Login))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("Nom"))
                {
                }
                if (columnName.Equals("Prenom"))
                {
                }
                if (columnName.Equals("Passwords"))
                {
                }
                if (columnName.Equals("FamDecInf"))
                {
                }
                if (columnName.Equals("CdDecInf"))
                {
                }
                return null;
            }
        }
    }
}
