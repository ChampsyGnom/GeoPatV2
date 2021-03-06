using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Emash.GeoPat.Layers.Data.Models;
namespace Emash.GeoPat.Layers.Buisness.ViewModels
{
    public partial class BsnDscTempViewModel : ViewModelBase<BsnDscTemp>
    {
        public BsnDscTempViewModel(BsnDscTemp model) : base(model)
        {
            this.BsnInspTmps = new  ObservableCollection<BsnInspTmpViewModel>();
            
        }
        public override void Read()
        {
            this.BsnCdFam=new BsnCdFamViewModel( this.Model.BsnCdFam);
            this.BsnCdType=new BsnCdTypeViewModel( this.Model.BsnCdType);
            this.BsnCdSousType=new BsnCdSousTypeViewModel( this.Model.BsnCdSousType);
            this.BsnCdEntp=new BsnCdEntpViewModel( this.Model.BsnCdEntp);
            this.BsnCdExt=new BsnCdExtViewModel( this.Model.BsnCdExt);
            this.BsnCdPermeable=new BsnCdPermeableViewModel( this.Model.BsnCdPermeable);
            this.BsnCdFrequence=new BsnCdFrequenceViewModel( this.Model.BsnCdFrequence);
            this.BsnCdAcces=new BsnCdAccesViewModel( this.Model.BsnCdAcces);
            this.BsnCamp=new BsnCampViewModel( this.Model.BsnCamp);
            this.BsnDsc=new BsnDscViewModel( this.Model.BsnDsc);
            this.NumBsn=this.Model.NumBsn;
            this.NumExploit=this.Model.NumExploit;
            this.Liaison=this.Model.Liaison;
            this.Sens=this.Model.Sens;
            this.AbsDeb=this.Model.AbsDeb;
            this.DateMs=this.Model.DateMs;
            this.VolUtil=this.Model.VolUtil;
            this.VolMor=this.Model.VolMor;
            this.VolPoll=this.Model.VolPoll;
            this.VolIncen=this.Model.VolIncen;
            this.DureePluie=this.Model.DureePluie;
            this.FauneFlore=this.Model.FauneFlore;
            this.SurfVersant=this.Model.SurfVersant;
            this.DebitMax=this.Model.DebitMax;
            this.TpsConcent=this.Model.TpsConcent;
            this.Vehicule=this.Model.Vehicule;
            this.Pieton=this.Model.Pieton;
            this.Note1=this.Model.Note1;
            this.Note2=this.Model.Note2;
            this.Note3=this.Model.Note3;
            this.Note4=this.Model.Note4;
            this.Urgence=this.Model.Urgence;
            this.DescInva=this.Model.DescInva;
            this.Securite=this.Model.Securite;
            this.Prioritaire=this.Model.Prioritaire;
            this.ProsurvAnnee=this.Model.ProsurvAnnee;
            this.DernInsp=this.Model.DernInsp;
            this.DernVst=this.Model.DernVst;
            this.NoteVst=this.Model.NoteVst;
            this.Archive=this.Model.Archive;
            this.OuvAval=this.Model.OuvAval;
            this.LoiEau=this.Model.LoiEau;
            this.EauxCollect=this.Model.EauxCollect;
            this.Commentaire=this.Model.Commentaire;
            this.X1=this.Model.X1;
            this.Y1=this.Model.Y1;
            this.Z1=this.Model.Z1;
            this.DateReleve=this.Model.DateReleve;
            this.Terrain=this.Model.Terrain;
        }
        public override void Write()
        {
            this.Model.BsnCdFam=this. BsnCdFam.Model;
            this.Model.BsnCdType=this. BsnCdType.Model;
            this.Model.BsnCdSousType=this. BsnCdSousType.Model;
            this.Model.BsnCdEntp=this. BsnCdEntp.Model;
            this.Model.BsnCdExt=this. BsnCdExt.Model;
            this.Model.BsnCdPermeable=this. BsnCdPermeable.Model;
            this.Model.BsnCdFrequence=this. BsnCdFrequence.Model;
            this.Model.BsnCdAcces=this. BsnCdAcces.Model;
            this.Model.BsnCamp=this. BsnCamp.Model;
            this.Model.BsnDsc=this. BsnDsc.Model;
            this.Model.NumBsn=this.NumBsn;
            this.Model.NumExploit=this.NumExploit;
            this.Model.Liaison=this.Liaison;
            this.Model.Sens=this.Sens;
            this.Model.AbsDeb=this.AbsDeb;
            this.Model.DateMs=this.DateMs;
            this.Model.VolUtil=this.VolUtil;
            this.Model.VolMor=this.VolMor;
            this.Model.VolPoll=this.VolPoll;
            this.Model.VolIncen=this.VolIncen;
            this.Model.DureePluie=this.DureePluie;
            this.Model.FauneFlore=this.FauneFlore;
            this.Model.SurfVersant=this.SurfVersant;
            this.Model.DebitMax=this.DebitMax;
            this.Model.TpsConcent=this.TpsConcent;
            this.Model.Vehicule=this.Vehicule;
            this.Model.Pieton=this.Pieton;
            this.Model.Note1=this.Note1;
            this.Model.Note2=this.Note2;
            this.Model.Note3=this.Note3;
            this.Model.Note4=this.Note4;
            this.Model.Urgence=this.Urgence;
            this.Model.DescInva=this.DescInva;
            this.Model.Securite=this.Securite;
            this.Model.Prioritaire=this.Prioritaire;
            this.Model.ProsurvAnnee=this.ProsurvAnnee;
            this.Model.DernInsp=this.DernInsp;
            this.Model.DernVst=this.DernVst;
            this.Model.NoteVst=this.NoteVst;
            this.Model.Archive=this.Archive;
            this.Model.OuvAval=this.OuvAval;
            this.Model.LoiEau=this.LoiEau;
            this.Model.EauxCollect=this.EauxCollect;
            this.Model.Commentaire=this.Commentaire;
            this.Model.X1=this.X1;
            this.Model.Y1=this.Y1;
            this.Model.Z1=this.Z1;
            this.Model.DateReleve=this.DateReleve;
            this.Model.Terrain=this.Terrain;
        }
        private BsnCdFamViewModel _bsnCdFam;
        [DisplayName("Famille")]
        public virtual BsnCdFamViewModel BsnCdFam
        {
            get
            {
                return this._bsnCdFam;
            }
            set
            {
                this._bsnCdFam = value;
                RaisePropertyChange("BsnCdFam");
            }
        }
        
        private BsnCdTypeViewModel _bsnCdType;
        [DisplayName("Sensibilité du milieu")]
        public virtual BsnCdTypeViewModel BsnCdType
        {
            get
            {
                return this._bsnCdType;
            }
            set
            {
                this._bsnCdType = value;
                RaisePropertyChange("BsnCdType");
            }
        }
        
        private BsnCdSousTypeViewModel _bsnCdSousType;
        [DisplayName("Nature sensibilité")]
        public virtual BsnCdSousTypeViewModel BsnCdSousType
        {
            get
            {
                return this._bsnCdSousType;
            }
            set
            {
                this._bsnCdSousType = value;
                RaisePropertyChange("BsnCdSousType");
            }
        }
        
        private BsnCdEntpViewModel _bsnCdEntp;
        [DisplayName("Entreprise")]
        public virtual BsnCdEntpViewModel BsnCdEntp
        {
            get
            {
                return this._bsnCdEntp;
            }
            set
            {
                this._bsnCdEntp = value;
                RaisePropertyChange("BsnCdEntp");
            }
        }
        
        private BsnCdExtViewModel _bsnCdExt;
        [DisplayName("Exutoire")]
        public virtual BsnCdExtViewModel BsnCdExt
        {
            get
            {
                return this._bsnCdExt;
            }
            set
            {
                this._bsnCdExt = value;
                RaisePropertyChange("BsnCdExt");
            }
        }
        
        private BsnCdPermeableViewModel _bsnCdPermeable;
        [DisplayName("Perméabilité")]
        public virtual BsnCdPermeableViewModel BsnCdPermeable
        {
            get
            {
                return this._bsnCdPermeable;
            }
            set
            {
                this._bsnCdPermeable = value;
                RaisePropertyChange("BsnCdPermeable");
            }
        }
        
        private BsnCdFrequenceViewModel _bsnCdFrequence;
        [DisplayName("Dimensionnement")]
        public virtual BsnCdFrequenceViewModel BsnCdFrequence
        {
            get
            {
                return this._bsnCdFrequence;
            }
            set
            {
                this._bsnCdFrequence = value;
                RaisePropertyChange("BsnCdFrequence");
            }
        }
        
        private BsnCdAccesViewModel _bsnCdAcces;
        [DisplayName("Type Accès")]
        public virtual BsnCdAccesViewModel BsnCdAcces
        {
            get
            {
                return this._bsnCdAcces;
            }
            set
            {
                this._bsnCdAcces = value;
                RaisePropertyChange("BsnCdAcces");
            }
        }
        
        private BsnCampViewModel _bsnCamp;
        [DisplayName("Campagne")]
        public virtual BsnCampViewModel BsnCamp
        {
            get
            {
                return this._bsnCamp;
            }
            set
            {
                this._bsnCamp = value;
                RaisePropertyChange("BsnCamp");
            }
        }
        
        private BsnDscViewModel _bsnDsc;
        [DisplayName("Bassin")]
        public virtual BsnDscViewModel BsnDsc
        {
            get
            {
                return this._bsnDsc;
            }
            set
            {
                this._bsnDsc = value;
                RaisePropertyChange("BsnDsc");
            }
        }
        
        public virtual ObservableCollection<BsnInspTmpViewModel> BsnInspTmps { get; set; }
        
        private String _numBsn;
        [DisplayName("N° Bassin")]
        public String NumBsn
        {
            get
            {
                return this._numBsn;
            }
            set
            {
                this._numBsn = value;
                RaisePropertyChange("NumBsn");
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
        
        private Nullable<Int64> _volUtil;
        [DisplayName("Volume utile (m3)")]
        public Nullable<Int64> VolUtil
        {
            get
            {
                return this._volUtil;
            }
            set
            {
                this._volUtil = value;
                RaisePropertyChange("VolUtil");
            }
        }
        
        private Nullable<Int64> _volMor;
        [DisplayName("Volume mort (m3)")]
        public Nullable<Int64> VolMor
        {
            get
            {
                return this._volMor;
            }
            set
            {
                this._volMor = value;
                RaisePropertyChange("VolMor");
            }
        }
        
        private Nullable<Int64> _volPoll;
        [DisplayName("Volume polluant (m3)")]
        public Nullable<Int64> VolPoll
        {
            get
            {
                return this._volPoll;
            }
            set
            {
                this._volPoll = value;
                RaisePropertyChange("VolPoll");
            }
        }
        
        private Nullable<Int64> _volIncen;
        [DisplayName("Volume eau incendie (m3)")]
        public Nullable<Int64> VolIncen
        {
            get
            {
                return this._volIncen;
            }
            set
            {
                this._volIncen = value;
                RaisePropertyChange("VolIncen");
            }
        }
        
        private Nullable<Int64> _dureePluie;
        [DisplayName("Durée des pluies (h)")]
        public Nullable<Int64> DureePluie
        {
            get
            {
                return this._dureePluie;
            }
            set
            {
                this._dureePluie = value;
                RaisePropertyChange("DureePluie");
            }
        }
        
        private String _fauneFlore;
        [DisplayName("Sensibilité Faune et flore")]
        public String FauneFlore
        {
            get
            {
                return this._fauneFlore;
            }
            set
            {
                this._fauneFlore = value;
                RaisePropertyChange("FauneFlore");
            }
        }
        private Nullable<Double> _surfVersant;
        [DisplayName("Surf. bassin versant ext. (ha)")]
        public Nullable<Double> SurfVersant
        {
            get
            {
                return this._surfVersant;
            }
            set
            {
                this._surfVersant = value;
                RaisePropertyChange("SurfVersant");
            }
        }
        
        private Nullable<Int64> _debitMax;
        [DisplayName("Sortie débit fuite  (l/s)")]
        public Nullable<Int64> DebitMax
        {
            get
            {
                return this._debitMax;
            }
            set
            {
                this._debitMax = value;
                RaisePropertyChange("DebitMax");
            }
        }
        
        private Nullable<Int64> _tpsConcent;
        [DisplayName("Tps de concentration (mn)")]
        public Nullable<Int64> TpsConcent
        {
            get
            {
                return this._tpsConcent;
            }
            set
            {
                this._tpsConcent = value;
                RaisePropertyChange("TpsConcent");
            }
        }
        
        private String _vehicule;
        [DisplayName("Accès véhicule")]
        public String Vehicule
        {
            get
            {
                return this._vehicule;
            }
            set
            {
                this._vehicule = value;
                RaisePropertyChange("Vehicule");
            }
        }
        private String _pieton;
        [DisplayName("Accès piéton")]
        public String Pieton
        {
            get
            {
                return this._pieton;
            }
            set
            {
                this._pieton = value;
                RaisePropertyChange("Pieton");
            }
        }
        private Nullable<Int64> _note1;
        [DisplayName("Note Structure")]
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
        [DisplayName("Note Equipements")]
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
        [DisplayName("Note Abords-Végétation")]
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
        [DisplayName("Note Sécurité")]
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
        private Nullable<Boolean> _loiEau;
        [DisplayName("Loi sur l'eau")]
        public Nullable<Boolean> LoiEau
        {
            get
            {
                return this._loiEau;
            }
            set
            {
                this._loiEau = value;
                RaisePropertyChange("LoiEau");
            }
        }
        
        private String _eauxCollect;
        [DisplayName("Eaux collectées")]
        public String EauxCollect
        {
            get
            {
                return this._eauxCollect;
            }
            set
            {
                this._eauxCollect = value;
                RaisePropertyChange("EauxCollect");
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
        
        public override string Error
        {
            get
            {
                List<String> errors = new List<String>();
                if (this["NumBsn"] != null)
                {
                    errors.Add("N° Bassin : "+this["NumBsn"]);
                }
                if (this["NumExploit"] != null)
                {
                    errors.Add("N° d'exploitation : "+this["NumExploit"]);
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
                if (this["DateMs"] != null)
                {
                    errors.Add("Date MS : "+this["DateMs"]);
                }
                if (this["VolUtil"] != null)
                {
                    errors.Add("Volume utile (m3) : "+this["VolUtil"]);
                }
                if (this["VolMor"] != null)
                {
                    errors.Add("Volume mort (m3) : "+this["VolMor"]);
                }
                if (this["VolPoll"] != null)
                {
                    errors.Add("Volume polluant (m3) : "+this["VolPoll"]);
                }
                if (this["VolIncen"] != null)
                {
                    errors.Add("Volume eau incendie (m3) : "+this["VolIncen"]);
                }
                if (this["DureePluie"] != null)
                {
                    errors.Add("Durée des pluies (h) : "+this["DureePluie"]);
                }
                if (this["FauneFlore"] != null)
                {
                    errors.Add("Sensibilité Faune et flore : "+this["FauneFlore"]);
                }
                if (this["SurfVersant"] != null)
                {
                    errors.Add("Surf. bassin versant ext. (ha) : "+this["SurfVersant"]);
                }
                if (this["DebitMax"] != null)
                {
                    errors.Add("Sortie débit fuite  (l/s) : "+this["DebitMax"]);
                }
                if (this["TpsConcent"] != null)
                {
                    errors.Add("Tps de concentration (mn) : "+this["TpsConcent"]);
                }
                if (this["Vehicule"] != null)
                {
                    errors.Add("Accès véhicule : "+this["Vehicule"]);
                }
                if (this["Pieton"] != null)
                {
                    errors.Add("Accès piéton : "+this["Pieton"]);
                }
                if (this["Note1"] != null)
                {
                    errors.Add("Note Structure : "+this["Note1"]);
                }
                if (this["Note2"] != null)
                {
                    errors.Add("Note Equipements : "+this["Note2"]);
                }
                if (this["Note3"] != null)
                {
                    errors.Add("Note Abords-Végétation : "+this["Note3"]);
                }
                if (this["Note4"] != null)
                {
                    errors.Add("Note Sécurité : "+this["Note4"]);
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
                if (this["OuvAval"] != null)
                {
                    errors.Add("Connexion Aval : "+this["OuvAval"]);
                }
                if (this["LoiEau"] != null)
                {
                    errors.Add("Loi sur l'eau : "+this["LoiEau"]);
                }
                if (this["EauxCollect"] != null)
                {
                    errors.Add("Eaux collectées : "+this["EauxCollect"]);
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
                if (columnName.Equals("NumBsn"))
                {
                    if (String.IsNullOrEmpty(this.NumBsn))
                    {
                        return "valeur vide non autorisée";
                    }
                }
                if (columnName.Equals("NumExploit"))
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
                if (columnName.Equals("AbsDeb"))
                {
                }
                if (columnName.Equals("DateMs"))
                {
                }
                if (columnName.Equals("VolUtil"))
                {
                }
                if (columnName.Equals("VolMor"))
                {
                }
                if (columnName.Equals("VolPoll"))
                {
                }
                if (columnName.Equals("VolIncen"))
                {
                }
                if (columnName.Equals("DureePluie"))
                {
                }
                if (columnName.Equals("FauneFlore"))
                {
                }
                if (columnName.Equals("SurfVersant"))
                {
                }
                if (columnName.Equals("DebitMax"))
                {
                }
                if (columnName.Equals("TpsConcent"))
                {
                }
                if (columnName.Equals("Vehicule"))
                {
                }
                if (columnName.Equals("Pieton"))
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
                if (columnName.Equals("OuvAval"))
                {
                }
                if (columnName.Equals("LoiEau"))
                {
                }
                if (columnName.Equals("EauxCollect"))
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
