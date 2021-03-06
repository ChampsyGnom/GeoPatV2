using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfDscOaViewModel : ViewModelBase<InfDscOa>
    {
        public InfDscOaViewModel(InfDscOa model) : base(model)
        {
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
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["CodeOa"] != null)
                {
                    errors.Add("IDOA : "+this["CodeOa"]);
                }
                if (this["NumOa"] != null)
                {
                    errors.Add("NumOA : "+this["NumOa"]);
                }
                if (this["Liaison"] != null)
                {
                    errors.Add("Liaison : "+this["Liaison"]);
                }
                if (this["Sens"] != null)
                {
                    errors.Add("Sens : "+this["Sens"]);
                }
                if (this["PrOa"] != null)
                {
                    errors.Add("PR_OA : "+this["PrOa"]);
                }
                if (this["AbsDeb"] != null)
                {
                    errors.Add("Localisation : "+this["AbsDeb"]);
                }
                if (this["NumExploit"] != null)
                {
                    errors.Add("N° d'exploitation : "+this["NumExploit"]);
                }
                if (this["NomUsage"] != null)
                {
                    errors.Add("Nom d'usage : "+this["NomUsage"]);
                }
                if (this["Famille"] != null)
                {
                    errors.Add("Famille : "+this["Famille"]);
                }
                if (this["TypeOuvrage"] != null)
                {
                    errors.Add("Type d'ouvrage : "+this["TypeOuvrage"]);
                }
                if (this["Materiaux"] != null)
                {
                    errors.Add("Matériaux : "+this["Materiaux"]);
                }
                if (this["DateMs"] != null)
                {
                    errors.Add("Date MS : "+this["DateMs"]);
                }
                if (this["NbreTabliers"] != null)
                {
                    errors.Add("Nbre Tabliers : "+this["NbreTabliers"]);
                }
                if (this["NbreTravee"] != null)
                {
                    errors.Add("Nbre Travées : "+this["NbreTravee"]);
                }
                if (this["Gabarit"] != null)
                {
                    errors.Add("Gabarit (m) : "+this["Gabarit"]);
                }
                if (this["Longueur"] != null)
                {
                    errors.Add("Longueur (m) : "+this["Longueur"]);
                }
                if (this["Largeur"] != null)
                {
                    errors.Add("Largeur (m) : "+this["Largeur"]);
                }
                if (this["SectCourante"] != null)
                {
                    errors.Add("Section courante : "+this["SectCourante"]);
                }
                if (this["Iqoa"] != null)
                {
                    errors.Add("Note IQOA : "+this["Iqoa"]);
                }
                if (this["NoteUrgence"] != null)
                {
                    errors.Add("Niveau d'urgence : "+this["NoteUrgence"]);
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
                if (columnName.Equals("CodeOa"))
                {
                }
                if (columnName.Equals("NumOa"))
                {
                }
                if (columnName.Equals("Liaison"))
                {
                    if (String.IsNullOrEmpty(this.Liaison))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("Sens"))
                {
                    if (String.IsNullOrEmpty(this.Sens))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("PrOa"))
                {
                }
                if (columnName.Equals("AbsDeb"))
                {
                }
                if (columnName.Equals("NumExploit"))
                {
                }
                if (columnName.Equals("NomUsage"))
                {
                }
                if (columnName.Equals("Famille"))
                {
                }
                if (columnName.Equals("TypeOuvrage"))
                {
                }
                if (columnName.Equals("Materiaux"))
                {
                }
                if (columnName.Equals("DateMs"))
                {
                }
                if (columnName.Equals("NbreTabliers"))
                {
                }
                if (columnName.Equals("NbreTravee"))
                {
                }
                if (columnName.Equals("Gabarit"))
                {
                }
                if (columnName.Equals("Longueur"))
                {
                }
                if (columnName.Equals("Largeur"))
                {
                }
                if (columnName.Equals("SectCourante"))
                {
                }
                if (columnName.Equals("Iqoa"))
                {
                }
                if (columnName.Equals("NoteUrgence"))
                {
                }
                return null;
            }
        }
    }
}
