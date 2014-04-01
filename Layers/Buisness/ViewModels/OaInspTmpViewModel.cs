using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaInspTmpViewModel : ViewModelBase<OaInspTmp>
    {
        public OaInspTmpViewModel(OaInspTmp model) : base(model)
        {
            this.OaEltInspTmps = new  ObservableCollection<OaEltInspTmpViewModel>();
            
            this.OaPhotoInspTmps = new  ObservableCollection<OaPhotoInspTmpViewModel>();
            
            this.OaCdConclusionInspTmps = new  ObservableCollection<OaCdConclusionInspTmpViewModel>();
            
        }
        public override void Read()
        {
            this.OaCdEtude=new OaCdEtudeViewModel( this.Model.OaCdEtude);
            this.OaCdMeteo=new OaCdMeteoViewModel( this.Model.OaCdMeteo);
            this.OaCdIqoa=new OaCdIqoaViewModel( this.Model.OaCdIqoa);
            this.OaDscTemp=new OaDscTempViewModel( this.Model.OaDscTemp);
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
            this.Model.OaCdEtude=this. OaCdEtude.Model;
            this.Model.OaCdMeteo=this. OaCdMeteo.Model;
            this.Model.OaCdIqoa=this. OaCdIqoa.Model;
            this.Model.OaDscTemp=this. OaDscTemp.Model;
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
        
        private OaDscTempViewModel _oaDscTemp;
        [DisplayName("Ouvrages d'Art temporaire")]
        public virtual OaDscTempViewModel OaDscTemp
        {
            get
            {
                return this._oaDscTemp;
            }
            set
            {
                this._oaDscTemp = value;
                RaisePropertyChange("OaDscTemp");
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
        
        public virtual ObservableCollection<OaEltInspTmpViewModel> OaEltInspTmps { get; set; }
        
        public virtual ObservableCollection<OaPhotoInspTmpViewModel> OaPhotoInspTmps { get; set; }
        
        public virtual ObservableCollection<OaCdConclusionInspTmpViewModel> OaCdConclusionInspTmps { get; set; }
        
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
    }
}
