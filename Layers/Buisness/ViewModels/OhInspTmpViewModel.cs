using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhInspTmpViewModel : ViewModelBase<OhInspTmp>
    {
        public OhInspTmpViewModel(OhInspTmp model) : base(model)
        {
            this.OhEltInspTmps = new  ObservableCollection<OhEltInspTmpViewModel>();
            
            this.OhPhotoInspTmps = new  ObservableCollection<OhPhotoInspTmpViewModel>();
            
            this.OhCdConclusionInspTmps = new  ObservableCollection<OhCdConclusionInspTmpViewModel>();
            
        }
        public override void Read()
        {
            this.OhCdMeteo=new OhCdMeteoViewModel( this.Model.OhCdMeteo);
            this.OhCdEtude=new OhCdEtudeViewModel( this.Model.OhCdEtude);
            this.OhDscTemp=new OhDscTempViewModel( this.Model.OhDscTemp);
            this.OhInspecteur=new OhInspecteurViewModel( this.Model.OhInspecteur);
            this.Etat=this.Model.Etat;
            this.Datev=this.Model.Datev;
            this.Temperature=this.Model.Temperature;
            this.Moyen=this.Model.Moyen;
            this.Conditions=this.Model.Conditions;
            this.NomValid=this.Model.NomValid;
            this.DateValid=this.Model.DateValid;
            this.DescInva=this.Model.DescInva;
            this.Prioritaire=this.Model.Prioritaire;
            this.Securite=this.Model.Securite;
            this.Note1=this.Model.Note1;
            this.Note2=this.Model.Note2;
            this.Note3=this.Model.Note3;
            this.Note4=this.Model.Note4;
            this.Note5=this.Model.Note5;
            this.Urgence=this.Model.Urgence;
            this.Qualite=this.Model.Qualite;
        }
        public override void Write()
        {
            this.Model.OhCdMeteo=this. OhCdMeteo.Model;
            this.Model.OhCdEtude=this. OhCdEtude.Model;
            this.Model.OhDscTemp=this. OhDscTemp.Model;
            this.Model.OhInspecteur=this. OhInspecteur.Model;
            this.Model.Etat=this.Etat;
            this.Model.Datev=this.Datev;
            this.Model.Temperature=this.Temperature;
            this.Model.Moyen=this.Moyen;
            this.Model.Conditions=this.Conditions;
            this.Model.NomValid=this.NomValid;
            this.Model.DateValid=this.DateValid;
            this.Model.DescInva=this.DescInva;
            this.Model.Prioritaire=this.Prioritaire;
            this.Model.Securite=this.Securite;
            this.Model.Note1=this.Note1;
            this.Model.Note2=this.Note2;
            this.Model.Note3=this.Note3;
            this.Model.Note4=this.Note4;
            this.Model.Note5=this.Note5;
            this.Model.Urgence=this.Urgence;
            this.Model.Qualite=this.Qualite;
        }
        private OhCdMeteoViewModel _ohCdMeteo;
        [DisplayName("Météo")]
        public virtual OhCdMeteoViewModel OhCdMeteo
        {
            get
            {
                return this._ohCdMeteo;
            }
            set
            {
                this._ohCdMeteo = value;
                RaisePropertyChange("OhCdMeteo");
            }
        }
        
        private OhCdEtudeViewModel _ohCdEtude;
        [DisplayName("Etude et Expertise")]
        public virtual OhCdEtudeViewModel OhCdEtude
        {
            get
            {
                return this._ohCdEtude;
            }
            set
            {
                this._ohCdEtude = value;
                RaisePropertyChange("OhCdEtude");
            }
        }
        
        private OhDscTempViewModel _ohDscTemp;
        [DisplayName("Ouvrage Hydraulique temporaire")]
        public virtual OhDscTempViewModel OhDscTemp
        {
            get
            {
                return this._ohDscTemp;
            }
            set
            {
                this._ohDscTemp = value;
                RaisePropertyChange("OhDscTemp");
            }
        }
        
        private OhInspecteurViewModel _ohInspecteur;
        [DisplayName("Inspecteur")]
        public virtual OhInspecteurViewModel OhInspecteur
        {
            get
            {
                return this._ohInspecteur;
            }
            set
            {
                this._ohInspecteur = value;
                RaisePropertyChange("OhInspecteur");
            }
        }
        
        public virtual ObservableCollection<OhEltInspTmpViewModel> OhEltInspTmps { get; set; }
        
        public virtual ObservableCollection<OhPhotoInspTmpViewModel> OhPhotoInspTmps { get; set; }
        
        public virtual ObservableCollection<OhCdConclusionInspTmpViewModel> OhCdConclusionInspTmps { get; set; }
        
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
        [DisplayName("Abords amont")]
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
        [DisplayName("Protection amont")]
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
        [DisplayName("Conduit")]
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
        [DisplayName("Protection aval")]
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
        
        private Nullable<Int64> _note5;
        [DisplayName("Abordst aval")]
        public Nullable<Int64> Note5
        {
            get
            {
                return this._note5;
            }
            set
            {
                this._note5 = value;
                RaisePropertyChange("Note5");
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
    }
}
