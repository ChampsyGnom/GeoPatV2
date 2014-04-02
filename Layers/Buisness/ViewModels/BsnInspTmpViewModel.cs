using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnInspTmpViewModel : ViewModelBase<BsnInspTmp>
    {
        public BsnInspTmpViewModel(BsnInspTmp model) : base(model)
        {
            this.BsnPhotoInspTmps = new  ObservableCollection<BsnPhotoInspTmpViewModel>();
            
            this.BsnEltInspTmps = new  ObservableCollection<BsnEltInspTmpViewModel>();
            
            this.BsnCdConclusionInspTmps = new  ObservableCollection<BsnCdConclusionInspTmpViewModel>();
            
        }
        public override void Read()
        {
            this.BsnCdEtude=new BsnCdEtudeViewModel( this.Model.BsnCdEtude);
            this.BsnCdMeteo=new BsnCdMeteoViewModel( this.Model.BsnCdMeteo);
            this.BsnDscTemp=new BsnDscTempViewModel( this.Model.BsnDscTemp);
            this.BsnInspecteur=new BsnInspecteurViewModel( this.Model.BsnInspecteur);
            this.Etat=this.Model.Etat;
            this.Datev=this.Model.Datev;
            this.Temperature=this.Model.Temperature;
            this.Moyen=this.Model.Moyen;
            this.Conditions=this.Model.Conditions;
            this.DateValid=this.Model.DateValid;
            this.NomValid=this.Model.NomValid;
            this.DescInva=this.Model.DescInva;
            this.Securite=this.Model.Securite;
            this.Prioritaire=this.Model.Prioritaire;
            this.Note1=this.Model.Note1;
            this.Note2=this.Model.Note2;
            this.Note3=this.Model.Note3;
            this.Note4=this.Model.Note4;
            this.Urgence=this.Model.Urgence;
            this.Qualite=this.Model.Qualite;
        }
        public override void Write()
        {
            this.Model.BsnCdEtude=this. BsnCdEtude.Model;
            this.Model.BsnCdMeteo=this. BsnCdMeteo.Model;
            this.Model.BsnDscTemp=this. BsnDscTemp.Model;
            this.Model.BsnInspecteur=this. BsnInspecteur.Model;
            this.Model.Etat=this.Etat;
            this.Model.Datev=this.Datev;
            this.Model.Temperature=this.Temperature;
            this.Model.Moyen=this.Moyen;
            this.Model.Conditions=this.Conditions;
            this.Model.DateValid=this.DateValid;
            this.Model.NomValid=this.NomValid;
            this.Model.DescInva=this.DescInva;
            this.Model.Securite=this.Securite;
            this.Model.Prioritaire=this.Prioritaire;
            this.Model.Note1=this.Note1;
            this.Model.Note2=this.Note2;
            this.Model.Note3=this.Note3;
            this.Model.Note4=this.Note4;
            this.Model.Urgence=this.Urgence;
            this.Model.Qualite=this.Qualite;
        }
        private BsnCdEtudeViewModel _bsnCdEtude;
        [DisplayName("Etude et Expertise")]
        public virtual BsnCdEtudeViewModel BsnCdEtude
        {
            get
            {
                return this._bsnCdEtude;
            }
            set
            {
                this._bsnCdEtude = value;
                RaisePropertyChange("BsnCdEtude");
            }
        }
        
        private BsnCdMeteoViewModel _bsnCdMeteo;
        [DisplayName("Météo")]
        public virtual BsnCdMeteoViewModel BsnCdMeteo
        {
            get
            {
                return this._bsnCdMeteo;
            }
            set
            {
                this._bsnCdMeteo = value;
                RaisePropertyChange("BsnCdMeteo");
            }
        }
        
        private BsnDscTempViewModel _bsnDscTemp;
        [DisplayName("Bassin temporaire")]
        public virtual BsnDscTempViewModel BsnDscTemp
        {
            get
            {
                return this._bsnDscTemp;
            }
            set
            {
                this._bsnDscTemp = value;
                RaisePropertyChange("BsnDscTemp");
            }
        }
        
        private BsnInspecteurViewModel _bsnInspecteur;
        [DisplayName("Inspecteur")]
        public virtual BsnInspecteurViewModel BsnInspecteur
        {
            get
            {
                return this._bsnInspecteur;
            }
            set
            {
                this._bsnInspecteur = value;
                RaisePropertyChange("BsnInspecteur");
            }
        }
        
        public virtual ObservableCollection<BsnPhotoInspTmpViewModel> BsnPhotoInspTmps { get; set; }
        
        public virtual ObservableCollection<BsnEltInspTmpViewModel> BsnEltInspTmps { get; set; }
        
        public virtual ObservableCollection<BsnCdConclusionInspTmpViewModel> BsnCdConclusionInspTmps { get; set; }
        
        private String _etat;
        [DisplayName("Statut visite")]
        public String Etat
        {
            get
            {
                return this._etat;
            }
            set
            {
                this._etat = value;
                RaisePropertyChange("Etat");
            }
        }
        private Nullable<DateTime> _datev;
        [DisplayName("Date de visite")]
        public Nullable<DateTime> Datev
        {
            get
            {
                return this._datev;
            }
            set
            {
                this._datev = value;
                RaisePropertyChange("Datev");
            }
        }
        
        private Nullable<Double> _temperature;
        [DisplayName("Température")]
        public Nullable<Double> Temperature
        {
            get
            {
                return this._temperature;
            }
            set
            {
                this._temperature = value;
                RaisePropertyChange("Temperature");
            }
        }
        
        private String _moyen;
        [DisplayName("Moyen utilisé")]
        public String Moyen
        {
            get
            {
                return this._moyen;
            }
            set
            {
                this._moyen = value;
                RaisePropertyChange("Moyen");
            }
        }
        private String _conditions;
        [DisplayName("Condition particulière")]
        public String Conditions
        {
            get
            {
                return this._conditions;
            }
            set
            {
                this._conditions = value;
                RaisePropertyChange("Conditions");
            }
        }
        private Nullable<DateTime> _dateValid;
        [DisplayName("Date Validation")]
        public Nullable<DateTime> DateValid
        {
            get
            {
                return this._dateValid;
            }
            set
            {
                this._dateValid = value;
                RaisePropertyChange("DateValid");
            }
        }
        
        private String _nomValid;
        [DisplayName("Nom Valideur")]
        public String NomValid
        {
            get
            {
                return this._nomValid;
            }
            set
            {
                this._nomValid = value;
                RaisePropertyChange("NomValid");
            }
        }
        private String _descInva;
        [DisplayName("Description invalide")]
        public String DescInva
        {
            get
            {
                return this._descInva;
            }
            set
            {
                this._descInva = value;
                RaisePropertyChange("DescInva");
            }
        }
        private String _securite;
        [DisplayName("Problème de sécurité")]
        public String Securite
        {
            get
            {
                return this._securite;
            }
            set
            {
                this._securite = value;
                RaisePropertyChange("Securite");
            }
        }
        private String _prioritaire;
        [DisplayName("Urgence traitement")]
        public String Prioritaire
        {
            get
            {
                return this._prioritaire;
            }
            set
            {
                this._prioritaire = value;
                RaisePropertyChange("Prioritaire");
            }
        }
        private Nullable<Int64> _note1;
        [DisplayName("Note Structure")]
        public Nullable<Int64> Note1
        {
            get
            {
                return this._note1;
            }
            set
            {
                this._note1 = value;
                RaisePropertyChange("Note1");
            }
        }
        
        private Nullable<Int64> _note2;
        [DisplayName("Note Equipements")]
        public Nullable<Int64> Note2
        {
            get
            {
                return this._note2;
            }
            set
            {
                this._note2 = value;
                RaisePropertyChange("Note2");
            }
        }
        
        private Nullable<Int64> _note3;
        [DisplayName("Note Abords-Végétation")]
        public Nullable<Int64> Note3
        {
            get
            {
                return this._note3;
            }
            set
            {
                this._note3 = value;
                RaisePropertyChange("Note3");
            }
        }
        
        private Nullable<Int64> _note4;
        [DisplayName("Note Sécurité")]
        public Nullable<Int64> Note4
        {
            get
            {
                return this._note4;
            }
            set
            {
                this._note4 = value;
                RaisePropertyChange("Note4");
            }
        }
        
        private String _urgence;
        [DisplayName("Niveau Urgence")]
        public String Urgence
        {
            get
            {
                return this._urgence;
            }
            set
            {
                this._urgence = value;
                RaisePropertyChange("Urgence");
            }
        }
        private String _qualite;
        [DisplayName("Image qualité")]
        public String Qualite
        {
            get
            {
                return this._qualite;
            }
            set
            {
                this._qualite = value;
                RaisePropertyChange("Qualite");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Etat"] != null)
                {
                    errors.Add("Statut visite : "+this["Etat"]);
                }
                if (this["Datev"] != null)
                {
                    errors.Add("Date de visite : "+this["Datev"]);
                }
                if (this["Temperature"] != null)
                {
                    errors.Add("Température : "+this["Temperature"]);
                }
                if (this["Moyen"] != null)
                {
                    errors.Add("Moyen utilisé : "+this["Moyen"]);
                }
                if (this["Conditions"] != null)
                {
                    errors.Add("Condition particulière : "+this["Conditions"]);
                }
                if (this["DateValid"] != null)
                {
                    errors.Add("Date Validation : "+this["DateValid"]);
                }
                if (this["NomValid"] != null)
                {
                    errors.Add("Nom Valideur : "+this["NomValid"]);
                }
                if (this["DescInva"] != null)
                {
                    errors.Add("Description invalide : "+this["DescInva"]);
                }
                if (this["Securite"] != null)
                {
                    errors.Add("Problème de sécurité : "+this["Securite"]);
                }
                if (this["Prioritaire"] != null)
                {
                    errors.Add("Urgence traitement : "+this["Prioritaire"]);
                }
                if (this["Note1"] != null)
                {
                    errors.Add("Note Structure : "+this["Note1"]);
                }
                if (this["Note2"] != null)
                {
                    errors.Add("Note Equipements : "+this["Note2"]);
                }
                if (this["Note3"] != null)
                {
                    errors.Add("Note Abords-Végétation : "+this["Note3"]);
                }
                if (this["Note4"] != null)
                {
                    errors.Add("Note Sécurité : "+this["Note4"]);
                }
                if (this["Urgence"] != null)
                {
                    errors.Add("Niveau Urgence : "+this["Urgence"]);
                }
                if (this["Qualite"] != null)
                {
                    errors.Add("Image qualité : "+this["Qualite"]);
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
                if (columnName.Equals("Etat"))
                {
                    if (String.IsNullOrEmpty(this.Etat))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("Datev"))
                {
                }
                if (columnName.Equals("Temperature"))
                {
                }
                if (columnName.Equals("Moyen"))
                {
                }
                if (columnName.Equals("Conditions"))
                {
                }
                if (columnName.Equals("DateValid"))
                {
                }
                if (columnName.Equals("NomValid"))
                {
                }
                if (columnName.Equals("DescInva"))
                {
                }
                if (columnName.Equals("Securite"))
                {
                }
                if (columnName.Equals("Prioritaire"))
                {
                }
                if (columnName.Equals("Note1"))
                {
                }
                if (columnName.Equals("Note2"))
                {
                }
                if (columnName.Equals("Note3"))
                {
                }
                if (columnName.Equals("Note4"))
                {
                }
                if (columnName.Equals("Urgence"))
                {
                }
                if (columnName.Equals("Qualite"))
                {
                }
                return null;
            }
        }
    }
}
