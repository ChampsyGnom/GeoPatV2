using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class OaDscTempViewModel : ViewModelBase<OaDscTemp>
    {
        public OaDscTempViewModel(OaDscTemp model) : base(model)
        {
            this.OaInspTmps = new  ObservableCollection<OaInspTmpViewModel>();
            
        }
        public override void Read()
        {
            this.OaCdMo=new OaCdMoViewModel( this.Model.OaCdMo);
            this.OaCdEntp=new OaCdEntpViewModel( this.Model.OaCdEntp);
            this.OaCdBe=new OaCdBeViewModel( this.Model.OaCdBe);
            this.OaCdMat=new OaCdMatViewModel( this.Model.OaCdMat);
            this.OaCdCharge=new OaCdChargeViewModel( this.Model.OaCdCharge);
            this.OaCdGest=new OaCdGestViewModel( this.Model.OaCdGest);
            this.OaCdFond=new OaCdFondViewModel( this.Model.OaCdFond);
            this.OaCdTablier=new OaCdTablierViewModel( this.Model.OaCdTablier);
            this.OaCdFam=new OaCdFamViewModel( this.Model.OaCdFam);
            this.OaCdType=new OaCdTypeViewModel( this.Model.OaCdType);
            this.OaCamp=new OaCampViewModel( this.Model.OaCamp);
            this.OaDsc=new OaDscViewModel( this.Model.OaDsc);
            this.NumOa=this.Model.NumOa;
            this.Liaison=this.Model.Liaison;
            this.Sens=this.Model.Sens;
            this.AbsDeb=this.Model.AbsDeb;
            this.AbsFin=this.Model.AbsFin;
            this.NumExploit=this.Model.NumExploit;
            this.NomUsage=this.Model.NomUsage;
            this.DateConst=this.Model.DateConst;
            this.DateMs=this.Model.DateMs;
            this.Vpf=this.Model.Vpf;
            this.TraficVpf=this.Model.TraficVpf;
            this.Deviation=this.Model.Deviation;
            this.Nbpilesinter=this.Model.Nbpilesinter;
            this.Travure=this.Model.Travure;
            this.LongMaxTrav=this.Model.LongMaxTrav;
            this.GabMini=this.Model.GabMini;
            this.GabGra=this.Model.GabGra;
            this.Biais=this.Model.Biais;
            this.LongBiaise=this.Model.LongBiaise;
            this.LargTrav=this.Model.LargTrav;
            this.LargBiaise=this.Model.LargBiaise;
            this.LargGs=this.Model.LargGs;
            this.SurfTablier=this.Model.SurfTablier;
            this.SurfVpf=this.Model.SurfVpf;
            this.Immerge=this.Model.Immerge;
            this.Sismicite=this.Model.Sismicite;
            this.Dalle=this.Model.Dalle;
            this.Corn=this.Model.Corn;
            this.Lanterneau=this.Model.Lanterneau;
            this.EquipVst=this.Model.EquipVst;
            this.Note1=this.Model.Note1;
            this.Note2=this.Model.Note2;
            this.Note3=this.Model.Note3;
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
            this.Model.OaCdMo=this. OaCdMo.Model;
            this.Model.OaCdEntp=this. OaCdEntp.Model;
            this.Model.OaCdBe=this. OaCdBe.Model;
            this.Model.OaCdMat=this. OaCdMat.Model;
            this.Model.OaCdCharge=this. OaCdCharge.Model;
            this.Model.OaCdGest=this. OaCdGest.Model;
            this.Model.OaCdFond=this. OaCdFond.Model;
            this.Model.OaCdTablier=this. OaCdTablier.Model;
            this.Model.OaCdFam=this. OaCdFam.Model;
            this.Model.OaCdType=this. OaCdType.Model;
            this.Model.OaCamp=this. OaCamp.Model;
            this.Model.OaDsc=this. OaDsc.Model;
            this.Model.NumOa=this.NumOa;
            this.Model.Liaison=this.Liaison;
            this.Model.Sens=this.Sens;
            this.Model.AbsDeb=this.AbsDeb;
            this.Model.AbsFin=this.AbsFin;
            this.Model.NumExploit=this.NumExploit;
            this.Model.NomUsage=this.NomUsage;
            this.Model.DateConst=this.DateConst;
            this.Model.DateMs=this.DateMs;
            this.Model.Vpf=this.Vpf;
            this.Model.TraficVpf=this.TraficVpf;
            this.Model.Deviation=this.Deviation;
            this.Model.Nbpilesinter=this.Nbpilesinter;
            this.Model.Travure=this.Travure;
            this.Model.LongMaxTrav=this.LongMaxTrav;
            this.Model.GabMini=this.GabMini;
            this.Model.GabGra=this.GabGra;
            this.Model.Biais=this.Biais;
            this.Model.LongBiaise=this.LongBiaise;
            this.Model.LargTrav=this.LargTrav;
            this.Model.LargBiaise=this.LargBiaise;
            this.Model.LargGs=this.LargGs;
            this.Model.SurfTablier=this.SurfTablier;
            this.Model.SurfVpf=this.SurfVpf;
            this.Model.Immerge=this.Immerge;
            this.Model.Sismicite=this.Sismicite;
            this.Model.Dalle=this.Dalle;
            this.Model.Corn=this.Corn;
            this.Model.Lanterneau=this.Lanterneau;
            this.Model.EquipVst=this.EquipVst;
            this.Model.Note1=this.Note1;
            this.Model.Note2=this.Note2;
            this.Model.Note3=this.Note3;
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
        private OaCdMoViewModel _oaCdMo;
        [DisplayName("Maitre d'ouvrage")]
        public virtual OaCdMoViewModel OaCdMo
        {
            get
            {
                return this._oaCdMo;
            }
            set
            {
                this._oaCdMo = value;
                RaisePropertyChange("OaCdMo");
            }
        }
        
        private OaCdEntpViewModel _oaCdEntp;
        [DisplayName("Entreprise")]
        public virtual OaCdEntpViewModel OaCdEntp
        {
            get
            {
                return this._oaCdEntp;
            }
            set
            {
                this._oaCdEntp = value;
                RaisePropertyChange("OaCdEntp");
            }
        }
        
        private OaCdBeViewModel _oaCdBe;
        [DisplayName("Bureau d'étude")]
        public virtual OaCdBeViewModel OaCdBe
        {
            get
            {
                return this._oaCdBe;
            }
            set
            {
                this._oaCdBe = value;
                RaisePropertyChange("OaCdBe");
            }
        }
        
        private OaCdMatViewModel _oaCdMat;
        [DisplayName("Matériaux")]
        public virtual OaCdMatViewModel OaCdMat
        {
            get
            {
                return this._oaCdMat;
            }
            set
            {
                this._oaCdMat = value;
                RaisePropertyChange("OaCdMat");
            }
        }
        
        private OaCdChargeViewModel _oaCdCharge;
        [DisplayName("Type de surcharges")]
        public virtual OaCdChargeViewModel OaCdCharge
        {
            get
            {
                return this._oaCdCharge;
            }
            set
            {
                this._oaCdCharge = value;
                RaisePropertyChange("OaCdCharge");
            }
        }
        
        private OaCdGestViewModel _oaCdGest;
        [DisplayName("Gestionnaire de la voirie")]
        public virtual OaCdGestViewModel OaCdGest
        {
            get
            {
                return this._oaCdGest;
            }
            set
            {
                this._oaCdGest = value;
                RaisePropertyChange("OaCdGest");
            }
        }
        
        private OaCdFondViewModel _oaCdFond;
        [DisplayName("Types de fondation")]
        public virtual OaCdFondViewModel OaCdFond
        {
            get
            {
                return this._oaCdFond;
            }
            set
            {
                this._oaCdFond = value;
                RaisePropertyChange("OaCdFond");
            }
        }
        
        private OaCdTablierViewModel _oaCdTablier;
        [DisplayName("Types de tablier")]
        public virtual OaCdTablierViewModel OaCdTablier
        {
            get
            {
                return this._oaCdTablier;
            }
            set
            {
                this._oaCdTablier = value;
                RaisePropertyChange("OaCdTablier");
            }
        }
        
        private OaCdFamViewModel _oaCdFam;
        [DisplayName("Famille d'ouvrage")]
        public virtual OaCdFamViewModel OaCdFam
        {
            get
            {
                return this._oaCdFam;
            }
            set
            {
                this._oaCdFam = value;
                RaisePropertyChange("OaCdFam");
            }
        }
        
        private OaCdTypeViewModel _oaCdType;
        [DisplayName("Type d'ouvrage")]
        public virtual OaCdTypeViewModel OaCdType
        {
            get
            {
                return this._oaCdType;
            }
            set
            {
                this._oaCdType = value;
                RaisePropertyChange("OaCdType");
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
        
        public virtual ObservableCollection<OaInspTmpViewModel> OaInspTmps { get; set; }
        
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
        private Int64 _absDeb;
        [DisplayName("PR début")]
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
        [DisplayName("PR Fin")]
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
        private Nullable<DateTime> _dateConst;
        [DisplayName("Date construction")]
        public Nullable<DateTime> DateConst
        {
            get
            {
                return this._dateConst;
            }
            set
            {
                this._dateConst = value;
                RaisePropertyChange("DateConst");
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
        
        private String _vpf;
        [DisplayName("Voie portée ou franchie")]
        public String Vpf
        {
            get
            {
                return this._vpf;
            }
            set
            {
                this._vpf = value;
                RaisePropertyChange("Vpf");
            }
        }
        private Nullable<Int64> _traficVpf;
        [DisplayName("Trafic Voie portée")]
        public Nullable<Int64> TraficVpf
        {
            get
            {
                return this._traficVpf;
            }
            set
            {
                this._traficVpf = value;
                RaisePropertyChange("TraficVpf");
            }
        }
        
        private Nullable<Double> _deviation;
        [DisplayName("Longueur déviation (km)")]
        public Nullable<Double> Deviation
        {
            get
            {
                return this._deviation;
            }
            set
            {
                this._deviation = value;
                RaisePropertyChange("Deviation");
            }
        }
        
        private Nullable<Int64> _nbpilesinter;
        [DisplayName("Nb piles intermédiaires")]
        public Nullable<Int64> Nbpilesinter
        {
            get
            {
                return this._nbpilesinter;
            }
            set
            {
                this._nbpilesinter = value;
                RaisePropertyChange("Nbpilesinter");
            }
        }
        
        private Nullable<Int64> _travure;
        [DisplayName("Nombre de travée")]
        public Nullable<Int64> Travure
        {
            get
            {
                return this._travure;
            }
            set
            {
                this._travure = value;
                RaisePropertyChange("Travure");
            }
        }
        
        private Nullable<Double> _longMaxTrav;
        [DisplayName("Long max travée (m)")]
        public Nullable<Double> LongMaxTrav
        {
            get
            {
                return this._longMaxTrav;
            }
            set
            {
                this._longMaxTrav = value;
                RaisePropertyChange("LongMaxTrav");
            }
        }
        
        private Nullable<Double> _gabMini;
        [DisplayName("Gabarit (m)")]
        public Nullable<Double> GabMini
        {
            get
            {
                return this._gabMini;
            }
            set
            {
                this._gabMini = value;
                RaisePropertyChange("GabMini");
            }
        }
        
        private Nullable<Boolean> _gabGra;
        [DisplayName("Gabarit GRA")]
        public Nullable<Boolean> GabGra
        {
            get
            {
                return this._gabGra;
            }
            set
            {
                this._gabGra = value;
                RaisePropertyChange("GabGra");
            }
        }
        
        private Nullable<Int64> _biais;
        [DisplayName("Biais (grad)")]
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
        
        private Nullable<Double> _longBiaise;
        [DisplayName("Longueur biaise (m)")]
        public Nullable<Double> LongBiaise
        {
            get
            {
                return this._longBiaise;
            }
            set
            {
                this._longBiaise = value;
                RaisePropertyChange("LongBiaise");
            }
        }
        
        private Nullable<Double> _largTrav;
        [DisplayName("Largeur droite (m)")]
        public Nullable<Double> LargTrav
        {
            get
            {
                return this._largTrav;
            }
            set
            {
                this._largTrav = value;
                RaisePropertyChange("LargTrav");
            }
        }
        
        private Nullable<Double> _largBiaise;
        [DisplayName("Largeur entre bordure (m)")]
        public Nullable<Double> LargBiaise
        {
            get
            {
                return this._largBiaise;
            }
            set
            {
                this._largBiaise = value;
                RaisePropertyChange("LargBiaise");
            }
        }
        
        private Nullable<Double> _largGs;
        [DisplayName("Largeur entre GS (m)")]
        public Nullable<Double> LargGs
        {
            get
            {
                return this._largGs;
            }
            set
            {
                this._largGs = value;
                RaisePropertyChange("LargGs");
            }
        }
        
        private Nullable<Double> _surfTablier;
        [DisplayName("Surface tablier (m²)")]
        public Nullable<Double> SurfTablier
        {
            get
            {
                return this._surfTablier;
            }
            set
            {
                this._surfTablier = value;
                RaisePropertyChange("SurfTablier");
            }
        }
        
        private Nullable<Double> _surfVpf;
        [DisplayName("Surf voie (m²)")]
        public Nullable<Double> SurfVpf
        {
            get
            {
                return this._surfVpf;
            }
            set
            {
                this._surfVpf = value;
                RaisePropertyChange("SurfVpf");
            }
        }
        
        private Nullable<Boolean> _immerge;
        [DisplayName("Fondation immergé")]
        public Nullable<Boolean> Immerge
        {
            get
            {
                return this._immerge;
            }
            set
            {
                this._immerge = value;
                RaisePropertyChange("Immerge");
            }
        }
        
        private Nullable<Boolean> _sismicite;
        [DisplayName("Sismicité")]
        public Nullable<Boolean> Sismicite
        {
            get
            {
                return this._sismicite;
            }
            set
            {
                this._sismicite = value;
                RaisePropertyChange("Sismicite");
            }
        }
        
        private Nullable<Boolean> _dalle;
        [DisplayName("Dalle de transition")]
        public Nullable<Boolean> Dalle
        {
            get
            {
                return this._dalle;
            }
            set
            {
                this._dalle = value;
                RaisePropertyChange("Dalle");
            }
        }
        
        private Nullable<Boolean> _corn;
        [DisplayName("Corniche")]
        public Nullable<Boolean> Corn
        {
            get
            {
                return this._corn;
            }
            set
            {
                this._corn = value;
                RaisePropertyChange("Corn");
            }
        }
        
        private Nullable<Boolean> _lanterneau;
        [DisplayName("Lanterneau")]
        public Nullable<Boolean> Lanterneau
        {
            get
            {
                return this._lanterneau;
            }
            set
            {
                this._lanterneau = value;
                RaisePropertyChange("Lanterneau");
            }
        }
        
        private Nullable<Boolean> _equipVst;
        [DisplayName("Equipement de visite")]
        public Nullable<Boolean> EquipVst
        {
            get
            {
                return this._equipVst;
            }
            set
            {
                this._equipVst = value;
                RaisePropertyChange("EquipVst");
            }
        }
        
        private Nullable<Int64> _note1;
        [DisplayName("Note Appuis / Fondations")]
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
        [DisplayName("Note Tabliers")]
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
        [DisplayName("Note Equipement")]
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
        [DisplayName("Urgence Traitement")]
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
        
    }
}
