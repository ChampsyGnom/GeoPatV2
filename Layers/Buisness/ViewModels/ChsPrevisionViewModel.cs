using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsPrevisionViewModel : ViewModelBase<ChsPrevision>
    {
        public ChsPrevisionViewModel(ChsPrevision model) : base(model)
        {
        }
        public override void Read()
        {
            this.ChsCdContrainte=new ChsCdContrainteViewModel( this.Model.ChsCdContrainte);
            this.ChsBpu=new ChsBpuViewModel( this.Model.ChsBpu);
            this.Annee=this.Model.Annee;
            this.Liaison=this.Model.Liaison;
            this.Sens=this.Model.Sens;
            this.Voie=this.Model.Voie;
            this.AbsDeb=this.Model.AbsDeb;
            this.AbsFin=this.Model.AbsFin;
            this.Montant=this.Model.Montant;
            this.DateDebut=this.Model.DateDebut;
            this.DateFin=this.Model.DateFin;
            this.DateDemPub=this.Model.DateDemPub;
            this.Realise=this.Model.Realise;
            this.Commentaire=this.Model.Commentaire;
        }
        public override void Write()
        {
            this.Model.ChsCdContrainte=this. ChsCdContrainte.Model;
            this.Model.ChsBpu=this. ChsBpu.Model;
            this.Model.Annee=this.Annee;
            this.Model.Liaison=this.Liaison;
            this.Model.Sens=this.Sens;
            this.Model.Voie=this.Voie;
            this.Model.AbsDeb=this.AbsDeb;
            this.Model.AbsFin=this.AbsFin;
            this.Model.Montant=this.Montant;
            this.Model.DateDebut=this.DateDebut;
            this.Model.DateFin=this.DateFin;
            this.Model.DateDemPub=this.DateDemPub;
            this.Model.Realise=this.Realise;
            this.Model.Commentaire=this.Commentaire;
        }
        private ChsCdContrainteViewModel _chsCdContrainte;
        [DisplayName("Contrainte exploitation")]
        public virtual ChsCdContrainteViewModel ChsCdContrainte
        {
            get
            {
                return this._chsCdContrainte;
            }
            set
            {
                this._chsCdContrainte = value;
                RaisePropertyChange("ChsCdContrainte");
            }
        }
        
        private ChsBpuViewModel _chsBpu;
        [DisplayName("Bordereau Prix")]
        public virtual ChsBpuViewModel ChsBpu
        {
            get
            {
                return this._chsBpu;
            }
            set
            {
                this._chsBpu = value;
                RaisePropertyChange("ChsBpu");
            }
        }
        
        private Int64 _annee;
        [DisplayName("Année")]
        public Int64 Annee
        {
            get
            {
                return this._annee;
            }
            set
            {
                this._annee = value;
                RaisePropertyChange("Annee");
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
        private String _voie;
        [DisplayName("Voie")]
        public String Voie
        {
            get
            {
                return this._voie;
            }
            set
            {
                this._voie = value;
                RaisePropertyChange("Voie");
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
        
        private Int64 _absFin;
        [DisplayName("Fin")]
        public Int64 AbsFin
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
        
        private Nullable<Int64> _montant;
        [DisplayName("Coût (€)")]
        public Nullable<Int64> Montant
        {
            get
            {
                return this._montant;
            }
            set
            {
                this._montant = value;
                RaisePropertyChange("Montant");
            }
        }
        
        private Nullable<DateTime> _dateDebut;
        [DisplayName("Date début")]
        public Nullable<DateTime> DateDebut
        {
            get
            {
                return this._dateDebut;
            }
            set
            {
                this._dateDebut = value;
                RaisePropertyChange("DateDebut");
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
        
        private Nullable<DateTime> _dateDemPub;
        [DisplayName("Date demande publication")]
        public Nullable<DateTime> DateDemPub
        {
            get
            {
                return this._dateDemPub;
            }
            set
            {
                this._dateDemPub = value;
                RaisePropertyChange("DateDemPub");
            }
        }
        
        private Nullable<Boolean> _realise;
        [DisplayName("Réalisé")]
        public Nullable<Boolean> Realise
        {
            get
            {
                return this._realise;
            }
            set
            {
                this._realise = value;
                RaisePropertyChange("Realise");
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
    }
}
