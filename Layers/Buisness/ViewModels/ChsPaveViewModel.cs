using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class ChsPaveViewModel : ViewModelBase<ChsPave>
    {
        public ChsPaveViewModel(ChsPave model) : base(model)
        {
            this.ChsMatPaves = new  ObservableCollection<ChsMatPaveViewModel>();
            
            this.ChsSousCouches = new  ObservableCollection<ChsSousCoucheViewModel>();
            
            this.ChsPaveVoies = new  ObservableCollection<ChsPaveVoieViewModel>();
            
        }
        public override void Read()
        {
            this.ChsCdCause=new ChsCdCauseViewModel( this.Model.ChsCdCause);
            this.ChsCdEntp=new ChsCdEntpViewModel( this.Model.ChsCdEntp);
            this.ChsCdTech=new ChsCdTechViewModel( this.Model.ChsCdTech);
            this.ChsCdCou=new ChsCdCouViewModel( this.Model.ChsCdCou);
            this.ChsCdTravaux=new ChsCdTravauxViewModel( this.Model.ChsCdTravaux);
            this.ChsCdMo=new ChsCdMoViewModel( this.Model.ChsCdMo);
            this.DateMs=this.Model.DateMs;
            this.Liaison=this.Model.Liaison;
            this.Sens=this.Model.Sens;
            this.AbsDeb=this.Model.AbsDeb;
            this.AbsFin=this.Model.AbsFin;
            this.Largeur=this.Model.Largeur;
            this.Epais=this.Model.Epais;
            this.Granulo=this.Model.Granulo;
            this.DureeVie=this.Model.DureeVie;
            this.Archive=this.Model.Archive;
            this.Marche=this.Model.Marche;
            this.Commentaire=this.Model.Commentaire;
            this.Montant=this.Model.Montant;
        }
        public override void Write()
        {
            this.Model.ChsCdCause=this. ChsCdCause.Model;
            this.Model.ChsCdEntp=this. ChsCdEntp.Model;
            this.Model.ChsCdTech=this. ChsCdTech.Model;
            this.Model.ChsCdCou=this. ChsCdCou.Model;
            this.Model.ChsCdTravaux=this. ChsCdTravaux.Model;
            this.Model.ChsCdMo=this. ChsCdMo.Model;
            this.Model.DateMs=this.DateMs;
            this.Model.Liaison=this.Liaison;
            this.Model.Sens=this.Sens;
            this.Model.AbsDeb=this.AbsDeb;
            this.Model.AbsFin=this.AbsFin;
            this.Model.Largeur=this.Largeur;
            this.Model.Epais=this.Epais;
            this.Model.Granulo=this.Granulo;
            this.Model.DureeVie=this.DureeVie;
            this.Model.Archive=this.Archive;
            this.Model.Marche=this.Marche;
            this.Model.Commentaire=this.Commentaire;
            this.Model.Montant=this.Montant;
        }
        private ChsCdCauseViewModel _chsCdCause;
        [DisplayName("Cause Entretien")]
        public virtual ChsCdCauseViewModel ChsCdCause
        {
            get
            {
                return this._chsCdCause;
            }
            set
            {
                this._chsCdCause = value;
                RaisePropertyChange("ChsCdCause");
            }
        }
        
        private ChsCdEntpViewModel _chsCdEntp;
        [DisplayName("Entreprises de travaux")]
        public virtual ChsCdEntpViewModel ChsCdEntp
        {
            get
            {
                return this._chsCdEntp;
            }
            set
            {
                this._chsCdEntp = value;
                RaisePropertyChange("ChsCdEntp");
            }
        }
        
        private ChsCdTechViewModel _chsCdTech;
        [DisplayName("Techniques structure et entretien")]
        public virtual ChsCdTechViewModel ChsCdTech
        {
            get
            {
                return this._chsCdTech;
            }
            set
            {
                this._chsCdTech = value;
                RaisePropertyChange("ChsCdTech");
            }
        }
        
        private ChsCdCouViewModel _chsCdCou;
        [DisplayName("Code couche")]
        public virtual ChsCdCouViewModel ChsCdCou
        {
            get
            {
                return this._chsCdCou;
            }
            set
            {
                this._chsCdCou = value;
                RaisePropertyChange("ChsCdCou");
            }
        }
        
        private ChsCdTravauxViewModel _chsCdTravaux;
        [DisplayName("Type travaux")]
        public virtual ChsCdTravauxViewModel ChsCdTravaux
        {
            get
            {
                return this._chsCdTravaux;
            }
            set
            {
                this._chsCdTravaux = value;
                RaisePropertyChange("ChsCdTravaux");
            }
        }
        
        private ChsCdMoViewModel _chsCdMo;
        [DisplayName("Maître d'oeuvre")]
        public virtual ChsCdMoViewModel ChsCdMo
        {
            get
            {
                return this._chsCdMo;
            }
            set
            {
                this._chsCdMo = value;
                RaisePropertyChange("ChsCdMo");
            }
        }
        
        public virtual ObservableCollection<ChsMatPaveViewModel> ChsMatPaves { get; set; }
        
        public virtual ObservableCollection<ChsSousCoucheViewModel> ChsSousCouches { get; set; }
        
        public virtual ObservableCollection<ChsPaveVoieViewModel> ChsPaveVoies { get; set; }
        
        private DateTime _dateMs;
        [DisplayName("Date MS")]
        public DateTime DateMs
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
        
        private Double _epais;
        [DisplayName("Epaisseur (cm)")]
        public Double Epais
        {
            get
            {
                return this._epais;
            }
            set
            {
                this._epais = value;
                RaisePropertyChange("Epais");
            }
        }
        
        private String _granulo;
        [DisplayName("Granulométrie")]
        public String Granulo
        {
            get
            {
                return this._granulo;
            }
            set
            {
                this._granulo = value;
                RaisePropertyChange("Granulo");
            }
        }
        private Nullable<Double> _dureeVie;
        [DisplayName("Durée de vie")]
        public Nullable<Double> DureeVie
        {
            get
            {
                return this._dureeVie;
            }
            set
            {
                this._dureeVie = value;
                RaisePropertyChange("DureeVie");
            }
        }
        
        private String _archive;
        [DisplayName("Archive")]
        public String Archive
        {
            get
            {
                return this._archive;
            }
            set
            {
                this._archive = value;
                RaisePropertyChange("Archive");
            }
        }
        private String _marche;
        [DisplayName("N° Marché")]
        public String Marche
        {
            get
            {
                return this._marche;
            }
            set
            {
                this._marche = value;
                RaisePropertyChange("Marche");
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
        private Nullable<Int64> _montant;
        [DisplayName("Montant (€)")]
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
        
    }
}
