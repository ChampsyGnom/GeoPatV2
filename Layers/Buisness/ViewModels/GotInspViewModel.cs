using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotInspViewModel : ViewModelBase
    {
        public GotInsp Model {get; set;}
        public GotInspViewModel(GotInsp model)
        {
            this.GotEltInsps = new  ObservableCollection<GotEltInspViewModel>();
            
            this.GotPhotoInsps = new  ObservableCollection<GotPhotoInspViewModel>();
            
            this.GotCdConclusionInsps = new  ObservableCollection<GotCdConclusionInspViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.GotDsc=new GotDscViewModel( this.Model.GotDsc);
            this.GotCdMeteo=new GotCdMeteoViewModel( this.Model.GotCdMeteo);
            this.GotCdEtude=new GotCdEtudeViewModel( this.Model.GotCdEtude);
            this.GotCamp=new GotCampViewModel( this.Model.GotCamp);
            this.GotInspecteur=new GotInspecteurViewModel( this.Model.GotInspecteur);
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
            this.Note5=this.Model.Note5;
            this.Urgence=this.Model.Urgence;
            this.Qualite=this.Model.Qualite;
        }
        public override void Write()
        {
            this.Model.GotDsc=this. GotDsc.Model;
            this.Model.GotCdMeteo=this. GotCdMeteo.Model;
            this.Model.GotCdEtude=this. GotCdEtude.Model;
            this.Model.GotCamp=this. GotCamp.Model;
            this.Model.GotInspecteur=this. GotInspecteur.Model;
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
            this.Model.Note5=this.Note5;
            this.Model.Urgence=this.Urgence;
            this.Model.Qualite=this.Qualite;
        }
        private GotDscViewModel _gotDsc;
        [DisplayName("Terrassement")]
        public virtual GotDscViewModel GotDsc
        {
            get
            {
                return this._gotDsc;
            }
            set
            {
                this._gotDsc = value;
                RaisePropertyChange("GotDsc");
            }
        }
        
        private GotCdMeteoViewModel _gotCdMeteo;
        [DisplayName("Météo")]
        public virtual GotCdMeteoViewModel GotCdMeteo
        {
            get
            {
                return this._gotCdMeteo;
            }
            set
            {
                this._gotCdMeteo = value;
                RaisePropertyChange("GotCdMeteo");
            }
        }
        
        private GotCdEtudeViewModel _gotCdEtude;
        [DisplayName("Etude et Expertise")]
        public virtual GotCdEtudeViewModel GotCdEtude
        {
            get
            {
                return this._gotCdEtude;
            }
            set
            {
                this._gotCdEtude = value;
                RaisePropertyChange("GotCdEtude");
            }
        }
        
        private GotCampViewModel _gotCamp;
        [DisplayName("Campagne")]
        public virtual GotCampViewModel GotCamp
        {
            get
            {
                return this._gotCamp;
            }
            set
            {
                this._gotCamp = value;
                RaisePropertyChange("GotCamp");
            }
        }
        
        private GotInspecteurViewModel _gotInspecteur;
        [DisplayName("Inspecteur")]
        public virtual GotInspecteurViewModel GotInspecteur
        {
            get
            {
                return this._gotInspecteur;
            }
            set
            {
                this._gotInspecteur = value;
                RaisePropertyChange("GotInspecteur");
            }
        }
        
        public virtual ObservableCollection<GotEltInspViewModel> GotEltInsps { get; set; }
        
        public virtual ObservableCollection<GotPhotoInspViewModel> GotPhotoInsps { get; set; }
        
        public virtual ObservableCollection<GotCdConclusionInspViewModel> GotCdConclusionInsps { get; set; }
        
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
        [DisplayName("Date de validation")]
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
        [DisplayName("Note Plateforme 1")]
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
        [DisplayName("Note Plateforme 2")]
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
        [DisplayName("Note Talus 1")]
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
        [DisplayName("Note Talus 2")]
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
        [DisplayName("Note Environnement")]
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
        [DisplayName("Note urgence")]
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
        [DisplayName("Note qualité")]
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
