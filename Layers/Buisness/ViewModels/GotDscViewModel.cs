using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GotDscViewModel : ViewModelBase<GotDsc>
    {
        public GotDscViewModel(GotDsc model) : base(model)
        {
            this.GotTravauxs = new  ObservableCollection<GotTravauxViewModel>();
            
            this.GotInsps = new  ObservableCollection<GotInspViewModel>();
            
            this.GotVsts = new  ObservableCollection<GotVstViewModel>();
            
            this.GotPrevisions = new  ObservableCollection<GotPrevisionViewModel>();
            
            this.GotHistoNotes = new  ObservableCollection<GotHistoNoteViewModel>();
            
            this.GotEvts = new  ObservableCollection<GotEvtViewModel>();
            
            this.GotDscTemps = new  ObservableCollection<GotDscTempViewModel>();
            
            this.GotCouches = new  ObservableCollection<GotCoucheViewModel>();
            
            this.GotDscCamps = new  ObservableCollection<GotDscCampViewModel>();
            
        }
        public override void Read()
        {
            this.GotCdFam=new GotCdFamViewModel( this.Model.GotCdFam);
            this.GotCdPente=new GotCdPenteViewModel( this.Model.GotCdPente);
            this.GotCdProtect=new GotCdProtectViewModel( this.Model.GotCdProtect);
            this.GotCdGeo=new GotCdGeoViewModel( this.Model.GotCdGeo);
            this.GotCdEntp=new GotCdEntpViewModel( this.Model.GotCdEntp);
            this.GotCdQualite=new GotCdQualiteViewModel( this.Model.GotCdQualite);
            this.GotCdRisque=new GotCdRisqueViewModel( this.Model.GotCdRisque);
            this.GotCdType=new GotCdTypeViewModel( this.Model.GotCdType);
            this.NumGot=this.Model.NumGot;
            this.Liaison=this.Model.Liaison;
            this.Sens=this.Model.Sens;
            this.AbsDeb=this.Model.AbsDeb;
            this.AbsFin=this.Model.AbsFin;
            this.NumExploit=this.Model.NumExploit;
            this.DateConst=this.Model.DateConst;
            this.PenteTn=this.Model.PenteTn;
            this.Haut=this.Model.Haut;
            this.LargCrete=this.Model.LargCrete;
            this.Volume=this.Model.Volume;
            this.RisbNbr=this.Model.RisbNbr;
            this.RisbEsp=this.Model.RisbEsp;
            this.RisbLarg=this.Model.RisbLarg;
            this.HautEau=this.Model.HautEau;
            this.Instable=this.Model.Instable;
            this.NomUsage=this.Model.NomUsage;
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
            this.DateReleve=this.Model.DateReleve;
            this.Terrain=this.Model.Terrain;
            this.Y2=this.Model.Y2;
            this.Z2=this.Model.Z2;
            this.X2=this.Model.X2;
        }
        public override void Write()
        {
            this.Model.GotCdFam=this. GotCdFam.Model;
            this.Model.GotCdPente=this. GotCdPente.Model;
            this.Model.GotCdProtect=this. GotCdProtect.Model;
            this.Model.GotCdGeo=this. GotCdGeo.Model;
            this.Model.GotCdEntp=this. GotCdEntp.Model;
            this.Model.GotCdQualite=this. GotCdQualite.Model;
            this.Model.GotCdRisque=this. GotCdRisque.Model;
            this.Model.GotCdType=this. GotCdType.Model;
            this.Model.NumGot=this.NumGot;
            this.Model.Liaison=this.Liaison;
            this.Model.Sens=this.Sens;
            this.Model.AbsDeb=this.AbsDeb;
            this.Model.AbsFin=this.AbsFin;
            this.Model.NumExploit=this.NumExploit;
            this.Model.DateConst=this.DateConst;
            this.Model.PenteTn=this.PenteTn;
            this.Model.Haut=this.Haut;
            this.Model.LargCrete=this.LargCrete;
            this.Model.Volume=this.Volume;
            this.Model.RisbNbr=this.RisbNbr;
            this.Model.RisbEsp=this.RisbEsp;
            this.Model.RisbLarg=this.RisbLarg;
            this.Model.HautEau=this.HautEau;
            this.Model.Instable=this.Instable;
            this.Model.NomUsage=this.NomUsage;
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
            this.Model.DateReleve=this.DateReleve;
            this.Model.Terrain=this.Terrain;
            this.Model.Y2=this.Y2;
            this.Model.Z2=this.Z2;
            this.Model.X2=this.X2;
        }
        private GotCdFamViewModel _gotCdFam;
        [DisplayName("Profil")]
        public virtual GotCdFamViewModel GotCdFam
        {
            get
            {
                return this._gotCdFam;
            }
            set
            {
                this._gotCdFam = value;
                RaisePropertyChange("GotCdFam");
            }
        }
        
        private GotCdPenteViewModel _gotCdPente;
        [DisplayName("Pente talus")]
        public virtual GotCdPenteViewModel GotCdPente
        {
            get
            {
                return this._gotCdPente;
            }
            set
            {
                this._gotCdPente = value;
                RaisePropertyChange("GotCdPente");
            }
        }
        
        private GotCdProtectViewModel _gotCdProtect;
        [DisplayName("Protection")]
        public virtual GotCdProtectViewModel GotCdProtect
        {
            get
            {
                return this._gotCdProtect;
            }
            set
            {
                this._gotCdProtect = value;
                RaisePropertyChange("GotCdProtect");
            }
        }
        
        private GotCdGeoViewModel _gotCdGeo;
        [DisplayName("Géologie")]
        public virtual GotCdGeoViewModel GotCdGeo
        {
            get
            {
                return this._gotCdGeo;
            }
            set
            {
                this._gotCdGeo = value;
                RaisePropertyChange("GotCdGeo");
            }
        }
        
        private GotCdEntpViewModel _gotCdEntp;
        [DisplayName("Entreprises")]
        public virtual GotCdEntpViewModel GotCdEntp
        {
            get
            {
                return this._gotCdEntp;
            }
            set
            {
                this._gotCdEntp = value;
                RaisePropertyChange("GotCdEntp");
            }
        }
        
        private GotCdQualiteViewModel _gotCdQualite;
        [DisplayName("Libellé Qualité")]
        public virtual GotCdQualiteViewModel GotCdQualite
        {
            get
            {
                return this._gotCdQualite;
            }
            set
            {
                this._gotCdQualite = value;
                RaisePropertyChange("GotCdQualite");
            }
        }
        
        private GotCdRisqueViewModel _gotCdRisque;
        [DisplayName("Notation Risque")]
        public virtual GotCdRisqueViewModel GotCdRisque
        {
            get
            {
                return this._gotCdRisque;
            }
            set
            {
                this._gotCdRisque = value;
                RaisePropertyChange("GotCdRisque");
            }
        }
        
        private GotCdTypeViewModel _gotCdType;
        [DisplayName("Type Terrassement")]
        public virtual GotCdTypeViewModel GotCdType
        {
            get
            {
                return this._gotCdType;
            }
            set
            {
                this._gotCdType = value;
                RaisePropertyChange("GotCdType");
            }
        }
        
        public virtual ObservableCollection<GotTravauxViewModel> GotTravauxs { get; set; }
        
        public virtual ObservableCollection<GotInspViewModel> GotInsps { get; set; }
        
        public virtual ObservableCollection<GotVstViewModel> GotVsts { get; set; }
        
        public virtual ObservableCollection<GotPrevisionViewModel> GotPrevisions { get; set; }
        
        public virtual ObservableCollection<GotHistoNoteViewModel> GotHistoNotes { get; set; }
        
        public virtual ObservableCollection<GotEvtViewModel> GotEvts { get; set; }
        
        public virtual ObservableCollection<GotDscTempViewModel> GotDscTemps { get; set; }
        
        public virtual ObservableCollection<GotCoucheViewModel> GotCouches { get; set; }
        
        public virtual ObservableCollection<GotDscCampViewModel> GotDscCamps { get; set; }
        
        private String _numGot;
        [DisplayName("N° Ouvrage")]
        public String NumGot
        {
            get
            {
                return this._numGot;
            }
            set
            {
                this._numGot = value;
                RaisePropertyChange("NumGot");
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
        
        private String _numExploit;
        [DisplayName("No D'exploitation")]
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
        private Nullable<DateTime> _dateConst;
        [DisplayName("Date achèvement")]
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
        
        private Nullable<Boolean> _penteTn;
        [DisplayName("Pente TN >15%")]
        public Nullable<Boolean> PenteTn
        {
            get
            {
                return this._penteTn;
            }
            set
            {
                this._penteTn = value;
                RaisePropertyChange("PenteTn");
            }
        }
        
        private Nullable<Int64> _haut;
        [DisplayName("Hauteur Max (m)")]
        public Nullable<Int64> Haut
        {
            get
            {
                return this._haut;
            }
            set
            {
                this._haut = value;
                RaisePropertyChange("Haut");
            }
        }
        
        private Nullable<Double> _largCrete;
        [DisplayName("Largeur crête (m)")]
        public Nullable<Double> LargCrete
        {
            get
            {
                return this._largCrete;
            }
            set
            {
                this._largCrete = value;
                RaisePropertyChange("LargCrete");
            }
        }
        
        private Nullable<Int64> _volume;
        [DisplayName("Volume (m3)")]
        public Nullable<Int64> Volume
        {
            get
            {
                return this._volume;
            }
            set
            {
                this._volume = value;
                RaisePropertyChange("Volume");
            }
        }
        
        private Nullable<Int64> _risbNbr;
        [DisplayName("Nbre Risberme")]
        public Nullable<Int64> RisbNbr
        {
            get
            {
                return this._risbNbr;
            }
            set
            {
                this._risbNbr = value;
                RaisePropertyChange("RisbNbr");
            }
        }
        
        private Nullable<Double> _risbEsp;
        [DisplayName("Espacem. Risberme")]
        public Nullable<Double> RisbEsp
        {
            get
            {
                return this._risbEsp;
            }
            set
            {
                this._risbEsp = value;
                RaisePropertyChange("RisbEsp");
            }
        }
        
        private Nullable<Double> _risbLarg;
        [DisplayName("Larg Risberme")]
        public Nullable<Double> RisbLarg
        {
            get
            {
                return this._risbLarg;
            }
            set
            {
                this._risbLarg = value;
                RaisePropertyChange("RisbLarg");
            }
        }
        
        private Nullable<Double> _hautEau;
        [DisplayName("PHE Hauteur plus hautes eaux")]
        public Nullable<Double> HautEau
        {
            get
            {
                return this._hautEau;
            }
            set
            {
                this._hautEau = value;
                RaisePropertyChange("HautEau");
            }
        }
        
        private Nullable<Boolean> _instable;
        [DisplayName("Site instable")]
        public Nullable<Boolean> Instable
        {
            get
            {
                return this._instable;
            }
            set
            {
                this._instable = value;
                RaisePropertyChange("Instable");
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
        [DisplayName("Note Urgence")]
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
        [DisplayName("Prochaine surveillance")]
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
        [DisplayName("Dernière inspection")]
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
        
    }
}
