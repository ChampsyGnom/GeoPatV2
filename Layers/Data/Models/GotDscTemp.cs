using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("DSC_TEMP_GOT",Schema="GOT")]
    public partial class GotDscTemp : ModelBase
    {
        private GotCdFam _gotCdFam;
        public virtual GotCdFam GotCdFam 
        {
            get
            {
                return this._gotCdFam;
                
            }
            set
            {
                this._gotCdFam = value;
                this.CdFamGotFamille = this._gotCdFam.Famille;
            }
        }
        
        [Required()]
        [Column("CD_FAM_GOT_ID_PK",Order=0)]
        public Int64 GotCdFamIdPk {get;set;}
        
        private GotCdType _gotCdType;
        public virtual GotCdType GotCdType 
        {
            get
            {
                return this._gotCdType;
                
            }
            set
            {
                this._gotCdType = value;
                this.CdTypeGotType = this._gotCdType.Type;
            }
        }
        
        [Column("CD_TYPE_GOT_ID_PK",Order=1)]
        public Nullable<Int64> GotCdTypeIdPk {get;set;}
        
        private GotCdPente _gotCdPente;
        public virtual GotCdPente GotCdPente 
        {
            get
            {
                return this._gotCdPente;
                
            }
            set
            {
                this._gotCdPente = value;
                this.CdPenteGotPente = this._gotCdPente.Pente;
            }
        }
        
        [Column("CD_PENTE_GOT_ID_PK",Order=2)]
        public Nullable<Int64> GotCdPenteIdPk {get;set;}
        
        private GotCdEntp _gotCdEntp;
        public virtual GotCdEntp GotCdEntp 
        {
            get
            {
                return this._gotCdEntp;
                
            }
            set
            {
                this._gotCdEntp = value;
                this.CdEntpGotEntreprise = this._gotCdEntp.Entreprise;
            }
        }
        
        [Column("CD_ENTP_GOT_ID_PK",Order=3)]
        public Nullable<Int64> GotCdEntpIdPk {get;set;}
        
        private GotCdProtect _gotCdProtect;
        public virtual GotCdProtect GotCdProtect 
        {
            get
            {
                return this._gotCdProtect;
                
            }
            set
            {
                this._gotCdProtect = value;
                this.CdProtectGotType = this._gotCdProtect.Type;
            }
        }
        
        [Column("CD_PROTECT_GOT_ID_PK",Order=4)]
        public Nullable<Int64> GotCdProtectIdPk {get;set;}
        
        private GotCdGeo _gotCdGeo;
        public virtual GotCdGeo GotCdGeo 
        {
            get
            {
                return this._gotCdGeo;
                
            }
            set
            {
                this._gotCdGeo = value;
                this.CdGeoGotGeologie = this._gotCdGeo.Geologie;
            }
        }
        
        [Column("CD_GEO_GOT_ID_PK",Order=5)]
        public Nullable<Int64> GotCdGeoIdPk {get;set;}
        
        private GotCamp _gotCamp;
        public virtual GotCamp GotCamp 
        {
            get
            {
                return this._gotCamp;
                
            }
            set
            {
                this._gotCamp = value;
                this.CampGotIdCamp = this._gotCamp.IdCamp;
            }
        }
        
        [Required()]
        [Column("CAMP_GOT_ID_PK",Order=6)]
        public Int64 GotCampIdPk {get;set;}
        
        private GotDsc _gotDsc;
        public virtual GotDsc GotDsc 
        {
            get
            {
                return this._gotDsc;
                
            }
            set
            {
                this._gotDsc = value;
                this.DscGotNumGot = this._gotDsc.NumGot;
            }
        }
        
        [Column("DSC_GOT_ID_PK",Order=7)]
        public Nullable<Int64> GotDscIdPk {get;set;}
        
        public virtual ICollection<GotInspTmp> GotInspTmps { get; set; }
        
        [Key]
        [Column("ID_PK",Order=8)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant campagne")]
        [Column("CAMP_GOT__ID_CAMP",Order=9)]
        [Required()]
        [MaxLength(100)] 
        public String CampGotIdCamp { get; set; }
        
        [Description("N° Ouvrage")]
        [Column("NUM_GOT",Order=10)]
        [Required()]
        [MaxLength(17)] 
        public String NumGot { get; set; }
        
        [Description("Entreprise")]
        [Column("CD_ENTP_GOT__ENTREPRISE",Order=11)]
        [MaxLength(60)] 
        public String CdEntpGotEntreprise { get; set; }
        
        [Description("Type")]
        [Column("CD_TYPE_GOT__TYPE",Order=12)]
        [MaxLength(20)] 
        public String CdTypeGotType { get; set; }
        
        [Description("Pente")]
        [Column("CD_PENTE_GOT__PENTE",Order=13)]
        [MaxLength(25)] 
        public String CdPenteGotPente { get; set; }
        
        [Description("Protections")]
        [Column("CD_PROTECT_GOT__TYPE",Order=14)]
        [MaxLength(60)] 
        public String CdProtectGotType { get; set; }
        
        [Description("Profil")]
        [Column("CD_FAM_GOT__FAMILLE",Order=15)]
        [Required()]
        [MaxLength(20)] 
        public String CdFamGotFamille { get; set; }
        
        [Description("Géologie")]
        [Column("CD_GEO_GOT__GEOLOGIE",Order=16)]
        [MaxLength(60)] 
        public String CdGeoGotGeologie { get; set; }
        
        [Description("N° Ouvrage2")]
        [Column("DSC_GOT__NUM_GOT",Order=17)]
        [MaxLength(17)] 
        public String DscGotNumGot { get; set; }
        
        [Description("Liaison")]
        [Column("LIAISON",Order=18)]
        [Required()]
        [MaxLength(15)] 
        public String Liaison { get; set; }
        
        [Description("Sens")]
        [Column("SENS",Order=19)]
        [Required()]
        [MaxLength(6)] 
        public String Sens { get; set; }
        
        [Description("Début")]
        [Column("ABS_DEB",Order=20)]
        [Required()]
        public Int64 AbsDeb { get; set; }
        
        [Description("Fin")]
        [Column("ABS_FIN",Order=21)]
        [Required()]
        public Int64 AbsFin { get; set; }
        
        [Description("No D'exploitation")]
        [Column("NUM_EXPLOIT",Order=22)]
        [MaxLength(30)] 
        public String NumExploit { get; set; }
        
        [Description("Date achèvement")]
        [Column("DATE_CONST",Order=23)]
        public Nullable<DateTime> DateConst { get; set; }
        
        [Description("Pente TN >15%")]
        [Column("PENTE_TN",Order=24)]
        public Nullable<int> PenteTnValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> PenteTn 
        {
            get
            {
                if (PenteTnValueInt.HasValue) return Convert.ToBoolean(PenteTnValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.PenteTnValueInt = Convert.ToInt32(value.Value);}
                else {this.PenteTnValueInt =null;}
            }
        }
        
        [Description("Hauteur Max (m)")]
        [Column("HAUT",Order=25)]
        public Nullable<Int64> Haut { get; set; }
        
        [Description("Largeur crête (m)")]
        [Column("LARG_CRETE",Order=26)]
        public Nullable<Double> LargCrete { get; set; }
        
        [Description("Volume (m3)")]
        [Column("VOLUME",Order=27)]
        public Nullable<Int64> Volume { get; set; }
        
        [Description("Nbre Risberme")]
        [Column("RISB_NBR",Order=28)]
        public Nullable<Int64> RisbNbr { get; set; }
        
        [Description("Espacem. Risberme")]
        [Column("RISB_ESP",Order=29)]
        public Nullable<Double> RisbEsp { get; set; }
        
        [Description("Larg Risberme")]
        [Column("RISB_LARG",Order=30)]
        public Nullable<Double> RisbLarg { get; set; }
        
        [Description("PHE Hauteur plus hautes eaux")]
        [Column("HAUT_EAU",Order=31)]
        public Nullable<Double> HautEau { get; set; }
        
        [Description("Site instable")]
        [Column("INSTABLE",Order=32)]
        public Nullable<int> InstableValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> Instable 
        {
            get
            {
                if (InstableValueInt.HasValue) return Convert.ToBoolean(InstableValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.InstableValueInt = Convert.ToInt32(value.Value);}
                else {this.InstableValueInt =null;}
            }
        }
        
        [Description("Nom d'usage")]
        [Column("NOM_USAGE",Order=33)]
        [MaxLength(255)] 
        public String NomUsage { get; set; }
        
        [Description("Note Plateforme 1")]
        [Column("NOTE1",Order=34)]
        public Nullable<Int64> Note1 { get; set; }
        
        [Description("Note Plateforme 2")]
        [Column("NOTE2",Order=35)]
        public Nullable<Int64> Note2 { get; set; }
        
        [Description("Note Talus 1")]
        [Column("NOTE3",Order=36)]
        public Nullable<Int64> Note3 { get; set; }
        
        [Description("Note Talus 2")]
        [Column("NOTE4",Order=37)]
        public Nullable<Int64> Note4 { get; set; }
        
        [Description("Note Environnement")]
        [Column("NOTE5",Order=38)]
        public Nullable<Int64> Note5 { get; set; }
        
        [Description("Note Urgence")]
        [Column("URGENCE",Order=39)]
        [MaxLength(5)] 
        public String Urgence { get; set; }
        
        [Description("Description invalide")]
        [Column("DESC_INVA",Order=40)]
        [MaxLength(1000)] 
        public String DescInva { get; set; }
        
        [Description("Problème de sécurité")]
        [Column("SECURITE",Order=41)]
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
        [Column("PRIORITAIRE",Order=42)]
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
        
        [Description("Prochaine surveillance")]
        [Column("PROSURV_ANNEE",Order=43)]
        public Nullable<Int64> ProsurvAnnee { get; set; }
        
        [Description("Dernière inspection")]
        [Column("DERN_INSP",Order=44)]
        public Nullable<DateTime> DernInsp { get; set; }
        
        [Description("Dernière Visite")]
        [Column("DERN_VST",Order=45)]
        public Nullable<DateTime> DernVst { get; set; }
        
        [Description("Note Visite")]
        [Column("NOTE_VST",Order=46)]
        [MaxLength(5)] 
        public String NoteVst { get; set; }
        
        [Description("Archive")]
        [Column("ARCHIVE",Order=47)]
        [MaxLength(255)] 
        public String Archive { get; set; }
        
        [Description("Commentaire")]
        [Column("COMMENTAIRE",Order=48)]
        [MaxLength(500)] 
        public String Commentaire { get; set; }
        
        [Description("X1")]
        [Column("X1",Order=49)]
        public Nullable<Double> X1 { get; set; }
        
        [Description("Y1")]
        [Column("Y1",Order=50)]
        public Nullable<Double> Y1 { get; set; }
        
        [Description("Z1")]
        [Column("Z1",Order=51)]
        public Nullable<Double> Z1 { get; set; }
        
        [Description("Date relevé")]
        [Column("DATE_RELEVE",Order=52)]
        public Nullable<DateTime> DateReleve { get; set; }
        
        [Description("Terrain")]
        [Column("TERRAIN",Order=53)]
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
        
        [Description("X2")]
        [Column("X2",Order=54)]
        public Nullable<Double> X2 { get; set; }
        
        [Description("Y2")]
        [Column("Y2",Order=55)]
        public Nullable<Double> Y2 { get; set; }
        
        [Description("Z2")]
        [Column("Z2",Order=56)]
        public Nullable<Double> Z2 { get; set; }
        
    }
}
