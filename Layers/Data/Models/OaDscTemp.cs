using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("DSC_TEMP_OA",Schema="OA")]
    public partial class OaDscTemp : ModelBase
    {
        private OaCdMo _oaCdMo;
        public virtual OaCdMo OaCdMo 
        {
            get
            {
                return this._oaCdMo;
                
            }
            set
            {
                this._oaCdMo = value;
                this.CdMoOaMaitreOuvr = this._oaCdMo.MaitreOuvr;
            }
        }
        
        [Column("CD_MO_OA_ID_PK",Order=0)]
        public Nullable<Int64> OaCdMoIdPk {get;set;}
        
        private OaCdEntp _oaCdEntp;
        public virtual OaCdEntp OaCdEntp 
        {
            get
            {
                return this._oaCdEntp;
                
            }
            set
            {
                this._oaCdEntp = value;
                this.CdEntpOaEntreprise = this._oaCdEntp.Entreprise;
            }
        }
        
        [Column("CD_ENTP_OA_ID_PK",Order=1)]
        public Nullable<Int64> OaCdEntpIdPk {get;set;}
        
        private OaCdBe _oaCdBe;
        public virtual OaCdBe OaCdBe 
        {
            get
            {
                return this._oaCdBe;
                
            }
            set
            {
                this._oaCdBe = value;
                this.CdBeOaBureau = this._oaCdBe.Bureau;
            }
        }
        
        [Column("CD_BE_OA_ID_PK",Order=2)]
        public Nullable<Int64> OaCdBeIdPk {get;set;}
        
        private OaCdMat _oaCdMat;
        public virtual OaCdMat OaCdMat 
        {
            get
            {
                return this._oaCdMat;
                
            }
            set
            {
                this._oaCdMat = value;
                this.CdMatOaMateriaux = this._oaCdMat.Materiaux;
            }
        }
        
        [Column("CD_MAT_OA_ID_PK",Order=3)]
        public Nullable<Int64> OaCdMatIdPk {get;set;}
        
        private OaCdCharge _oaCdCharge;
        public virtual OaCdCharge OaCdCharge 
        {
            get
            {
                return this._oaCdCharge;
                
            }
            set
            {
                this._oaCdCharge = value;
                this.CdChargeOaSurcharge = this._oaCdCharge.Surcharge;
            }
        }
        
        [Column("CD_CHARGE_OA_ID_PK",Order=4)]
        public Nullable<Int64> OaCdChargeIdPk {get;set;}
        
        private OaCdGest _oaCdGest;
        public virtual OaCdGest OaCdGest 
        {
            get
            {
                return this._oaCdGest;
                
            }
            set
            {
                this._oaCdGest = value;
                this.CdGestOaGestionnaire = this._oaCdGest.Gestionnaire;
            }
        }
        
        [Column("CD_GEST_OA_ID_PK",Order=5)]
        public Nullable<Int64> OaCdGestIdPk {get;set;}
        
        private OaCdFond _oaCdFond;
        public virtual OaCdFond OaCdFond 
        {
            get
            {
                return this._oaCdFond;
                
            }
            set
            {
                this._oaCdFond = value;
                this.CdFondOaType = this._oaCdFond.Type;
            }
        }
        
        [Column("CD_FOND_OA_ID_PK",Order=6)]
        public Nullable<Int64> OaCdFondIdPk {get;set;}
        
        private OaCdTablier _oaCdTablier;
        public virtual OaCdTablier OaCdTablier 
        {
            get
            {
                return this._oaCdTablier;
                
            }
            set
            {
                this._oaCdTablier = value;
                this.CdTablierOaTablier = this._oaCdTablier.Tablier;
            }
        }
        
        [Column("CD_TABLIER_OA_ID_PK",Order=7)]
        public Nullable<Int64> OaCdTablierIdPk {get;set;}
        
        private OaCdFam _oaCdFam;
        public virtual OaCdFam OaCdFam 
        {
            get
            {
                return this._oaCdFam;
                
            }
            set
            {
                this._oaCdFam = value;
                this.CdFamOaFamille = this._oaCdFam.Famille;
            }
        }
        
        [Required()]
        [Column("CD_FAM_OA_ID_PK",Order=8)]
        public Int64 OaCdFamIdPk {get;set;}
        
        private OaCdType _oaCdType;
        public virtual OaCdType OaCdType 
        {
            get
            {
                return this._oaCdType;
                
            }
            set
            {
                this._oaCdType = value;
                this.CdTypeOaType = this._oaCdType.Type;
            }
        }
        
        [Required()]
        [Column("CD_TYPE_OA_ID_PK",Order=9)]
        public Int64 OaCdTypeIdPk {get;set;}
        
        private OaCamp _oaCamp;
        public virtual OaCamp OaCamp 
        {
            get
            {
                return this._oaCamp;
                
            }
            set
            {
                this._oaCamp = value;
                this.CampOaIdCamp = this._oaCamp.IdCamp;
            }
        }
        
        [Required()]
        [Column("CAMP_OA_ID_PK",Order=10)]
        public Int64 OaCampIdPk {get;set;}
        
        private OaDsc _oaDsc;
        public virtual OaDsc OaDsc 
        {
            get
            {
                return this._oaDsc;
                
            }
            set
            {
                this._oaDsc = value;
                this.DscOaNumOa = this._oaDsc.NumOa;
            }
        }
        
        [Column("DSC_OA_ID_PK",Order=11)]
        public Nullable<Int64> OaDscIdPk {get;set;}
        
        public virtual ICollection<OaInspTmp> OaInspTmps { get; set; }
        
        [Key]
        [Column("ID_PK",Order=12)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant campagne")]
        [Column("CAMP_OA__ID_CAMP",Order=13)]
        [Required()]
        [MaxLength(100)] 
        public String CampOaIdCamp { get; set; }
        
        [Description("NumOA")]
        [Column("NUM_OA",Order=14)]
        [Required()]
        [MaxLength(20)] 
        public String NumOa { get; set; }
        
        [Description("Bureau d'étude")]
        [Column("CD_BE_OA__BUREAU",Order=15)]
        [MaxLength(60)] 
        public String CdBeOaBureau { get; set; }
        
        [Description("Gestionnaire")]
        [Column("CD_GEST_OA__GESTIONNAIRE",Order=16)]
        [MaxLength(60)] 
        public String CdGestOaGestionnaire { get; set; }
        
        [Description("Surcharge")]
        [Column("CD_CHARGE_OA__SURCHARGE",Order=17)]
        [MaxLength(60)] 
        public String CdChargeOaSurcharge { get; set; }
        
        [Description("Type")]
        [Column("CD_TYPE_OA__TYPE",Order=18)]
        [Required()]
        [MaxLength(20)] 
        public String CdTypeOaType { get; set; }
        
        [Description("NumOA2")]
        [Column("DSC_OA__NUM_OA",Order=19)]
        [MaxLength(20)] 
        public String DscOaNumOa { get; set; }
        
        [Description("Entreprise")]
        [Column("CD_ENTP_OA__ENTREPRISE",Order=20)]
        [MaxLength(60)] 
        public String CdEntpOaEntreprise { get; set; }
        
        [Description("Type tablier")]
        [Column("CD_TABLIER_OA__TABLIER",Order=21)]
        [MaxLength(60)] 
        public String CdTablierOaTablier { get; set; }
        
        [Description("Fondation")]
        [Column("CD_FOND_OA__TYPE",Order=22)]
        [MaxLength(60)] 
        public String CdFondOaType { get; set; }
        
        [Description("Matériaux")]
        [Column("CD_MAT_OA__MATERIAUX",Order=23)]
        [MaxLength(60)] 
        public String CdMatOaMateriaux { get; set; }
        
        [Description("Maitre d'ouvrage")]
        [Column("CD_MO_OA__MAITRE_OUVR",Order=24)]
        [MaxLength(60)] 
        public String CdMoOaMaitreOuvr { get; set; }
        
        [Description("Famille")]
        [Column("CD_FAM_OA__FAMILLE",Order=25)]
        [Required()]
        [MaxLength(20)] 
        public String CdFamOaFamille { get; set; }
        
        [Description("Liaison")]
        [Column("LIAISON",Order=26)]
        [Required()]
        [MaxLength(15)] 
        public String Liaison { get; set; }
        
        [Description("Sens")]
        [Column("SENS",Order=27)]
        [Required()]
        [MaxLength(6)] 
        public String Sens { get; set; }
        
        [Description("PR début")]
        [Column("ABS_DEB",Order=28)]
        [Required()]
        public Int64 AbsDeb { get; set; }
        
        [Description("PR Fin")]
        [Column("ABS_FIN",Order=29)]
        public Nullable<Int64> AbsFin { get; set; }
        
        [Description("N° d'exploitation")]
        [Column("NUM_EXPLOIT",Order=30)]
        [MaxLength(30)] 
        public String NumExploit { get; set; }
        
        [Description("Nom d'usage")]
        [Column("NOM_USAGE",Order=31)]
        [MaxLength(255)] 
        public String NomUsage { get; set; }
        
        [Description("Date construction")]
        [Column("DATE_CONST",Order=32)]
        public Nullable<DateTime> DateConst { get; set; }
        
        [Description("Date MS")]
        [Column("DATE_MS",Order=33)]
        public Nullable<DateTime> DateMs { get; set; }
        
        [Description("Voie portée ou franchie")]
        [Column("VPF",Order=34)]
        [MaxLength(60)] 
        public String Vpf { get; set; }
        
        [Description("Trafic Voie portée")]
        [Column("TRAFIC_VPF",Order=35)]
        public Nullable<Int64> TraficVpf { get; set; }
        
        [Description("Longueur déviation (km)")]
        [Column("DEVIATION",Order=36)]
        public Nullable<Double> Deviation { get; set; }
        
        [Description("Nb piles intermédiaires")]
        [Column("NBPILESINTER",Order=37)]
        public Nullable<Int64> Nbpilesinter { get; set; }
        
        [Description("Nombre de travée")]
        [Column("TRAVURE",Order=38)]
        public Nullable<Int64> Travure { get; set; }
        
        [Description("Long max travée (m)")]
        [Column("LONG_MAX_TRAV",Order=39)]
        public Nullable<Double> LongMaxTrav { get; set; }
        
        [Description("Gabarit (m)")]
        [Column("GAB_MINI",Order=40)]
        public Nullable<Double> GabMini { get; set; }
        
        [Description("Gabarit GRA")]
        [Column("GAB_GRA",Order=41)]
        public Nullable<int> GabGraValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> GabGra 
        {
            get
            {
                if (GabGraValueInt.HasValue) return Convert.ToBoolean(GabGraValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.GabGraValueInt = Convert.ToInt32(value.Value);}
                else {this.GabGraValueInt =null;}
            }
        }
        
        [Description("Biais (grad)")]
        [Column("BIAIS",Order=42)]
        public Nullable<Int64> Biais { get; set; }
        
        [Description("Longueur biaise (m)")]
        [Column("LONG_BIAISE",Order=43)]
        public Nullable<Double> LongBiaise { get; set; }
        
        [Description("Largeur droite (m)")]
        [Column("LARG_TRAV",Order=44)]
        public Nullable<Double> LargTrav { get; set; }
        
        [Description("Largeur entre bordure (m)")]
        [Column("LARG_BIAISE",Order=45)]
        public Nullable<Double> LargBiaise { get; set; }
        
        [Description("Largeur entre GS (m)")]
        [Column("LARG_GS",Order=46)]
        public Nullable<Double> LargGs { get; set; }
        
        [Description("Surface tablier (m²)")]
        [Column("SURF_TABLIER",Order=47)]
        public Nullable<Double> SurfTablier { get; set; }
        
        [Description("Surf voie (m²)")]
        [Column("SURF_VPF",Order=48)]
        public Nullable<Double> SurfVpf { get; set; }
        
        [Description("Fondation immergé")]
        [Column("IMMERGE",Order=49)]
        public Nullable<int> ImmergeValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> Immerge 
        {
            get
            {
                if (ImmergeValueInt.HasValue) return Convert.ToBoolean(ImmergeValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.ImmergeValueInt = Convert.ToInt32(value.Value);}
                else {this.ImmergeValueInt =null;}
            }
        }
        
        [Description("Sismicité")]
        [Column("SISMICITE",Order=50)]
        public Nullable<int> SismiciteValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> Sismicite 
        {
            get
            {
                if (SismiciteValueInt.HasValue) return Convert.ToBoolean(SismiciteValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.SismiciteValueInt = Convert.ToInt32(value.Value);}
                else {this.SismiciteValueInt =null;}
            }
        }
        
        [Description("Dalle de transition")]
        [Column("DALLE",Order=51)]
        public Nullable<int> DalleValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> Dalle 
        {
            get
            {
                if (DalleValueInt.HasValue) return Convert.ToBoolean(DalleValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.DalleValueInt = Convert.ToInt32(value.Value);}
                else {this.DalleValueInt =null;}
            }
        }
        
        [Description("Corniche")]
        [Column("CORN",Order=52)]
        public Nullable<int> CornValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> Corn 
        {
            get
            {
                if (CornValueInt.HasValue) return Convert.ToBoolean(CornValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.CornValueInt = Convert.ToInt32(value.Value);}
                else {this.CornValueInt =null;}
            }
        }
        
        [Description("Lanterneau")]
        [Column("LANTERNEAU",Order=53)]
        public Nullable<int> LanterneauValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> Lanterneau 
        {
            get
            {
                if (LanterneauValueInt.HasValue) return Convert.ToBoolean(LanterneauValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.LanterneauValueInt = Convert.ToInt32(value.Value);}
                else {this.LanterneauValueInt =null;}
            }
        }
        
        [Description("Equipement de visite")]
        [Column("EQUIP_VST",Order=54)]
        public Nullable<int> EquipVstValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> EquipVst 
        {
            get
            {
                if (EquipVstValueInt.HasValue) return Convert.ToBoolean(EquipVstValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.EquipVstValueInt = Convert.ToInt32(value.Value);}
                else {this.EquipVstValueInt =null;}
            }
        }
        
        [Description("Note Appuis / Fondations")]
        [Column("NOTE1",Order=55)]
        public Nullable<Int64> Note1 { get; set; }
        
        [Description("Note Tabliers")]
        [Column("NOTE2",Order=56)]
        public Nullable<Int64> Note2 { get; set; }
        
        [Description("Note Equipement")]
        [Column("NOTE3",Order=57)]
        public Nullable<Int64> Note3 { get; set; }
        
        [Description("Niveau Urgence")]
        [Column("URGENCE",Order=58)]
        [MaxLength(5)] 
        public String Urgence { get; set; }
        
        [Description("Description invalide")]
        [Column("DESC_INVA",Order=59)]
        [MaxLength(1000)] 
        public String DescInva { get; set; }
        
        [Description("Problème de sécurité")]
        [Column("SECURITE",Order=60)]
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
        
        [Description("Urgence Traitement")]
        [Column("PRIORITAIRE",Order=61)]
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
        [Column("PROSURV_ANNEE",Order=62)]
        public Nullable<Int64> ProsurvAnnee { get; set; }
        
        [Description("Dernière Inspection")]
        [Column("DERN_INSP",Order=63)]
        public Nullable<DateTime> DernInsp { get; set; }
        
        [Description("Dernière Visite")]
        [Column("DERN_VST",Order=64)]
        public Nullable<DateTime> DernVst { get; set; }
        
        [Description("Note Visite")]
        [Column("NOTE_VST",Order=65)]
        [MaxLength(5)] 
        public String NoteVst { get; set; }
        
        [Description("Archive")]
        [Column("ARCHIVE",Order=66)]
        [MaxLength(255)] 
        public String Archive { get; set; }
        
        [Description("Commentaire")]
        [Column("COMMENTAIRE",Order=67)]
        [MaxLength(1000)] 
        public String Commentaire { get; set; }
        
        [Description("X1")]
        [Column("X1",Order=68)]
        public Nullable<Double> X1 { get; set; }
        
        [Description("Y1")]
        [Column("Y1",Order=69)]
        public Nullable<Double> Y1 { get; set; }
        
        [Description("Z1")]
        [Column("Z1",Order=70)]
        public Nullable<Double> Z1 { get; set; }
        
        [Description("X2")]
        [Column("X2",Order=71)]
        public Nullable<Double> X2 { get; set; }
        
        [Description("Y2")]
        [Column("Y2",Order=72)]
        public Nullable<Double> Y2 { get; set; }
        
        [Description("Z2")]
        [Column("Z2",Order=73)]
        public Nullable<Double> Z2 { get; set; }
        
        [Description("Date relevé")]
        [Column("DATE_RELEVE",Order=74)]
        public Nullable<DateTime> DateReleve { get; set; }
        
        [Description("Terrain")]
        [Column("TERRAIN",Order=75)]
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
