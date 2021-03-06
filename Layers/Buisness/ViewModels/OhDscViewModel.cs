using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OhDscViewModel : ViewModelBase<OhDsc>
    {
        public OhDscViewModel(OhDsc model) : base(model)
        {
            this.OhTravauxs = new  ObservableCollection<OhTravauxViewModel>();
            
            this.OhPrevisions = new  ObservableCollection<OhPrevisionViewModel>();
            
            this.OhVsts = new  ObservableCollection<OhVstViewModel>();
            
            this.OhInsps = new  ObservableCollection<OhInspViewModel>();
            
            this.OhHistoNotes = new  ObservableCollection<OhHistoNoteViewModel>();
            
            this.OhEvts = new  ObservableCollection<OhEvtViewModel>();
            
            this.OhDscTemps = new  ObservableCollection<OhDscTempViewModel>();
            
            this.OhDscCamps = new  ObservableCollection<OhDscCampViewModel>();
            
        }
        public override void Read()
        {
            this.OhCdFam=new OhCdFamViewModel( this.Model.OhCdFam);
            this.OhCdEntp=new OhCdEntpViewModel( this.Model.OhCdEntp);
            this.OhCdMat=new OhCdMatViewModel( this.Model.OhCdMat);
            this.OhCdEau=new OhCdEauViewModel( this.Model.OhCdEau);
            this.OhCdOuv=new OhCdOuvViewModel( this.Model.OhCdOuv);
            this.OhCdEcoul=new OhCdEcoulViewModel( this.Model.OhCdEcoul);
            this.OhCdType=new OhCdTypeViewModel( this.Model.OhCdType);
            this.OhCdProAv=new OhCdProAvViewModel( this.Model.OhCdProAv);
            this.OhCdProAm=new OhCdProAmViewModel( this.Model.OhCdProAm);
            this.OhCdSousType=new OhCdSousTypeViewModel( this.Model.OhCdSousType);
            this.OhCdExt=new OhCdExtViewModel( this.Model.OhCdExt);
            this.OhCdQualite=new OhCdQualiteViewModel( this.Model.OhCdQualite);
            this.OhCdNomEau=new OhCdNomEauViewModel( this.Model.OhCdNomEau);
            this.OhCdTeteAm=new OhCdTeteAmViewModel( this.Model.OhCdTeteAm);
            this.OhCdTeteAv=new OhCdTeteAvViewModel( this.Model.OhCdTeteAv);
            this.OhCdMo=new OhCdMoViewModel( this.Model.OhCdMo);
            this.NumOh=this.Model.NumOh;
            this.Liaison=this.Model.Liaison;
            this.Sens=this.Model.Sens;
            this.AbsDeb=this.Model.AbsDeb;
            this.AbsFin=this.Model.AbsFin;
            this.NumExploit=this.Model.NumExploit;
            this.DateMs=this.Model.DateMs;
            this.Longueur=this.Model.Longueur;
            this.Hauteur=this.Model.Hauteur;
            this.Biais=this.Model.Biais;
            this.Pente=this.Model.Pente;
            this.Portee=this.Model.Portee;
            this.Jum=this.Model.Jum;
            this.Elem=this.Model.Elem;
            this.Regard=this.Model.Regard;
            this.Perche=this.Model.Perche;
            this.Vulnerable=this.Model.Vulnerable;
            this.Faune=this.Model.Faune;
            this.Loi=this.Model.Loi;
            this.Phe=this.Model.Phe;
            this.Debit=this.Model.Debit;
            this.OuvAval=this.Model.OuvAval;
            this.Note1=this.Model.Note1;
            this.Note2=this.Model.Note2;
            this.Note3=this.Model.Note3;
            this.Note4=this.Model.Note4;
            this.Note5=this.Model.Note5;
            this.Urgence=this.Model.Urgence;
            this.DescInva=this.Model.DescInva;
            this.Securite=this.Model.Securite;
            this.Prioritaire=this.Model.Prioritaire;
            this.ProsurvAnnee=this.Model.ProsurvAnnee;
            this.DernInsp=this.Model.DernInsp;
            this.DernVst=this.Model.DernVst;
            this.NoteVst=this.Model.NoteVst;
            this.Archive=this.Model.Archive;
            this.Commentaire=this.Model.Commentaire;
            this.X1=this.Model.X1;
            this.Y1=this.Model.Y1;
            this.Z1=this.Model.Z1;
            this.X2=this.Model.X2;
            this.Y2=this.Model.Y2;
            this.Z2=this.Model.Z2;
            this.DateReleve=this.Model.DateReleve;
            this.Terrain=this.Model.Terrain;
        }
        public override void Write()
        {
            this.Model.OhCdFam=this. OhCdFam.Model;
            this.Model.OhCdEntp=this. OhCdEntp.Model;
            this.Model.OhCdMat=this. OhCdMat.Model;
            this.Model.OhCdEau=this. OhCdEau.Model;
            this.Model.OhCdOuv=this. OhCdOuv.Model;
            this.Model.OhCdEcoul=this. OhCdEcoul.Model;
            this.Model.OhCdType=this. OhCdType.Model;
            this.Model.OhCdProAv=this. OhCdProAv.Model;
            this.Model.OhCdProAm=this. OhCdProAm.Model;
            this.Model.OhCdSousType=this. OhCdSousType.Model;
            this.Model.OhCdExt=this. OhCdExt.Model;
            this.Model.OhCdQualite=this. OhCdQualite.Model;
            this.Model.OhCdNomEau=this. OhCdNomEau.Model;
            this.Model.OhCdTeteAm=this. OhCdTeteAm.Model;
            this.Model.OhCdTeteAv=this. OhCdTeteAv.Model;
            this.Model.OhCdMo=this. OhCdMo.Model;
            this.Model.NumOh=this.NumOh;
            this.Model.Liaison=this.Liaison;
            this.Model.Sens=this.Sens;
            this.Model.AbsDeb=this.AbsDeb;
            this.Model.AbsFin=this.AbsFin;
            this.Model.NumExploit=this.NumExploit;
            this.Model.DateMs=this.DateMs;
            this.Model.Longueur=this.Longueur;
            this.Model.Hauteur=this.Hauteur;
            this.Model.Biais=this.Biais;
            this.Model.Pente=this.Pente;
            this.Model.Portee=this.Portee;
            this.Model.Jum=this.Jum;
            this.Model.Elem=this.Elem;
            this.Model.Regard=this.Regard;
            this.Model.Perche=this.Perche;
            this.Model.Vulnerable=this.Vulnerable;
            this.Model.Faune=this.Faune;
            this.Model.Loi=this.Loi;
            this.Model.Phe=this.Phe;
            this.Model.Debit=this.Debit;
            this.Model.OuvAval=this.OuvAval;
            this.Model.Note1=this.Note1;
            this.Model.Note2=this.Note2;
            this.Model.Note3=this.Note3;
            this.Model.Note4=this.Note4;
            this.Model.Note5=this.Note5;
            this.Model.Urgence=this.Urgence;
            this.Model.DescInva=this.DescInva;
            this.Model.Securite=this.Securite;
            this.Model.Prioritaire=this.Prioritaire;
            this.Model.ProsurvAnnee=this.ProsurvAnnee;
            this.Model.DernInsp=this.DernInsp;
            this.Model.DernVst=this.DernVst;
            this.Model.NoteVst=this.NoteVst;
            this.Model.Archive=this.Archive;
            this.Model.Commentaire=this.Commentaire;
            this.Model.X1=this.X1;
            this.Model.Y1=this.Y1;
            this.Model.Z1=this.Z1;
            this.Model.X2=this.X2;
            this.Model.Y2=this.Y2;
            this.Model.Z2=this.Z2;
            this.Model.DateReleve=this.DateReleve;
            this.Model.Terrain=this.Terrain;
        }
        private OhCdFamViewModel _ohCdFam;
        [DisplayName("Famille")]
        public virtual OhCdFamViewModel OhCdFam
        {
            get
            {
                return this._ohCdFam;
            }
            set
            {
                this._ohCdFam = value;
                RaisePropertyChange("OhCdFam");
            }
        }
        
        private OhCdEntpViewModel _ohCdEntp;
        [DisplayName("Entreprise")]
        public virtual OhCdEntpViewModel OhCdEntp
        {
            get
            {
                return this._ohCdEntp;
            }
            set
            {
                this._ohCdEntp = value;
                RaisePropertyChange("OhCdEntp");
            }
        }
        
        private OhCdMatViewModel _ohCdMat;
        [DisplayName("Matériaux")]
        public virtual OhCdMatViewModel OhCdMat
        {
            get
            {
                return this._ohCdMat;
            }
            set
            {
                this._ohCdMat = value;
                RaisePropertyChange("OhCdMat");
            }
        }
        
        private OhCdEauViewModel _ohCdEau;
        [DisplayName("Eaux collectées")]
        public virtual OhCdEauViewModel OhCdEau
        {
            get
            {
                return this._ohCdEau;
            }
            set
            {
                this._ohCdEau = value;
                RaisePropertyChange("OhCdEau");
            }
        }
        
        private OhCdOuvViewModel _ohCdOuv;
        [DisplayName("Type Ouverture")]
        public virtual OhCdOuvViewModel OhCdOuv
        {
            get
            {
                return this._ohCdOuv;
            }
            set
            {
                this._ohCdOuv = value;
                RaisePropertyChange("OhCdOuv");
            }
        }
        
        private OhCdEcoulViewModel _ohCdEcoul;
        [DisplayName("Ecoulement")]
        public virtual OhCdEcoulViewModel OhCdEcoul
        {
            get
            {
                return this._ohCdEcoul;
            }
            set
            {
                this._ohCdEcoul = value;
                RaisePropertyChange("OhCdEcoul");
            }
        }
        
        private OhCdTypeViewModel _ohCdType;
        [DisplayName("Type Ouvrage")]
        public virtual OhCdTypeViewModel OhCdType
        {
            get
            {
                return this._ohCdType;
            }
            set
            {
                this._ohCdType = value;
                RaisePropertyChange("OhCdType");
            }
        }
        
        private OhCdProAvViewModel _ohCdProAv;
        [DisplayName("Protection Aval")]
        public virtual OhCdProAvViewModel OhCdProAv
        {
            get
            {
                return this._ohCdProAv;
            }
            set
            {
                this._ohCdProAv = value;
                RaisePropertyChange("OhCdProAv");
            }
        }
        
        private OhCdProAmViewModel _ohCdProAm;
        [DisplayName("Protection Amont")]
        public virtual OhCdProAmViewModel OhCdProAm
        {
            get
            {
                return this._ohCdProAm;
            }
            set
            {
                this._ohCdProAm = value;
                RaisePropertyChange("OhCdProAm");
            }
        }
        
        private OhCdSousTypeViewModel _ohCdSousType;
        [DisplayName("Sous Type Ouvrage")]
        public virtual OhCdSousTypeViewModel OhCdSousType
        {
            get
            {
                return this._ohCdSousType;
            }
            set
            {
                this._ohCdSousType = value;
                RaisePropertyChange("OhCdSousType");
            }
        }
        
        private OhCdExtViewModel _ohCdExt;
        [DisplayName("Type Exutoire")]
        public virtual OhCdExtViewModel OhCdExt
        {
            get
            {
                return this._ohCdExt;
            }
            set
            {
                this._ohCdExt = value;
                RaisePropertyChange("OhCdExt");
            }
        }
        
        private OhCdQualiteViewModel _ohCdQualite;
        [DisplayName("Code Qualité")]
        public virtual OhCdQualiteViewModel OhCdQualite
        {
            get
            {
                return this._ohCdQualite;
            }
            set
            {
                this._ohCdQualite = value;
                RaisePropertyChange("OhCdQualite");
            }
        }
        
        private OhCdNomEauViewModel _ohCdNomEau;
        [DisplayName("Nom du cours d'eau")]
        public virtual OhCdNomEauViewModel OhCdNomEau
        {
            get
            {
                return this._ohCdNomEau;
            }
            set
            {
                this._ohCdNomEau = value;
                RaisePropertyChange("OhCdNomEau");
            }
        }
        
        private OhCdTeteAmViewModel _ohCdTeteAm;
        [DisplayName("Type Tête amont")]
        public virtual OhCdTeteAmViewModel OhCdTeteAm
        {
            get
            {
                return this._ohCdTeteAm;
            }
            set
            {
                this._ohCdTeteAm = value;
                RaisePropertyChange("OhCdTeteAm");
            }
        }
        
        private OhCdTeteAvViewModel _ohCdTeteAv;
        [DisplayName("Type Tête aval")]
        public virtual OhCdTeteAvViewModel OhCdTeteAv
        {
            get
            {
                return this._ohCdTeteAv;
            }
            set
            {
                this._ohCdTeteAv = value;
                RaisePropertyChange("OhCdTeteAv");
            }
        }
        
        private OhCdMoViewModel _ohCdMo;
        [DisplayName("Maitre d'ouvrage")]
        public virtual OhCdMoViewModel OhCdMo
        {
            get
            {
                return this._ohCdMo;
            }
            set
            {
                this._ohCdMo = value;
                RaisePropertyChange("OhCdMo");
            }
        }
        
        public virtual ObservableCollection<OhTravauxViewModel> OhTravauxs { get; set; }
        
        public virtual ObservableCollection<OhPrevisionViewModel> OhPrevisions { get; set; }
        
        public virtual ObservableCollection<OhVstViewModel> OhVsts { get; set; }
        
        public virtual ObservableCollection<OhInspViewModel> OhInsps { get; set; }
        
        public virtual ObservableCollection<OhHistoNoteViewModel> OhHistoNotes { get; set; }
        
        public virtual ObservableCollection<OhEvtViewModel> OhEvts { get; set; }
        
        public virtual ObservableCollection<OhDscTempViewModel> OhDscTemps { get; set; }
        
        public virtual ObservableCollection<OhDscCampViewModel> OhDscCamps { get; set; }
        
        private String _numOh;
        [DisplayName("NumOH")]
        public String NumOh
        {
            get
            {
                return this._numOh;
            }
            set
            {
                this._numOh = value;
                RaisePropertyChange("NumOh");
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
        [DisplayName("PR")]
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
        
        private Nullable<Int64> _absFin;
        [DisplayName("Pr fin")]
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
        
        private Nullable<Int64> _hauteur;
        [DisplayName("Hauteur (mm)")]
        public Nullable<Int64> Hauteur
        {
            get
            {
                return this._hauteur;
            }
            set
            {
                this._hauteur = value;
                RaisePropertyChange("Hauteur");
            }
        }
        
        private Nullable<Int64> _biais;
        [DisplayName("Biais (degré)")]
        public Nullable<Int64> Biais
        {
            get
            {
                return this._biais;
            }
            set
            {
                this._biais = value;
                RaisePropertyChange("Biais");
            }
        }
        
        private Nullable<Double> _pente;
        [DisplayName("Pente (%)")]
        public Nullable<Double> Pente
        {
            get
            {
                return this._pente;
            }
            set
            {
                this._pente = value;
                RaisePropertyChange("Pente");
            }
        }
        
        private Nullable<Int64> _portee;
        [DisplayName("Portée - Ø (mm)")]
        public Nullable<Int64> Portee
        {
            get
            {
                return this._portee;
            }
            set
            {
                this._portee = value;
                RaisePropertyChange("Portee");
            }
        }
        
        private Nullable<Int64> _jum;
        [DisplayName("Jumellé")]
        public Nullable<Int64> Jum
        {
            get
            {
                return this._jum;
            }
            set
            {
                this._jum = value;
                RaisePropertyChange("Jum");
            }
        }
        
        private Nullable<Int64> _elem;
        [DisplayName("Nbre élément")]
        public Nullable<Int64> Elem
        {
            get
            {
                return this._elem;
            }
            set
            {
                this._elem = value;
                RaisePropertyChange("Elem");
            }
        }
        
        private Nullable<Int64> _regard;
        [DisplayName("Nbre regard")]
        public Nullable<Int64> Regard
        {
            get
            {
                return this._regard;
            }
            set
            {
                this._regard = value;
                RaisePropertyChange("Regard");
            }
        }
        
        private Nullable<Boolean> _perche;
        [DisplayName("Ouvrage Perché")]
        public Nullable<Boolean> Perche
        {
            get
            {
                return this._perche;
            }
            set
            {
                this._perche = value;
                RaisePropertyChange("Perche");
            }
        }
        
        private Nullable<Boolean> _vulnerable;
        [DisplayName("Vulnérabilité")]
        public Nullable<Boolean> Vulnerable
        {
            get
            {
                return this._vulnerable;
            }
            set
            {
                this._vulnerable = value;
                RaisePropertyChange("Vulnerable");
            }
        }
        
        private Nullable<Boolean> _faune;
        [DisplayName("Aménagement petite faune")]
        public Nullable<Boolean> Faune
        {
            get
            {
                return this._faune;
            }
            set
            {
                this._faune = value;
                RaisePropertyChange("Faune");
            }
        }
        
        private Nullable<Boolean> _loi;
        [DisplayName("Loi sur l'eau")]
        public Nullable<Boolean> Loi
        {
            get
            {
                return this._loi;
            }
            set
            {
                this._loi = value;
                RaisePropertyChange("Loi");
            }
        }
        
        private Nullable<Int64> _phe;
        [DisplayName("Niveau PHE (mm)")]
        public Nullable<Int64> Phe
        {
            get
            {
                return this._phe;
            }
            set
            {
                this._phe = value;
                RaisePropertyChange("Phe");
            }
        }
        
        private Nullable<Int64> _debit;
        [DisplayName("Débit-projet")]
        public Nullable<Int64> Debit
        {
            get
            {
                return this._debit;
            }
            set
            {
                this._debit = value;
                RaisePropertyChange("Debit");
            }
        }
        
        private String _ouvAval;
        [DisplayName("Connexion Aval")]
        public String OuvAval
        {
            get
            {
                return this._ouvAval;
            }
            set
            {
                this._ouvAval = value;
                RaisePropertyChange("OuvAval");
            }
        }
        private Nullable<Int64> _note1;
        [DisplayName("Note Abords Amont")]
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
        [DisplayName("Note Protection Amont")]
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
        [DisplayName("Note Conduit")]
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
        [DisplayName("Note Protection Aval")]
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
        [DisplayName("Note Abord Aval")]
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
        private Nullable<Boolean> _securite;
        [DisplayName("Problème de sécurité")]
        public Nullable<Boolean> Securite
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
        
        private Nullable<Boolean> _prioritaire;
        [DisplayName("Urgence traitement")]
        public Nullable<Boolean> Prioritaire
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
        
        private Nullable<Int64> _prosurvAnnee;
        [DisplayName("Prochaine Inspection")]
        public Nullable<Int64> ProsurvAnnee
        {
            get
            {
                return this._prosurvAnnee;
            }
            set
            {
                this._prosurvAnnee = value;
                RaisePropertyChange("ProsurvAnnee");
            }
        }
        
        private Nullable<DateTime> _dernInsp;
        [DisplayName("Dernière Inspection")]
        public Nullable<DateTime> DernInsp
        {
            get
            {
                return this._dernInsp;
            }
            set
            {
                this._dernInsp = value;
                RaisePropertyChange("DernInsp");
            }
        }
        
        private Nullable<DateTime> _dernVst;
        [DisplayName("Dernière Visite")]
        public Nullable<DateTime> DernVst
        {
            get
            {
                return this._dernVst;
            }
            set
            {
                this._dernVst = value;
                RaisePropertyChange("DernVst");
            }
        }
        
        private String _noteVst;
        [DisplayName("Note Visite")]
        public String NoteVst
        {
            get
            {
                return this._noteVst;
            }
            set
            {
                this._noteVst = value;
                RaisePropertyChange("NoteVst");
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
        private Nullable<Double> _x1;
        [DisplayName("X1")]
        public Nullable<Double> X1
        {
            get
            {
                return this._x1;
            }
            set
            {
                this._x1 = value;
                RaisePropertyChange("X1");
            }
        }
        
        private Nullable<Double> _y1;
        [DisplayName("Y1")]
        public Nullable<Double> Y1
        {
            get
            {
                return this._y1;
            }
            set
            {
                this._y1 = value;
                RaisePropertyChange("Y1");
            }
        }
        
        private Nullable<Double> _z1;
        [DisplayName("Z1")]
        public Nullable<Double> Z1
        {
            get
            {
                return this._z1;
            }
            set
            {
                this._z1 = value;
                RaisePropertyChange("Z1");
            }
        }
        
        private Nullable<Double> _x2;
        [DisplayName("X2")]
        public Nullable<Double> X2
        {
            get
            {
                return this._x2;
            }
            set
            {
                this._x2 = value;
                RaisePropertyChange("X2");
            }
        }
        
        private Nullable<Double> _y2;
        [DisplayName("Y2")]
        public Nullable<Double> Y2
        {
            get
            {
                return this._y2;
            }
            set
            {
                this._y2 = value;
                RaisePropertyChange("Y2");
            }
        }
        
        private Nullable<Double> _z2;
        [DisplayName("Z2")]
        public Nullable<Double> Z2
        {
            get
            {
                return this._z2;
            }
            set
            {
                this._z2 = value;
                RaisePropertyChange("Z2");
            }
        }
        
        private Nullable<DateTime> _dateReleve;
        [DisplayName("Date relevé")]
        public Nullable<DateTime> DateReleve
        {
            get
            {
                return this._dateReleve;
            }
            set
            {
                this._dateReleve = value;
                RaisePropertyChange("DateReleve");
            }
        }
        
        private Nullable<Boolean> _terrain;
        [DisplayName("Terrain")]
        public Nullable<Boolean> Terrain
        {
            get
            {
                return this._terrain;
            }
            set
            {
                this._terrain = value;
                RaisePropertyChange("Terrain");
            }
        }
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["NumOh"] != null)
                {
                    errors.Add("NumOH : "+this["NumOh"]);
                }
                if (this["Liaison"] != null)
                {
                    errors.Add("Liaison : "+this["Liaison"]);
                }
                if (this["Sens"] != null)
                {
                    errors.Add("Sens : "+this["Sens"]);
                }
                if (this["AbsDeb"] != null)
                {
                    errors.Add("PR : "+this["AbsDeb"]);
                }
                if (this["AbsFin"] != null)
                {
                    errors.Add("Pr fin : "+this["AbsFin"]);
                }
                if (this["NumExploit"] != null)
                {
                    errors.Add("N° d'exploitation : "+this["NumExploit"]);
                }
                if (this["DateMs"] != null)
                {
                    errors.Add("Date MS : "+this["DateMs"]);
                }
                if (this["Longueur"] != null)
                {
                    errors.Add("Longueur (m) : "+this["Longueur"]);
                }
                if (this["Hauteur"] != null)
                {
                    errors.Add("Hauteur (mm) : "+this["Hauteur"]);
                }
                if (this["Biais"] != null)
                {
                    errors.Add("Biais (degré) : "+this["Biais"]);
                }
                if (this["Pente"] != null)
                {
                    errors.Add("Pente (%) : "+this["Pente"]);
                }
                if (this["Portee"] != null)
                {
                    errors.Add("Portée - Ø (mm) : "+this["Portee"]);
                }
                if (this["Jum"] != null)
                {
                    errors.Add("Jumellé : "+this["Jum"]);
                }
                if (this["Elem"] != null)
                {
                    errors.Add("Nbre élément : "+this["Elem"]);
                }
                if (this["Regard"] != null)
                {
                    errors.Add("Nbre regard : "+this["Regard"]);
                }
                if (this["Perche"] != null)
                {
                    errors.Add("Ouvrage Perché : "+this["Perche"]);
                }
                if (this["Vulnerable"] != null)
                {
                    errors.Add("Vulnérabilité : "+this["Vulnerable"]);
                }
                if (this["Faune"] != null)
                {
                    errors.Add("Aménagement petite faune : "+this["Faune"]);
                }
                if (this["Loi"] != null)
                {
                    errors.Add("Loi sur l'eau : "+this["Loi"]);
                }
                if (this["Phe"] != null)
                {
                    errors.Add("Niveau PHE (mm) : "+this["Phe"]);
                }
                if (this["Debit"] != null)
                {
                    errors.Add("Débit-projet : "+this["Debit"]);
                }
                if (this["OuvAval"] != null)
                {
                    errors.Add("Connexion Aval : "+this["OuvAval"]);
                }
                if (this["Note1"] != null)
                {
                    errors.Add("Note Abords Amont : "+this["Note1"]);
                }
                if (this["Note2"] != null)
                {
                    errors.Add("Note Protection Amont : "+this["Note2"]);
                }
                if (this["Note3"] != null)
                {
                    errors.Add("Note Conduit : "+this["Note3"]);
                }
                if (this["Note4"] != null)
                {
                    errors.Add("Note Protection Aval : "+this["Note4"]);
                }
                if (this["Note5"] != null)
                {
                    errors.Add("Note Abord Aval : "+this["Note5"]);
                }
                if (this["Urgence"] != null)
                {
                    errors.Add("Niveau Urgence : "+this["Urgence"]);
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
                if (this["ProsurvAnnee"] != null)
                {
                    errors.Add("Prochaine Inspection : "+this["ProsurvAnnee"]);
                }
                if (this["DernInsp"] != null)
                {
                    errors.Add("Dernière Inspection : "+this["DernInsp"]);
                }
                if (this["DernVst"] != null)
                {
                    errors.Add("Dernière Visite : "+this["DernVst"]);
                }
                if (this["NoteVst"] != null)
                {
                    errors.Add("Note Visite : "+this["NoteVst"]);
                }
                if (this["Archive"] != null)
                {
                    errors.Add("Archive : "+this["Archive"]);
                }
                if (this["Commentaire"] != null)
                {
                    errors.Add("Commentaire : "+this["Commentaire"]);
                }
                if (this["X1"] != null)
                {
                    errors.Add("X1 : "+this["X1"]);
                }
                if (this["Y1"] != null)
                {
                    errors.Add("Y1 : "+this["Y1"]);
                }
                if (this["Z1"] != null)
                {
                    errors.Add("Z1 : "+this["Z1"]);
                }
                if (this["X2"] != null)
                {
                    errors.Add("X2 : "+this["X2"]);
                }
                if (this["Y2"] != null)
                {
                    errors.Add("Y2 : "+this["Y2"]);
                }
                if (this["Z2"] != null)
                {
                    errors.Add("Z2 : "+this["Z2"]);
                }
                if (this["DateReleve"] != null)
                {
                    errors.Add("Date relevé : "+this["DateReleve"]);
                }
                if (this["Terrain"] != null)
                {
                    errors.Add("Terrain : "+this["Terrain"]);
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
                if (columnName.Equals("NumOh"))
                {
                    if (String.IsNullOrEmpty(this.NumOh))
                    {
                        return "valeur vide non autorisée";
                    }
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
                if (columnName.Equals("AbsDeb"))
                {
                }
                if (columnName.Equals("AbsFin"))
                {
                }
                if (columnName.Equals("NumExploit"))
                {
                }
                if (columnName.Equals("DateMs"))
                {
                }
                if (columnName.Equals("Longueur"))
                {
                }
                if (columnName.Equals("Hauteur"))
                {
                }
                if (columnName.Equals("Biais"))
                {
                }
                if (columnName.Equals("Pente"))
                {
                }
                if (columnName.Equals("Portee"))
                {
                }
                if (columnName.Equals("Jum"))
                {
                }
                if (columnName.Equals("Elem"))
                {
                }
                if (columnName.Equals("Regard"))
                {
                }
                if (columnName.Equals("Perche"))
                {
                }
                if (columnName.Equals("Vulnerable"))
                {
                }
                if (columnName.Equals("Faune"))
                {
                }
                if (columnName.Equals("Loi"))
                {
                }
                if (columnName.Equals("Phe"))
                {
                }
                if (columnName.Equals("Debit"))
                {
                }
                if (columnName.Equals("OuvAval"))
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
                if (columnName.Equals("Note5"))
                {
                }
                if (columnName.Equals("Urgence"))
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
                if (columnName.Equals("ProsurvAnnee"))
                {
                }
                if (columnName.Equals("DernInsp"))
                {
                }
                if (columnName.Equals("DernVst"))
                {
                }
                if (columnName.Equals("NoteVst"))
                {
                }
                if (columnName.Equals("Archive"))
                {
                }
                if (columnName.Equals("Commentaire"))
                {
                }
                if (columnName.Equals("X1"))
                {
                }
                if (columnName.Equals("Y1"))
                {
                }
                if (columnName.Equals("Z1"))
                {
                }
                if (columnName.Equals("X2"))
                {
                }
                if (columnName.Equals("Y2"))
                {
                }
                if (columnName.Equals("Z2"))
                {
                }
                if (columnName.Equals("DateReleve"))
                {
                }
                if (columnName.Equals("Terrain"))
                {
                }
                return null;
            }
        }
    }
}
