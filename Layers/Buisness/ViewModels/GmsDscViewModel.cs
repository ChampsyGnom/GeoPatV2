using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class GmsDscViewModel : ViewModelBase
    {
        public GmsDsc Model {get; set;}
        public GmsDscViewModel(GmsDsc model)
        {
            this.GmsTravauxs = new  ObservableCollection<GmsTravauxViewModel>();
            
            this.GmsPrevisions = new  ObservableCollection<GmsPrevisionViewModel>();
            
            this.GmsInsps = new  ObservableCollection<GmsInspViewModel>();
            
            this.GmsVsts = new  ObservableCollection<GmsVstViewModel>();
            
            this.GmsHistoNotes = new  ObservableCollection<GmsHistoNoteViewModel>();
            
            this.GmsEvts = new  ObservableCollection<GmsEvtViewModel>();
            
            this.GmsDscTemps = new  ObservableCollection<GmsDscTempViewModel>();
            
            this.GmsDscCamps = new  ObservableCollection<GmsDscCampViewModel>();
            
            this.Model = model;
            this.Read();
        }
        public override void Read()
        {
            this.GmsCdFam=new GmsCdFamViewModel( this.Model.GmsCdFam);
            this.GmsCdEntp=new GmsCdEntpViewModel( this.Model.GmsCdEntp);
            this.GmsCdPoutre=new GmsCdPoutreViewModel( this.Model.GmsCdPoutre);
            this.GmsCdType=new GmsCdTypeViewModel( this.Model.GmsCdType);
            this.GmsCdAncrage=new GmsCdAncrageViewModel( this.Model.GmsCdAncrage);
            this.GmsCdAcces=new GmsCdAccesViewModel( this.Model.GmsCdAcces);
            this.GmsCdPosMat=new GmsCdPosMatViewModel( this.Model.GmsCdPosMat);
            this.GmsCdQualite=new GmsCdQualiteViewModel( this.Model.GmsCdQualite);
            this.GmsCdProtec=new GmsCdProtecViewModel( this.Model.GmsCdProtec);
            this.GmsCdInterface=new GmsCdInterfaceViewModel( this.Model.GmsCdInterface);
            this.GmsCdFournisseur=new GmsCdFournisseurViewModel( this.Model.GmsCdFournisseur);
            this.GmsCdPoteau=new GmsCdPoteauViewModel( this.Model.GmsCdPoteau);
            this.NumGms=this.Model.NumGms;
            this.Liaison=this.Model.Liaison;
            this.Sens=this.Model.Sens;
            this.AbsDeb=this.Model.AbsDeb;
            this.NumExploit=this.Model.NumExploit;
            this.NomUsage=this.Model.NomUsage;
            this.DateMs=this.Model.DateMs;
            this.Haut=this.Model.Haut;
            this.Tirair=this.Model.Tirair;
            this.Vent=this.Model.Vent;
            this.Ancrage=this.Model.Ancrage;
            this.Larg=this.Model.Larg;
            this.Traverse=this.Model.Traverse;
            this.Element=this.Model.Element;
            this.NbPoteaux=this.Model.NbPoteaux;
            this.Eclairage=this.Model.Eclairage;
            this.Condamne=this.Model.Condamne;
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
        }
        public override void Write()
        {
            this.Model.GmsCdFam=this. GmsCdFam.Model;
            this.Model.GmsCdEntp=this. GmsCdEntp.Model;
            this.Model.GmsCdPoutre=this. GmsCdPoutre.Model;
            this.Model.GmsCdType=this. GmsCdType.Model;
            this.Model.GmsCdAncrage=this. GmsCdAncrage.Model;
            this.Model.GmsCdAcces=this. GmsCdAcces.Model;
            this.Model.GmsCdPosMat=this. GmsCdPosMat.Model;
            this.Model.GmsCdQualite=this. GmsCdQualite.Model;
            this.Model.GmsCdProtec=this. GmsCdProtec.Model;
            this.Model.GmsCdInterface=this. GmsCdInterface.Model;
            this.Model.GmsCdFournisseur=this. GmsCdFournisseur.Model;
            this.Model.GmsCdPoteau=this. GmsCdPoteau.Model;
            this.Model.NumGms=this.NumGms;
            this.Model.Liaison=this.Liaison;
            this.Model.Sens=this.Sens;
            this.Model.AbsDeb=this.AbsDeb;
            this.Model.NumExploit=this.NumExploit;
            this.Model.NomUsage=this.NomUsage;
            this.Model.DateMs=this.DateMs;
            this.Model.Haut=this.Haut;
            this.Model.Tirair=this.Tirair;
            this.Model.Vent=this.Vent;
            this.Model.Ancrage=this.Ancrage;
            this.Model.Larg=this.Larg;
            this.Model.Traverse=this.Traverse;
            this.Model.Element=this.Element;
            this.Model.NbPoteaux=this.NbPoteaux;
            this.Model.Eclairage=this.Eclairage;
            this.Model.Condamne=this.Condamne;
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
        }
        private GmsCdFamViewModel _gmsCdFam;
        [DisplayName("Famille")]
        public virtual GmsCdFamViewModel GmsCdFam
        {
            get
            {
                return this._gmsCdFam;
            }
            set
            {
                this._gmsCdFam = value;
                RaisePropertyChange("GmsCdFam");
            }
        }
        
        private GmsCdEntpViewModel _gmsCdEntp;
        [DisplayName("Entreprises")]
        public virtual GmsCdEntpViewModel GmsCdEntp
        {
            get
            {
                return this._gmsCdEntp;
            }
            set
            {
                this._gmsCdEntp = value;
                RaisePropertyChange("GmsCdEntp");
            }
        }
        
        private GmsCdPoutreViewModel _gmsCdPoutre;
        [DisplayName("Type Traverse")]
        public virtual GmsCdPoutreViewModel GmsCdPoutre
        {
            get
            {
                return this._gmsCdPoutre;
            }
            set
            {
                this._gmsCdPoutre = value;
                RaisePropertyChange("GmsCdPoutre");
            }
        }
        
        private GmsCdTypeViewModel _gmsCdType;
        [DisplayName("Type Ouvrage")]
        public virtual GmsCdTypeViewModel GmsCdType
        {
            get
            {
                return this._gmsCdType;
            }
            set
            {
                this._gmsCdType = value;
                RaisePropertyChange("GmsCdType");
            }
        }
        
        private GmsCdAncrageViewModel _gmsCdAncrage;
        [DisplayName("Type Ancrage")]
        public virtual GmsCdAncrageViewModel GmsCdAncrage
        {
            get
            {
                return this._gmsCdAncrage;
            }
            set
            {
                this._gmsCdAncrage = value;
                RaisePropertyChange("GmsCdAncrage");
            }
        }
        
        private GmsCdAccesViewModel _gmsCdAcces;
        [DisplayName("Type d'accès (Echelle et passerelle)")]
        public virtual GmsCdAccesViewModel GmsCdAcces
        {
            get
            {
                return this._gmsCdAcces;
            }
            set
            {
                this._gmsCdAcces = value;
                RaisePropertyChange("GmsCdAcces");
            }
        }
        
        private GmsCdPosMatViewModel _gmsCdPosMat;
        [DisplayName("Position Mâts")]
        public virtual GmsCdPosMatViewModel GmsCdPosMat
        {
            get
            {
                return this._gmsCdPosMat;
            }
            set
            {
                this._gmsCdPosMat = value;
                RaisePropertyChange("GmsCdPosMat");
            }
        }
        
        private GmsCdQualiteViewModel _gmsCdQualite;
        [DisplayName("Libellé Qualité")]
        public virtual GmsCdQualiteViewModel GmsCdQualite
        {
            get
            {
                return this._gmsCdQualite;
            }
            set
            {
                this._gmsCdQualite = value;
                RaisePropertyChange("GmsCdQualite");
            }
        }
        
        private GmsCdProtecViewModel _gmsCdProtec;
        [DisplayName("Dispositif de Protection")]
        public virtual GmsCdProtecViewModel GmsCdProtec
        {
            get
            {
                return this._gmsCdProtec;
            }
            set
            {
                this._gmsCdProtec = value;
                RaisePropertyChange("GmsCdProtec");
            }
        }
        
        private GmsCdInterfaceViewModel _gmsCdInterface;
        [DisplayName("Type de Liaison GMS")]
        public virtual GmsCdInterfaceViewModel GmsCdInterface
        {
            get
            {
                return this._gmsCdInterface;
            }
            set
            {
                this._gmsCdInterface = value;
                RaisePropertyChange("GmsCdInterface");
            }
        }
        
        private GmsCdFournisseurViewModel _gmsCdFournisseur;
        [DisplayName("Nom Fournisseur")]
        public virtual GmsCdFournisseurViewModel GmsCdFournisseur
        {
            get
            {
                return this._gmsCdFournisseur;
            }
            set
            {
                this._gmsCdFournisseur = value;
                RaisePropertyChange("GmsCdFournisseur");
            }
        }
        
        private GmsCdPoteauViewModel _gmsCdPoteau;
        [DisplayName("Type Poteau")]
        public virtual GmsCdPoteauViewModel GmsCdPoteau
        {
            get
            {
                return this._gmsCdPoteau;
            }
            set
            {
                this._gmsCdPoteau = value;
                RaisePropertyChange("GmsCdPoteau");
            }
        }
        
        public virtual ObservableCollection<GmsTravauxViewModel> GmsTravauxs { get; set; }
        
        public virtual ObservableCollection<GmsPrevisionViewModel> GmsPrevisions { get; set; }
        
        public virtual ObservableCollection<GmsInspViewModel> GmsInsps { get; set; }
        
        public virtual ObservableCollection<GmsVstViewModel> GmsVsts { get; set; }
        
        public virtual ObservableCollection<GmsHistoNoteViewModel> GmsHistoNotes { get; set; }
        
        public virtual ObservableCollection<GmsEvtViewModel> GmsEvts { get; set; }
        
        public virtual ObservableCollection<GmsDscTempViewModel> GmsDscTemps { get; set; }
        
        public virtual ObservableCollection<GmsDscCampViewModel> GmsDscCamps { get; set; }
        
        private String _numGms;
        [DisplayName("No GMS")]
        public String NumGms
        {
            get
            {
                return this._numGms;
            }
            set
            {
                this._numGms = value;
                RaisePropertyChange("NumGms");
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
        
        private Nullable<Double> _haut;
        [DisplayName("Gabarit sous structure (m)")]
        public Nullable<Double> Haut
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
        
        private Nullable<Double> _tirair;
        [DisplayName("Gabarit sous panneau (m)")]
        public Nullable<Double> Tirair
        {
            get
            {
                return this._tirair;
            }
            set
            {
                this._tirair = value;
                RaisePropertyChange("Tirair");
            }
        }
        
        private Nullable<Int64> _vent;
        [DisplayName("Résistance au vent (km/h)")]
        public Nullable<Int64> Vent
        {
            get
            {
                return this._vent;
            }
            set
            {
                this._vent = value;
                RaisePropertyChange("Vent");
            }
        }
        
        private String _ancrage;
        [DisplayName("dimension Massif Ancrage (cm)")]
        public String Ancrage
        {
            get
            {
                return this._ancrage;
            }
            set
            {
                this._ancrage = value;
                RaisePropertyChange("Ancrage");
            }
        }
        private Nullable<Double> _larg;
        [DisplayName("Portée (m)")]
        public Nullable<Double> Larg
        {
            get
            {
                return this._larg;
            }
            set
            {
                this._larg = value;
                RaisePropertyChange("Larg");
            }
        }
        
        private Nullable<Int64> _traverse;
        [DisplayName("Nbr traverse")]
        public Nullable<Int64> Traverse
        {
            get
            {
                return this._traverse;
            }
            set
            {
                this._traverse = value;
                RaisePropertyChange("Traverse");
            }
        }
        
        private Nullable<Int64> _element;
        [DisplayName("Nbr élément de traverse")]
        public Nullable<Int64> Element
        {
            get
            {
                return this._element;
            }
            set
            {
                this._element = value;
                RaisePropertyChange("Element");
            }
        }
        
        private Nullable<Int64> _nbPoteaux;
        [DisplayName("Nbr poteaux")]
        public Nullable<Int64> NbPoteaux
        {
            get
            {
                return this._nbPoteaux;
            }
            set
            {
                this._nbPoteaux = value;
                RaisePropertyChange("NbPoteaux");
            }
        }
        
        private Nullable<Boolean> _eclairage;
        [DisplayName("Eclairage")]
        public Nullable<Boolean> Eclairage
        {
            get
            {
                return this._eclairage;
            }
            set
            {
                this._eclairage = value;
                RaisePropertyChange("Eclairage");
            }
        }
        
        private Nullable<Boolean> _condamne;
        [DisplayName("Accès condamné")]
        public Nullable<Boolean> Condamne
        {
            get
            {
                return this._condamne;
            }
            set
            {
                this._condamne = value;
                RaisePropertyChange("Condamne");
            }
        }
        
        private Nullable<Int64> _note1;
        [DisplayName("Note Ancrage")]
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
        [DisplayName("Note Structure")]
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
        [DisplayName("Note Fixation")]
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
        [DisplayName("Note Panneau")]
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
        [DisplayName("Note Accessibilité")]
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
