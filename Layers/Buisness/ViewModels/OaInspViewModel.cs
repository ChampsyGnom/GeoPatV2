using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaInspViewModel : ViewModelBase<OaInsp>
    {
        public OaInspViewModel(OaInsp model) : base(model)
        {
            this.OaEltInsps = new  ObservableCollection<OaEltInspViewModel>();
            
            this.OaPhotoInsps = new  ObservableCollection<OaPhotoInspViewModel>();
            
            this.OaCdConclusionInsps = new  ObservableCollection<OaCdConclusionInspViewModel>();
            
        }
        public override void Read()
        {
            this.OaDsc=new OaDscViewModel( this.Model.OaDsc);
            this.OaCdMeteo=new OaCdMeteoViewModel( this.Model.OaCdMeteo);
            this.OaCdEtude=new OaCdEtudeViewModel( this.Model.OaCdEtude);
            this.OaCdIqoa=new OaCdIqoaViewModel( this.Model.OaCdIqoa);
            this.OaCamp=new OaCampViewModel( this.Model.OaCamp);
            this.OaInspecteur=new OaInspecteurViewModel( this.Model.OaInspecteur);
            this.Etat=this.Model.Etat;
            this.Datev=this.Model.Datev;
            this.Temperature=this.Model.Temperature;
            this.Moyen=this.Model.Moyen;
            this.Conditions=this.Model.Conditions;
            this.DateValid=this.Model.DateValid;
            this.NomValid=this.Model.NomValid;
            this.DescInva=this.Model.DescInva;
            this.Prioritaire=this.Model.Prioritaire;
            this.Securite=this.Model.Securite;
            this.Note1=this.Model.Note1;
            this.Note2=this.Model.Note2;
            this.Note3=this.Model.Note3;
            this.Urgence=this.Model.Urgence;
            this.Qualite=this.Model.Qualite;
        }
        public override void Write()
        {
            this.Model.OaDsc=this. OaDsc.Model;
            this.Model.OaCdMeteo=this. OaCdMeteo.Model;
            this.Model.OaCdEtude=this. OaCdEtude.Model;
            this.Model.OaCdIqoa=this. OaCdIqoa.Model;
            this.Model.OaCamp=this. OaCamp.Model;
            this.Model.OaInspecteur=this. OaInspecteur.Model;
            this.Model.Etat=this.Etat;
            this.Model.Datev=this.Datev;
            this.Model.Temperature=this.Temperature;
            this.Model.Moyen=this.Moyen;
            this.Model.Conditions=this.Conditions;
            this.Model.DateValid=this.DateValid;
            this.Model.NomValid=this.NomValid;
            this.Model.DescInva=this.DescInva;
            this.Model.Prioritaire=this.Prioritaire;
            this.Model.Securite=this.Securite;
            this.Model.Note1=this.Note1;
            this.Model.Note2=this.Note2;
            this.Model.Note3=this.Note3;
            this.Model.Urgence=this.Urgence;
            this.Model.Qualite=this.Qualite;
        }
        private OaDscViewModel _oaDsc;
        [DisplayName("Ouvrages d'Art")]
        public virtual OaDscViewModel OaDsc
        {
            get
            {
                return this._oaDsc;
            }
            set
            {
                this._oaDsc = value;
                RaisePropertyChange("OaDsc");
            }
        }
        
        private OaCdMeteoViewModel _oaCdMeteo;
        [DisplayName("Météo")]
        public virtual OaCdMeteoViewModel OaCdMeteo
        {
            get
            {
                return this._oaCdMeteo;
            }
            set
            {
                this._oaCdMeteo = value;
                RaisePropertyChange("OaCdMeteo");
            }
        }
        
        private OaCdEtudeViewModel _oaCdEtude;
        [DisplayName("Etude et Expertise")]
        public virtual OaCdEtudeViewModel OaCdEtude
        {
            get
            {
                return this._oaCdEtude;
            }
            set
            {
                this._oaCdEtude = value;
                RaisePropertyChange("OaCdEtude");
            }
        }
        
        private OaCdIqoaViewModel _oaCdIqoa;
        [DisplayName("Code IQOA")]
        public virtual OaCdIqoaViewModel OaCdIqoa
        {
            get
            {
                return this._oaCdIqoa;
            }
            set
            {
                this._oaCdIqoa = value;
                RaisePropertyChange("OaCdIqoa");
            }
        }
        
        private OaCampViewModel _oaCamp;
        [DisplayName("Campagne")]
        public virtual OaCampViewModel OaCamp
        {
            get
            {
                return this._oaCamp;
            }
            set
            {
                this._oaCamp = value;
                RaisePropertyChange("OaCamp");
            }
        }
        
        private OaInspecteurViewModel _oaInspecteur;
        [DisplayName("Inspecteur")]
        public virtual OaInspecteurViewModel OaInspecteur
        {
            get
            {
                return this._oaInspecteur;
            }
            set
            {
                this._oaInspecteur = value;
                RaisePropertyChange("OaInspecteur");
            }
        }
        
        public virtual ObservableCollection<OaEltInspViewModel> OaEltInsps { get; set; }
        
        public virtual ObservableCollection<OaPhotoInspViewModel> OaPhotoInsps { get; set; }
        
        public virtual ObservableCollection<OaCdConclusionInspViewModel> OaCdConclusionInsps { get; set; }
        
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
        [DisplayName("Moyens utilisés")]
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
        [DisplayName("Conditions particulières")]
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
        [DisplayName("Date validation")]
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
        [DisplayName("Nom valideur")]
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
        private Nullable<Int64> _note1;
        [DisplayName("Appuis-Fondations")]
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
        [DisplayName("Tabliers")]
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
        [DisplayName("Equipements")]
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
        
        private String _urgence;
        [DisplayName("Niveau urgence")]
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
                    errors.Add("Moyens utilisés : "+this["Moyen"]);
                }
                if (this["Conditions"] != null)
                {
                    errors.Add("Conditions particulières : "+this["Conditions"]);
                }
                if (this["DateValid"] != null)
                {
                    errors.Add("Date validation : "+this["DateValid"]);
                }
                if (this["NomValid"] != null)
                {
                    errors.Add("Nom valideur : "+this["NomValid"]);
                }
                if (this["DescInva"] != null)
                {
                    errors.Add("Description invalide : "+this["DescInva"]);
                }
                if (this["Prioritaire"] != null)
                {
                    errors.Add("Urgence traitement : "+this["Prioritaire"]);
                }
                if (this["Securite"] != null)
                {
                    errors.Add("Problème de sécurité : "+this["Securite"]);
                }
                if (this["Note1"] != null)
                {
                    errors.Add("Appuis-Fondations : "+this["Note1"]);
                }
                if (this["Note2"] != null)
                {
                    errors.Add("Tabliers : "+this["Note2"]);
                }
                if (this["Note3"] != null)
                {
                    errors.Add("Equipements : "+this["Note3"]);
                }
                if (this["Urgence"] != null)
                {
                    errors.Add("Niveau urgence : "+this["Urgence"]);
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
                if (columnName.Equals("Prioritaire"))
                {
                }
                if (columnName.Equals("Securite"))
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
