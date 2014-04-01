using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfDscOaViewModel : ViewModelBase
    {
        public InfDscOa Model {get; set;}
        public InfDscOaViewModel(InfDscOa model)
        {
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.CodeOa=this.Model.CodeOa;
            this.NumOa=this.Model.NumOa;
            this.Liaison=this.Model.Liaison;
            this.Sens=this.Model.Sens;
            this.PrOa=this.Model.PrOa;
            this.AbsDeb=this.Model.AbsDeb;
            this.NumExploit=this.Model.NumExploit;
            this.NomUsage=this.Model.NomUsage;
            this.Famille=this.Model.Famille;
            this.TypeOuvrage=this.Model.TypeOuvrage;
            this.Materiaux=this.Model.Materiaux;
            this.DateMs=this.Model.DateMs;
            this.NbreTabliers=this.Model.NbreTabliers;
            this.NbreTravee=this.Model.NbreTravee;
            this.Gabarit=this.Model.Gabarit;
            this.Longueur=this.Model.Longueur;
            this.Largeur=this.Model.Largeur;
            this.SectCourante=this.Model.SectCourante;
            this.Iqoa=this.Model.Iqoa;
            this.NoteUrgence=this.Model.NoteUrgence;
        }
        public override void Write()
        {
            this.Model.CodeOa=this.CodeOa;
            this.Model.NumOa=this.NumOa;
            this.Model.Liaison=this.Liaison;
            this.Model.Sens=this.Sens;
            this.Model.PrOa=this.PrOa;
            this.Model.AbsDeb=this.AbsDeb;
            this.Model.NumExploit=this.NumExploit;
            this.Model.NomUsage=this.NomUsage;
            this.Model.Famille=this.Famille;
            this.Model.TypeOuvrage=this.TypeOuvrage;
            this.Model.Materiaux=this.Materiaux;
            this.Model.DateMs=this.DateMs;
            this.Model.NbreTabliers=this.NbreTabliers;
            this.Model.NbreTravee=this.NbreTravee;
            this.Model.Gabarit=this.Gabarit;
            this.Model.Longueur=this.Longueur;
            this.Model.Largeur=this.Largeur;
            this.Model.SectCourante=this.SectCourante;
            this.Model.Iqoa=this.Iqoa;
            this.Model.NoteUrgence=this.NoteUrgence;
        }
        private Int64 _codeOa;
        [DisplayName("IDOA")]
        public Int64 CodeOa
        {
            get
            {
                return this._codeOa;
            }
            set
            {
                this._codeOa = value;
                RaisePropertyChange("CodeOa");
            }
        }
        
        private String _numOa;
        [DisplayName("NumOA")]
        public String NumOa
        {
            get
            {
                return this._numOa;
            }
            set
            {
                this._numOa = value;
                RaisePropertyChange("NumOa");
            }
        }
        private String _liaison;
        [DisplayName("Liaison")]
        public String Liaison
        {
            get
            {
                return this._liaison;
            }
            set
            {
                this._liaison = value;
                RaisePropertyChange("Liaison");
            }
        }
        private String _sens;
        [DisplayName("Sens")]
        public String Sens
        {
            get
            {
                return this._sens;
            }
            set
            {
                this._sens = value;
                RaisePropertyChange("Sens");
            }
        }
        private String _prOa;
        [DisplayName("PR_OA")]
        public String PrOa
        {
            get
            {
                return this._prOa;
            }
            set
            {
                this._prOa = value;
                RaisePropertyChange("PrOa");
            }
        }
        private Nullable<Int64> _absDeb;
        [DisplayName("Localisation")]
        public Nullable<Int64> AbsDeb
        {
            get
            {
                return this._absDeb;
            }
            set
            {
                this._absDeb = value;
                RaisePropertyChange("AbsDeb");
            }
        }
        
        private String _numExploit;
        [DisplayName("N° d'exploitation")]
        public String NumExploit
        {
            get
            {
                return this._numExploit;
            }
            set
            {
                this._numExploit = value;
                RaisePropertyChange("NumExploit");
            }
        }
        private String _nomUsage;
        [DisplayName("Nom d'usage")]
        public String NomUsage
        {
            get
            {
                return this._nomUsage;
            }
            set
            {
                this._nomUsage = value;
                RaisePropertyChange("NomUsage");
            }
        }
        private String _famille;
        [DisplayName("Famille")]
        public String Famille
        {
            get
            {
                return this._famille;
            }
            set
            {
                this._famille = value;
                RaisePropertyChange("Famille");
            }
        }
        private String _typeOuvrage;
        [DisplayName("Type d'ouvrage")]
        public String TypeOuvrage
        {
            get
            {
                return this._typeOuvrage;
            }
            set
            {
                this._typeOuvrage = value;
                RaisePropertyChange("TypeOuvrage");
            }
        }
        private String _materiaux;
        [DisplayName("Matériaux")]
        public String Materiaux
        {
            get
            {
                return this._materiaux;
            }
            set
            {
                this._materiaux = value;
                RaisePropertyChange("Materiaux");
            }
        }
        private Nullable<DateTime> _dateMs;
        [DisplayName("Date MS")]
        public Nullable<DateTime> DateMs
        {
            get
            {
                return this._dateMs;
            }
            set
            {
                this._dateMs = value;
                RaisePropertyChange("DateMs");
            }
        }
        
        private Nullable<Int64> _nbreTabliers;
        [DisplayName("Nbre Tabliers")]
        public Nullable<Int64> NbreTabliers
        {
            get
            {
                return this._nbreTabliers;
            }
            set
            {
                this._nbreTabliers = value;
                RaisePropertyChange("NbreTabliers");
            }
        }
        
        private Nullable<Int64> _nbreTravee;
        [DisplayName("Nbre Travées")]
        public Nullable<Int64> NbreTravee
        {
            get
            {
                return this._nbreTravee;
            }
            set
            {
                this._nbreTravee = value;
                RaisePropertyChange("NbreTravee");
            }
        }
        
        private Nullable<Double> _gabarit;
        [DisplayName("Gabarit (m)")]
        public Nullable<Double> Gabarit
        {
            get
            {
                return this._gabarit;
            }
            set
            {
                this._gabarit = value;
                RaisePropertyChange("Gabarit");
            }
        }
        
        private Nullable<Double> _longueur;
        [DisplayName("Longueur (m)")]
        public Nullable<Double> Longueur
        {
            get
            {
                return this._longueur;
            }
            set
            {
                this._longueur = value;
                RaisePropertyChange("Longueur");
            }
        }
        
        private Nullable<Double> _largeur;
        [DisplayName("Largeur (m)")]
        public Nullable<Double> Largeur
        {
            get
            {
                return this._largeur;
            }
            set
            {
                this._largeur = value;
                RaisePropertyChange("Largeur");
            }
        }
        
        private Nullable<Boolean> _sectCourante;
        [DisplayName("Section courante")]
        public Nullable<Boolean> SectCourante
        {
            get
            {
                return this._sectCourante;
            }
            set
            {
                this._sectCourante = value;
                RaisePropertyChange("SectCourante");
            }
        }
        
        private String _iqoa;
        [DisplayName("Note IQOA")]
        public String Iqoa
        {
            get
            {
                return this._iqoa;
            }
            set
            {
                this._iqoa = value;
                RaisePropertyChange("Iqoa");
            }
        }
        private Nullable<Double> _noteUrgence;
        [DisplayName("Niveau d'urgence")]
        public Nullable<Double> NoteUrgence
        {
            get
            {
                return this._noteUrgence;
            }
            set
            {
                this._noteUrgence = value;
                RaisePropertyChange("NoteUrgence");
            }
        }
        
    }
}
