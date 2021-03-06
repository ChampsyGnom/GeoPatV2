using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("DSC_TEMP_BSN",Schema="BSN")]
    public partial class BsnDscTemp : ModelBase
    {
        private BsnCdFam _bsnCdFam;
        public virtual BsnCdFam BsnCdFam 
        {
            get
            {
                return this._bsnCdFam;
                
            }
            set
            {
                this._bsnCdFam = value;
                this.CdFamBsnFamille = this._bsnCdFam.Famille;
            }
        }
        
        [Required()]
        [Column("CD_FAM_BSN_ID_PK",Order=0)]
        public Int64 BsnCdFamIdPk {get;set;}
        
        private BsnCdType _bsnCdType;
        public virtual BsnCdType BsnCdType 
        {
            get
            {
                return this._bsnCdType;
                
            }
            set
            {
                this._bsnCdType = value;
                this.CdTypeBsnType = this._bsnCdType.Type;
            }
        }
        
        [Required()]
        [Column("CD_TYPE_BSN_ID_PK",Order=1)]
        public Int64 BsnCdTypeIdPk {get;set;}
        
        private BsnCdSousType _bsnCdSousType;
        public virtual BsnCdSousType BsnCdSousType 
        {
            get
            {
                return this._bsnCdSousType;
                
            }
            set
            {
                this._bsnCdSousType = value;
                this.CdSousTypeBsnNatSensib = this._bsnCdSousType.NatSensib;
            }
        }
        
        [Column("CD_SOUS_TYPE_BSN_ID_PK",Order=2)]
        public Nullable<Int64> BsnCdSousTypeIdPk {get;set;}
        
        private BsnCdEntp _bsnCdEntp;
        public virtual BsnCdEntp BsnCdEntp 
        {
            get
            {
                return this._bsnCdEntp;
                
            }
            set
            {
                this._bsnCdEntp = value;
                this.CdEntpBsnEntreprise = this._bsnCdEntp.Entreprise;
            }
        }
        
        [Column("CD_ENTP_BSN_ID_PK",Order=3)]
        public Nullable<Int64> BsnCdEntpIdPk {get;set;}
        
        private BsnCdExt _bsnCdExt;
        public virtual BsnCdExt BsnCdExt 
        {
            get
            {
                return this._bsnCdExt;
                
            }
            set
            {
                this._bsnCdExt = value;
                this.CdExtBsnType = this._bsnCdExt.Type;
            }
        }
        
        [Column("CD_EXT_BSN_ID_PK",Order=4)]
        public Nullable<Int64> BsnCdExtIdPk {get;set;}
        
        private BsnCdPermeable _bsnCdPermeable;
        public virtual BsnCdPermeable BsnCdPermeable 
        {
            get
            {
                return this._bsnCdPermeable;
                
            }
            set
            {
                this._bsnCdPermeable = value;
                this.CdPermeableBsnType = this._bsnCdPermeable.Type;
            }
        }
        
        [Column("CD_PERMEABLE_BSN_ID_PK",Order=5)]
        public Nullable<Int64> BsnCdPermeableIdPk {get;set;}
        
        private BsnCdFrequence _bsnCdFrequence;
        public virtual BsnCdFrequence BsnCdFrequence 
        {
            get
            {
                return this._bsnCdFrequence;
                
            }
            set
            {
                this._bsnCdFrequence = value;
                this.CdFrequenceBsnFreq = this._bsnCdFrequence.Freq;
            }
        }
        
        [Column("CD_FREQUENCE_BSN_ID_PK",Order=6)]
        public Nullable<Int64> BsnCdFrequenceIdPk {get;set;}
        
        private BsnCdAcces _bsnCdAcces;
        public virtual BsnCdAcces BsnCdAcces 
        {
            get
            {
                return this._bsnCdAcces;
                
            }
            set
            {
                this._bsnCdAcces = value;
                this.CdAccesBsnVacces = this._bsnCdAcces.Vacces;
            }
        }
        
        [Column("CD_ACCES_BSN_ID_PK",Order=7)]
        public Nullable<Int64> BsnCdAccesIdPk {get;set;}
        
        private BsnCamp _bsnCamp;
        public virtual BsnCamp BsnCamp 
        {
            get
            {
                return this._bsnCamp;
                
            }
            set
            {
                this._bsnCamp = value;
                this.CampBsnIdCamp = this._bsnCamp.IdCamp;
            }
        }
        
        [Required()]
        [Column("CAMP_BSN_ID_PK",Order=8)]
        public Int64 BsnCampIdPk {get;set;}
        
        private BsnDsc _bsnDsc;
        public virtual BsnDsc BsnDsc 
        {
            get
            {
                return this._bsnDsc;
                
            }
            set
            {
                this._bsnDsc = value;
                this.DscBsnNumBsn = this._bsnDsc.NumBsn;
            }
        }
        
        [Column("DSC_BSN_ID_PK",Order=9)]
        public Nullable<Int64> BsnDscIdPk {get;set;}
        
        public virtual ICollection<BsnInspTmp> BsnInspTmps { get; set; }
        
        [Key]
        [Column("ID_PK",Order=10)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant Campagne")]
        [Column("CAMP_BSN__ID_CAMP",Order=11)]
        [Required()]
        [MaxLength(100)] 
        public String CampBsnIdCamp { get; set; }
        
        [Description("N° Bassin")]
        [Column("NUM_BSN",Order=12)]
        [Required()]
        [MaxLength(20)] 
        public String NumBsn { get; set; }
        
        [Description("N° Bassin2")]
        [Column("DSC_BSN__NUM_BSN",Order=13)]
        [MaxLength(20)] 
        public String DscBsnNumBsn { get; set; }
        
        [Description("Perméabilité")]
        [Column("CD_PERMEABLE_BSN__TYPE",Order=14)]
        [MaxLength(60)] 
        public String CdPermeableBsnType { get; set; }
        
        [Description("Nature sensibilité")]
        [Column("CD_SOUS_TYPE_BSN__NAT_SENSIB",Order=15)]
        [MaxLength(60)] 
        public String CdSousTypeBsnNatSensib { get; set; }
        
        [Description("Exutoire")]
        [Column("CD_EXT_BSN__TYPE",Order=16)]
        [MaxLength(60)] 
        public String CdExtBsnType { get; set; }
        
        [Description("Sensibilité du milieu")]
        [Column("CD_TYPE_BSN__TYPE",Order=17)]
        [Required()]
        [MaxLength(60)] 
        public String CdTypeBsnType { get; set; }
        
        [Description("Voie d'accès")]
        [Column("CD_ACCES_BSN__VACCES",Order=18)]
        [MaxLength(60)] 
        public String CdAccesBsnVacces { get; set; }
        
        [Description("Dénomination")]
        [Column("CD_FAM_BSN__FAMILLE",Order=19)]
        [Required()]
        [MaxLength(60)] 
        public String CdFamBsnFamille { get; set; }
        
        [Description("Fréquence")]
        [Column("CD_FREQUENCE_BSN__FREQ",Order=20)]
        [MaxLength(25)] 
        public String CdFrequenceBsnFreq { get; set; }
        
        [Description("Entreprise")]
        [Column("CD_ENTP_BSN__ENTREPRISE",Order=21)]
        [MaxLength(60)] 
        public String CdEntpBsnEntreprise { get; set; }
        
        [Description("N° d'exploitation")]
        [Column("NUM_EXPLOIT",Order=22)]
        [MaxLength(30)] 
        public String NumExploit { get; set; }
        
        [Description("Liaison")]
        [Column("LIAISON",Order=23)]
        [Required()]
        [MaxLength(15)] 
        public String Liaison { get; set; }
        
        [Description("Sens")]
        [Column("SENS",Order=24)]
        [Required()]
        [MaxLength(6)] 
        public String Sens { get; set; }
        
        [Description("PR")]
        [Column("ABS_DEB",Order=25)]
        [Required()]
        public Int64 AbsDeb { get; set; }
        
        [Description("Date MS")]
        [Column("DATE_MS",Order=26)]
        public Nullable<DateTime> DateMs { get; set; }
        
        [Description("Volume utile (m3)")]
        [Column("VOL_UTIL",Order=27)]
        public Nullable<Int64> VolUtil { get; set; }
        
        [Description("Volume mort (m3)")]
        [Column("VOL_MOR",Order=28)]
        public Nullable<Int64> VolMor { get; set; }
        
        [Description("Volume polluant (m3)")]
        [Column("VOL_POLL",Order=29)]
        public Nullable<Int64> VolPoll { get; set; }
        
        [Description("Volume eau incendie (m3)")]
        [Column("VOL_INCEN",Order=30)]
        public Nullable<Int64> VolIncen { get; set; }
        
        [Description("Durée des pluies (h)")]
        [Column("DUREE_PLUIE",Order=31)]
        public Nullable<Int64> DureePluie { get; set; }
        
        [Description("Sensibilité Faune et flore")]
        [Column("FAUNE_FLORE",Order=32)]
        [MaxLength(60)] 
        public String FauneFlore { get; set; }
        
        [Description("Surf. bassin versant ext. (ha)")]
        [Column("SURF_VERSANT",Order=33)]
        public Nullable<Double> SurfVersant { get; set; }
        
        [Description("Sortie débit fuite  (l/s)")]
        [Column("DEBIT_MAX",Order=34)]
        public Nullable<Int64> DebitMax { get; set; }
        
        [Description("Tps de concentration (mn)")]
        [Column("TPS_CONCENT",Order=35)]
        public Nullable<Int64> TpsConcent { get; set; }
        
        [Description("Accès véhicule")]
        [Column("VEHICULE",Order=36)]
        [MaxLength(255)] 
        public String Vehicule { get; set; }
        
        [Description("Accès piéton")]
        [Column("PIETON",Order=37)]
        [MaxLength(255)] 
        public String Pieton { get; set; }
        
        [Description("Note Structure")]
        [Column("NOTE1",Order=38)]
        public Nullable<Int64> Note1 { get; set; }
        
        [Description("Note Equipements")]
        [Column("NOTE2",Order=39)]
        public Nullable<Int64> Note2 { get; set; }
        
        [Description("Note Abords-Végétation")]
        [Column("NOTE3",Order=40)]
        public Nullable<Int64> Note3 { get; set; }
        
        [Description("Note Sécurité")]
        [Column("NOTE4",Order=41)]
        public Nullable<Int64> Note4 { get; set; }
        
        [Description("Niveau Urgence")]
        [Column("URGENCE",Order=42)]
        [MaxLength(5)] 
        public String Urgence { get; set; }
        
        [Description("Description invalide")]
        [Column("DESC_INVA",Order=43)]
        [MaxLength(1000)] 
        public String DescInva { get; set; }
        
        [Description("Problème de sécurité")]
        [Column("SECURITE",Order=44)]
        public Nullable<int> SecuriteValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> Securite 
        {
            get
            {
                if (SecuriteValueInt.HasValue) return Convert.ToBoolean(SecuriteValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.SecuriteValueInt = Convert.ToInt32(value.Value);}
                else {this.SecuriteValueInt =null;}
            }
        }
        
        [Description("Urgence traitement")]
        [Column("PRIORITAIRE",Order=45)]
        public Nullable<int> PrioritaireValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> Prioritaire 
        {
            get
            {
                if (PrioritaireValueInt.HasValue) return Convert.ToBoolean(PrioritaireValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.PrioritaireValueInt = Convert.ToInt32(value.Value);}
                else {this.PrioritaireValueInt =null;}
            }
        }
        
        [Description("Prochaine Inspection")]
        [Column("PROSURV_ANNEE",Order=46)]
        public Nullable<Int64> ProsurvAnnee { get; set; }
        
        [Description("Dernière Inspection")]
        [Column("DERN_INSP",Order=47)]
        public Nullable<DateTime> DernInsp { get; set; }
        
        [Description("Dernière Visite")]
        [Column("DERN_VST",Order=48)]
        public Nullable<DateTime> DernVst { get; set; }
        
        [Description("Note Visite")]
        [Column("NOTE_VST",Order=49)]
        [MaxLength(5)] 
        public String NoteVst { get; set; }
        
        [Description("Archive")]
        [Column("ARCHIVE",Order=50)]
        [MaxLength(255)] 
        public String Archive { get; set; }
        
        [Description("Connexion Aval")]
        [Column("OUV_AVAL",Order=51)]
        [MaxLength(200)] 
        public String OuvAval { get; set; }
        
        [Description("Loi sur l'eau")]
        [Column("LOI_EAU",Order=52)]
        public Nullable<int> LoiEauValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> LoiEau 
        {
            get
            {
                if (LoiEauValueInt.HasValue) return Convert.ToBoolean(LoiEauValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.LoiEauValueInt = Convert.ToInt32(value.Value);}
                else {this.LoiEauValueInt =null;}
            }
        }
        
        [Description("Eaux collectées")]
        [Column("EAUX_COLLECT",Order=53)]
        [MaxLength(200)] 
        public String EauxCollect { get; set; }
        
        [Description("Commentaire")]
        [Column("COMMENTAIRE",Order=54)]
        [MaxLength(1000)] 
        public String Commentaire { get; set; }
        
        [Description("X1")]
        [Column("X1",Order=55)]
        public Nullable<Double> X1 { get; set; }
        
        [Description("Y1")]
        [Column("Y1",Order=56)]
        public Nullable<Double> Y1 { get; set; }
        
        [Description("Z1")]
        [Column("Z1",Order=57)]
        public Nullable<Double> Z1 { get; set; }
        
        [Description("Date relevé")]
        [Column("DATE_RELEVE",Order=58)]
        public Nullable<DateTime> DateReleve { get; set; }
        
        [Description("Terrain")]
        [Column("TERRAIN",Order=59)]
        public Nullable<int> TerrainValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> Terrain 
        {
            get
            {
                if (TerrainValueInt.HasValue) return Convert.ToBoolean(TerrainValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.TerrainValueInt = Convert.ToInt32(value.Value);}
                else {this.TerrainValueInt =null;}
            }
        }
        
    }
}
