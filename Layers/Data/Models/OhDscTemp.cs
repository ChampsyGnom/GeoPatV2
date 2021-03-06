using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("DSC_TEMP_OH",Schema="OH")]
    public partial class OhDscTemp : ModelBase
    {
        private OhCdFam _ohCdFam;
        public virtual OhCdFam OhCdFam 
        {
            get
            {
                return this._ohCdFam;
                
            }
            set
            {
                this._ohCdFam = value;
                this.CdFamOhFamille = this._ohCdFam.Famille;
            }
        }
        
        [Required()]
        [Column("CD_FAM_OH_ID_PK",Order=0)]
        public Int64 OhCdFamIdPk {get;set;}
        
        private OhCdType _ohCdType;
        public virtual OhCdType OhCdType 
        {
            get
            {
                return this._ohCdType;
                
            }
            set
            {
                this._ohCdType = value;
                this.CdTypeOhType = this._ohCdType.Type;
            }
        }
        
        [Required()]
        [Column("CD_TYPE_OH_ID_PK",Order=1)]
        public Int64 OhCdTypeIdPk {get;set;}
        
        private OhCdSousType _ohCdSousType;
        public virtual OhCdSousType OhCdSousType 
        {
            get
            {
                return this._ohCdSousType;
                
            }
            set
            {
                this._ohCdSousType = value;
                this.CdSousTypeOhSousType = this._ohCdSousType.SousType;
            }
        }
        
        [Column("CD_SOUS_TYPE_OH_ID_PK",Order=2)]
        public Nullable<Int64> OhCdSousTypeIdPk {get;set;}
        
        private OhCdMo _ohCdMo;
        public virtual OhCdMo OhCdMo 
        {
            get
            {
                return this._ohCdMo;
                
            }
            set
            {
                this._ohCdMo = value;
                this.CdMoOhMo = this._ohCdMo.Mo;
            }
        }
        
        [Column("CD_MO_OH_ID_PK",Order=3)]
        public Nullable<Int64> OhCdMoIdPk {get;set;}
        
        private OhCdEntp _ohCdEntp;
        public virtual OhCdEntp OhCdEntp 
        {
            get
            {
                return this._ohCdEntp;
                
            }
            set
            {
                this._ohCdEntp = value;
                this.CdEntpOhEntreprise = this._ohCdEntp.Entreprise;
            }
        }
        
        [Column("CD_ENTP_OH_ID_PK",Order=4)]
        public Nullable<Int64> OhCdEntpIdPk {get;set;}
        
        private OhCdMat _ohCdMat;
        public virtual OhCdMat OhCdMat 
        {
            get
            {
                return this._ohCdMat;
                
            }
            set
            {
                this._ohCdMat = value;
                this.CdMatOhCode = this._ohCdMat.Code;
            }
        }
        
        [Column("CD_MAT_OH_ID_PK",Order=5)]
        public Nullable<Int64> OhCdMatIdPk {get;set;}
        
        private OhCdNomEau _ohCdNomEau;
        public virtual OhCdNomEau OhCdNomEau 
        {
            get
            {
                return this._ohCdNomEau;
                
            }
            set
            {
                this._ohCdNomEau = value;
                this.CdNomEauOhNom = this._ohCdNomEau.Nom;
            }
        }
        
        [Column("CD_NOM_EAU_OH_ID_PK",Order=6)]
        public Nullable<Int64> OhCdNomEauIdPk {get;set;}
        
        private OhCdExt _ohCdExt;
        public virtual OhCdExt OhCdExt 
        {
            get
            {
                return this._ohCdExt;
                
            }
            set
            {
                this._ohCdExt = value;
                this.CdExtOhType = this._ohCdExt.Type;
            }
        }
        
        [Column("CD_EXT_OH_ID_PK",Order=7)]
        public Nullable<Int64> OhCdExtIdPk {get;set;}
        
        private OhCdTeteAv _ohCdTeteAv;
        public virtual OhCdTeteAv OhCdTeteAv 
        {
            get
            {
                return this._ohCdTeteAv;
                
            }
            set
            {
                this._ohCdTeteAv = value;
                this.CdTeteAvOhTeteAv = this._ohCdTeteAv.TeteAv;
            }
        }
        
        [Column("CD_TETE_AV_OH_ID_PK",Order=8)]
        public Nullable<Int64> OhCdTeteAvIdPk {get;set;}
        
        private OhCdTeteAm _ohCdTeteAm;
        public virtual OhCdTeteAm OhCdTeteAm 
        {
            get
            {
                return this._ohCdTeteAm;
                
            }
            set
            {
                this._ohCdTeteAm = value;
                this.CdTeteAmOhTeteAm = this._ohCdTeteAm.TeteAm;
            }
        }
        
        [Column("CD_TETE_AM_OH_ID_PK",Order=9)]
        public Nullable<Int64> OhCdTeteAmIdPk {get;set;}
        
        private OhCdProAm _ohCdProAm;
        public virtual OhCdProAm OhCdProAm 
        {
            get
            {
                return this._ohCdProAm;
                
            }
            set
            {
                this._ohCdProAm = value;
                this.CdProAmOhProtect = this._ohCdProAm.Protect;
            }
        }
        
        [Column("CD_PRO_AM_OH_ID_PK",Order=10)]
        public Nullable<Int64> OhCdProAmIdPk {get;set;}
        
        private OhCdProAv _ohCdProAv;
        public virtual OhCdProAv OhCdProAv 
        {
            get
            {
                return this._ohCdProAv;
                
            }
            set
            {
                this._ohCdProAv = value;
                this.CdProAvOhProtect = this._ohCdProAv.Protect;
            }
        }
        
        [Column("CD_PRO_AV_OH_ID_PK",Order=11)]
        public Nullable<Int64> OhCdProAvIdPk {get;set;}
        
        private OhCdEau _ohCdEau;
        public virtual OhCdEau OhCdEau 
        {
            get
            {
                return this._ohCdEau;
                
            }
            set
            {
                this._ohCdEau = value;
                this.CdEauOhEau = this._ohCdEau.Eau;
            }
        }
        
        [Column("CD_EAU_OH_ID_PK",Order=12)]
        public Nullable<Int64> OhCdEauIdPk {get;set;}
        
        private OhCdOuv _ohCdOuv;
        public virtual OhCdOuv OhCdOuv 
        {
            get
            {
                return this._ohCdOuv;
                
            }
            set
            {
                this._ohCdOuv = value;
                this.CdOuvOhOuv = this._ohCdOuv.Ouv;
            }
        }
        
        [Column("CD_OUV_OH_ID_PK",Order=13)]
        public Nullable<Int64> OhCdOuvIdPk {get;set;}
        
        private OhCdEcoul _ohCdEcoul;
        public virtual OhCdEcoul OhCdEcoul 
        {
            get
            {
                return this._ohCdEcoul;
                
            }
            set
            {
                this._ohCdEcoul = value;
                this.CdEcoulOhEcoul = this._ohCdEcoul.Ecoul;
            }
        }
        
        [Column("CD_ECOUL_OH_ID_PK",Order=14)]
        public Nullable<Int64> OhCdEcoulIdPk {get;set;}
        
        private OhCamp _ohCamp;
        public virtual OhCamp OhCamp 
        {
            get
            {
                return this._ohCamp;
                
            }
            set
            {
                this._ohCamp = value;
                this.CampOhIdCamp = this._ohCamp.IdCamp;
            }
        }
        
        [Required()]
        [Column("CAMP_OH_ID_PK",Order=15)]
        public Int64 OhCampIdPk {get;set;}
        
        private OhDsc _ohDsc;
        public virtual OhDsc OhDsc 
        {
            get
            {
                return this._ohDsc;
                
            }
            set
            {
                this._ohDsc = value;
                this.DscOhNumOh = this._ohDsc.NumOh;
            }
        }
        
        [Column("DSC_OH_ID_PK",Order=16)]
        public Nullable<Int64> OhDscIdPk {get;set;}
        
        public virtual ICollection<OhInspTmp> OhInspTmps { get; set; }
        
        [Key]
        [Column("ID_PK",Order=17)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant Campagne")]
        [Column("CAMP_OH__ID_CAMP",Order=18)]
        [Required()]
        [MaxLength(100)] 
        public String CampOhIdCamp { get; set; }
        
        [Description("NumOH")]
        [Column("NUM_OH",Order=19)]
        [Required()]
        [MaxLength(20)] 
        public String NumOh { get; set; }
        
        [Description("Protection Amont")]
        [Column("CD_PRO_AM_OH__PROTECT",Order=20)]
        [MaxLength(60)] 
        public String CdProAmOhProtect { get; set; }
        
        [Description("Profil")]
        [Column("CD_OUV_OH__OUV",Order=21)]
        [MaxLength(60)] 
        public String CdOuvOhOuv { get; set; }
        
        [Description("Type exutoire")]
        [Column("CD_EXT_OH__TYPE",Order=22)]
        [MaxLength(60)] 
        public String CdExtOhType { get; set; }
        
        [Description("NumOH2")]
        [Column("DSC_OH__NUM_OH",Order=23)]
        [MaxLength(20)] 
        public String DscOhNumOh { get; set; }
        
        [Description("Tête amont")]
        [Column("CD_TETE_AM_OH__TETE_AM",Order=24)]
        [MaxLength(60)] 
        public String CdTeteAmOhTeteAm { get; set; }
        
        [Description("Nom cours d'eau")]
        [Column("CD_NOM_EAU_OH__NOM",Order=25)]
        [MaxLength(60)] 
        public String CdNomEauOhNom { get; set; }
        
        [Description("Type OH")]
        [Column("CD_TYPE_OH__TYPE",Order=26)]
        [Required()]
        [MaxLength(60)] 
        public String CdTypeOhType { get; set; }
        
        [Description("Eaux collectées")]
        [Column("CD_EAU_OH__EAU",Order=27)]
        [MaxLength(60)] 
        public String CdEauOhEau { get; set; }
        
        [Description("Ecoulement")]
        [Column("CD_ECOUL_OH__ECOUL",Order=28)]
        [MaxLength(60)] 
        public String CdEcoulOhEcoul { get; set; }
        
        [Description("Matériaux")]
        [Column("CD_MAT_OH__CODE",Order=29)]
        [MaxLength(60)] 
        public String CdMatOhCode { get; set; }
        
        [Description("Tête aval")]
        [Column("CD_TETE_AV_OH__TETE_AV",Order=30)]
        [MaxLength(60)] 
        public String CdTeteAvOhTeteAv { get; set; }
        
        [Description("Maitre d'ouvrage")]
        [Column("CD_MO_OH__MO",Order=31)]
        [MaxLength(60)] 
        public String CdMoOhMo { get; set; }
        
        [Description("Entreprise")]
        [Column("CD_ENTP_OH__ENTREPRISE",Order=32)]
        [MaxLength(60)] 
        public String CdEntpOhEntreprise { get; set; }
        
        [Description("Famille")]
        [Column("CD_FAM_OH__FAMILLE",Order=33)]
        [Required()]
        [MaxLength(20)] 
        public String CdFamOhFamille { get; set; }
        
        [Description("Protection Aval")]
        [Column("CD_PRO_AV_OH__PROTECT",Order=34)]
        [MaxLength(60)] 
        public String CdProAvOhProtect { get; set; }
        
        [Description("Sous type OH")]
        [Column("CD_SOUS_TYPE_OH__SOUS_TYPE",Order=35)]
        [MaxLength(60)] 
        public String CdSousTypeOhSousType { get; set; }
        
        [Description("Liaison")]
        [Column("LIAISON",Order=36)]
        [Required()]
        [MaxLength(15)] 
        public String Liaison { get; set; }
        
        [Description("Sens")]
        [Column("SENS",Order=37)]
        [Required()]
        [MaxLength(6)] 
        public String Sens { get; set; }
        
        [Description("PR")]
        [Column("ABS_DEB",Order=38)]
        [Required()]
        public Int64 AbsDeb { get; set; }
        
        [Description("Pr fin")]
        [Column("ABS_FIN",Order=39)]
        public Nullable<Int64> AbsFin { get; set; }
        
        [Description("N° d'exploitation")]
        [Column("NUM_EXPLOIT",Order=40)]
        [MaxLength(30)] 
        public String NumExploit { get; set; }
        
        [Description("Date MS")]
        [Column("DATE_MS",Order=41)]
        public Nullable<DateTime> DateMs { get; set; }
        
        [Description("Longueur (m)")]
        [Column("LONGUEUR",Order=42)]
        public Nullable<Double> Longueur { get; set; }
        
        [Description("Hauteur (mm)")]
        [Column("HAUTEUR",Order=43)]
        public Nullable<Int64> Hauteur { get; set; }
        
        [Description("Biais (degré)")]
        [Column("BIAIS",Order=44)]
        public Nullable<Int64> Biais { get; set; }
        
        [Description("Pente (%)")]
        [Column("PENTE",Order=45)]
        public Nullable<Double> Pente { get; set; }
        
        [Description("Portée - Ø (mm)")]
        [Column("PORTEE",Order=46)]
        public Nullable<Int64> Portee { get; set; }
        
        [Description("Jumellé")]
        [Column("JUM",Order=47)]
        public Nullable<Int64> Jum { get; set; }
        
        [Description("Nbre élément")]
        [Column("ELEM",Order=48)]
        public Nullable<Int64> Elem { get; set; }
        
        [Description("Nbre regard")]
        [Column("REGARD",Order=49)]
        public Nullable<Int64> Regard { get; set; }
        
        [Description("Ouvrage Perché")]
        [Column("PERCHE",Order=50)]
        public Nullable<int> PercheValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> Perche 
        {
            get
            {
                if (PercheValueInt.HasValue) return Convert.ToBoolean(PercheValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.PercheValueInt = Convert.ToInt32(value.Value);}
                else {this.PercheValueInt =null;}
            }
        }
        
        [Description("Vulnérabilité")]
        [Column("VULNERABLE",Order=51)]
        public Nullable<int> VulnerableValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> Vulnerable 
        {
            get
            {
                if (VulnerableValueInt.HasValue) return Convert.ToBoolean(VulnerableValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.VulnerableValueInt = Convert.ToInt32(value.Value);}
                else {this.VulnerableValueInt =null;}
            }
        }
        
        [Description("Aménagement petite faune")]
        [Column("FAUNE",Order=52)]
        public Nullable<int> FauneValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> Faune 
        {
            get
            {
                if (FauneValueInt.HasValue) return Convert.ToBoolean(FauneValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.FauneValueInt = Convert.ToInt32(value.Value);}
                else {this.FauneValueInt =null;}
            }
        }
        
        [Description("Loi sur l'eau")]
        [Column("LOI",Order=53)]
        public Nullable<int> LoiValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> Loi 
        {
            get
            {
                if (LoiValueInt.HasValue) return Convert.ToBoolean(LoiValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.LoiValueInt = Convert.ToInt32(value.Value);}
                else {this.LoiValueInt =null;}
            }
        }
        
        [Description("Niveau PHE (mm)")]
        [Column("PHE",Order=54)]
        public Nullable<Int64> Phe { get; set; }
        
        [Description("Débit-projet")]
        [Column("DEBIT",Order=55)]
        public Nullable<Int64> Debit { get; set; }
        
        [Description("Connexion Aval")]
        [Column("OUV_AVAL",Order=56)]
        [MaxLength(200)] 
        public String OuvAval { get; set; }
        
        [Description("Note Abords Amont")]
        [Column("NOTE1",Order=57)]
        public Nullable<Int64> Note1 { get; set; }
        
        [Description("Note Protection Amont")]
        [Column("NOTE2",Order=58)]
        public Nullable<Int64> Note2 { get; set; }
        
        [Description("Note Conduit")]
        [Column("NOTE3",Order=59)]
        public Nullable<Int64> Note3 { get; set; }
        
        [Description("Note Protection Aval")]
        [Column("NOTE4",Order=60)]
        public Nullable<Int64> Note4 { get; set; }
        
        [Description("Note Abord Aval")]
        [Column("NOTE5",Order=61)]
        public Nullable<Int64> Note5 { get; set; }
        
        [Description("Niveau Urgence")]
        [Column("URGENCE",Order=62)]
        [MaxLength(5)] 
        public String Urgence { get; set; }
        
        [Description("Description invalide")]
        [Column("DESC_INVA",Order=63)]
        [MaxLength(1000)] 
        public String DescInva { get; set; }
        
        [Description("Problème de sécurité")]
        [Column("SECURITE",Order=64)]
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
        [Column("PRIORITAIRE",Order=65)]
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
        [Column("PROSURV_ANNEE",Order=66)]
        public Nullable<Int64> ProsurvAnnee { get; set; }
        
        [Description("Dernière Inspection")]
        [Column("DERN_INSP",Order=67)]
        public Nullable<DateTime> DernInsp { get; set; }
        
        [Description("Dernière Visite")]
        [Column("DERN_VST",Order=68)]
        public Nullable<DateTime> DernVst { get; set; }
        
        [Description("Note Visite")]
        [Column("NOTE_VST",Order=69)]
        [MaxLength(5)] 
        public String NoteVst { get; set; }
        
        [Description("Archive")]
        [Column("ARCHIVE",Order=70)]
        [MaxLength(255)] 
        public String Archive { get; set; }
        
        [Description("Commentaire")]
        [Column("COMMENTAIRE",Order=71)]
        [MaxLength(1000)] 
        public String Commentaire { get; set; }
        
        [Description("X1")]
        [Column("X1",Order=72)]
        public Nullable<Double> X1 { get; set; }
        
        [Description("Y1")]
        [Column("Y1",Order=73)]
        public Nullable<Double> Y1 { get; set; }
        
        [Description("Z1")]
        [Column("Z1",Order=74)]
        public Nullable<Double> Z1 { get; set; }
        
        [Description("X2")]
        [Column("X2",Order=75)]
        public Nullable<Double> X2 { get; set; }
        
        [Description("Y2")]
        [Column("Y2",Order=76)]
        public Nullable<Double> Y2 { get; set; }
        
        [Description("Z2")]
        [Column("Z2",Order=77)]
        public Nullable<Double> Z2 { get; set; }
        
        [Description("Date relevé")]
        [Column("DATE_RELEVE",Order=78)]
        public Nullable<DateTime> DateReleve { get; set; }
        
        [Description("Terrain")]
        [Column("TERRAIN",Order=79)]
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
