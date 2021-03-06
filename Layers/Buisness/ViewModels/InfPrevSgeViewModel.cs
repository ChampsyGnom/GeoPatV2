using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class InfPrevSgeViewModel : ViewModelBase<InfPrevSge>
    {
        public InfPrevSgeViewModel(InfPrevSge model) : base(model)
        {
        }
        public override void Read()
        {
            this.InfChaussee=new InfChausseeViewModel( this.Model.InfChaussee);
            this.Schema=this.Model.Schema;
            this.DateDeb=this.Model.DateDeb;
            this.AbsDeb=this.Model.AbsDeb;
            this.Nature=this.Model.Nature;
            this.NumOuvrage=this.Model.NumOuvrage;
            this.DateFin=this.Model.DateFin;
            this.AbsFin=this.Model.AbsFin;
            this.Ce=this.Model.Ce;
            this.DatePub=this.Model.DatePub;
            this.DateFinpub=this.Model.DateFinpub;
            this.DateDemande=this.Model.DateDemande;
            this.NomUsage=this.Model.NomUsage;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.InfChaussee=this. InfChaussee.Model;
            this.Model.Schema=this.Schema;
            this.Model.DateDeb=this.DateDeb;
            this.Model.AbsDeb=this.AbsDeb;
            this.Model.Nature=this.Nature;
            this.Model.NumOuvrage=this.NumOuvrage;
            this.Model.DateFin=this.DateFin;
            this.Model.AbsFin=this.AbsFin;
            this.Model.Ce=this.Ce;
            this.Model.DatePub=this.DatePub;
            this.Model.DateFinpub=this.DateFinpub;
            this.Model.DateDemande=this.DateDemande;
            this.Model.NomUsage=this.NomUsage;
            this.Model.Commentaire=this.Commentaire;
        }
        private InfChausseeViewModel _infChaussee;
        [DisplayName("Chaussée")]
        public virtual InfChausseeViewModel InfChaussee
        {
            get
            {
                return this._infChaussee;
            }
            set
            {
                this._infChaussee = value;
                RaisePropertyChange("InfChaussee");
            }
        }
        
        private String _schema;
        [DisplayName("Base métier")]
        public String Schema
        {
            get
            {
                return this._schema;
            }
            set
            {
                this._schema = value;
                RaisePropertyChange("Schema");
            }
        }
        private DateTime _dateDeb;
        [DisplayName("Date début")]
        public DateTime DateDeb
        {
            get
            {
                return this._dateDeb;
            }
            set
            {
                this._dateDeb = value;
                RaisePropertyChange("DateDeb");
            }
        }
        
        private Int64 _absDeb;
        [DisplayName("Début")]
        public Int64 AbsDeb
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
        
        private String _nature;
        [DisplayName("Nature")]
        public String Nature
        {
            get
            {
                return this._nature;
            }
            set
            {
                this._nature = value;
                RaisePropertyChange("Nature");
            }
        }
        private String _numOuvrage;
        [DisplayName("Num Ouvrage")]
        public String NumOuvrage
        {
            get
            {
                return this._numOuvrage;
            }
            set
            {
                this._numOuvrage = value;
                RaisePropertyChange("NumOuvrage");
            }
        }
        private Nullable<DateTime> _dateFin;
        [DisplayName("Date fin")]
        public Nullable<DateTime> DateFin
        {
            get
            {
                return this._dateFin;
            }
            set
            {
                this._dateFin = value;
                RaisePropertyChange("DateFin");
            }
        }
        
        private Nullable<Int64> _absFin;
        [DisplayName("Fin")]
        public Nullable<Int64> AbsFin
        {
            get
            {
                return this._absFin;
            }
            set
            {
                this._absFin = value;
                RaisePropertyChange("AbsFin");
            }
        }
        
        private String _ce;
        [DisplayName("Contrainte d'exploit")]
        public String Ce
        {
            get
            {
                return this._ce;
            }
            set
            {
                this._ce = value;
                RaisePropertyChange("Ce");
            }
        }
        private Nullable<DateTime> _datePub;
        [DisplayName("Date Publication")]
        public Nullable<DateTime> DatePub
        {
            get
            {
                return this._datePub;
            }
            set
            {
                this._datePub = value;
                RaisePropertyChange("DatePub");
            }
        }
        
        private Nullable<DateTime> _dateFinpub;
        [DisplayName("Date Fin Publication")]
        public Nullable<DateTime> DateFinpub
        {
            get
            {
                return this._dateFinpub;
            }
            set
            {
                this._dateFinpub = value;
                RaisePropertyChange("DateFinpub");
            }
        }
        
        private Nullable<DateTime> _dateDemande;
        [DisplayName("Date demande")]
        public Nullable<DateTime> DateDemande
        {
            get
            {
                return this._dateDemande;
            }
            set
            {
                this._dateDemande = value;
                RaisePropertyChange("DateDemande");
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
        private String _commentaire;
        [DisplayName("Commentaire")]
        public String Commentaire
        {
            get
            {
                return this._commentaire;
            }
            set
            {
                this._commentaire = value;
                RaisePropertyChange("Commentaire");
            }
        }
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["Schema"] != null)
                {
                    errors.Add("Base métier : "+this["Schema"]);
                }
                if (this["DateDeb"] != null)
                {
                    errors.Add("Date début : "+this["DateDeb"]);
                }
                if (this["AbsDeb"] != null)
                {
                    errors.Add("Début : "+this["AbsDeb"]);
                }
                if (this["Nature"] != null)
                {
                    errors.Add("Nature : "+this["Nature"]);
                }
                if (this["NumOuvrage"] != null)
                {
                    errors.Add("Num Ouvrage : "+this["NumOuvrage"]);
                }
                if (this["DateFin"] != null)
                {
                    errors.Add("Date fin : "+this["DateFin"]);
                }
                if (this["AbsFin"] != null)
                {
                    errors.Add("Fin : "+this["AbsFin"]);
                }
                if (this["Ce"] != null)
                {
                    errors.Add("Contrainte d'exploit : "+this["Ce"]);
                }
                if (this["DatePub"] != null)
                {
                    errors.Add("Date Publication : "+this["DatePub"]);
                }
                if (this["DateFinpub"] != null)
                {
                    errors.Add("Date Fin Publication : "+this["DateFinpub"]);
                }
                if (this["DateDemande"] != null)
                {
                    errors.Add("Date demande : "+this["DateDemande"]);
                }
                if (this["NomUsage"] != null)
                {
                    errors.Add("Nom d'usage : "+this["NomUsage"]);
                }
                if (this["Commentaire"] != null)
                {
                    errors.Add("Commentaire : "+this["Commentaire"]);
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
                if (columnName.Equals("Schema"))
                {
                    if (String.IsNullOrEmpty(this.Schema))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("DateDeb"))
                {
                }
                if (columnName.Equals("AbsDeb"))
                {
                }
                if (columnName.Equals("Nature"))
                {
                    if (String.IsNullOrEmpty(this.Nature))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("NumOuvrage"))
                {
                    if (String.IsNullOrEmpty(this.NumOuvrage))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("DateFin"))
                {
                }
                if (columnName.Equals("AbsFin"))
                {
                }
                if (columnName.Equals("Ce"))
                {
                }
                if (columnName.Equals("DatePub"))
                {
                }
                if (columnName.Equals("DateFinpub"))
                {
                }
                if (columnName.Equals("DateDemande"))
                {
                }
                if (columnName.Equals("NomUsage"))
                {
                }
                if (columnName.Equals("Commentaire"))
                {
                }
                return null;
            }
        }
    }
}
