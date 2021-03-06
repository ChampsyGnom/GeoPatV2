using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PANNEAU_EQP",Schema="EQP")]
    public partial class EqpPanneau : ModelBase
    {
        private EqpCdFabricant _eqpCdFabricant;
        public virtual EqpCdFabricant EqpCdFabricant 
        {
            get
            {
                return this._eqpCdFabricant;
                
            }
            set
            {
                this._eqpCdFabricant = value;
                this.CdFabricantEqpNom = this._eqpCdFabricant.Nom;
            }
        }
        
        [Column("CD_FABRICANT_EQP_ID_PK",Order=0)]
        public Nullable<Int64> EqpCdFabricantIdPk {get;set;}
        
        private EqpCdClasseSv _eqpCdClasseSv;
        public virtual EqpCdClasseSv EqpCdClasseSv 
        {
            get
            {
                return this._eqpCdClasseSv;
                
            }
            set
            {
                this._eqpCdClasseSv = value;
                this.CdClasseSvEqpClasse = this._eqpCdClasseSv.Classe;
            }
        }
        
        [Column("CD_CLASSE_SV_EQP_ID_PK",Order=1)]
        public Nullable<Int64> EqpCdClasseSvIdPk {get;set;}
        
        private EqpCdGammeSv _eqpCdGammeSv;
        public virtual EqpCdGammeSv EqpCdGammeSv 
        {
            get
            {
                return this._eqpCdGammeSv;
                
            }
            set
            {
                this._eqpCdGammeSv = value;
                this.CdGammeSvEqpGamme = this._eqpCdGammeSv.Gamme;
            }
        }
        
        [Column("CD_GAMME_SV_EQP_ID_PK",Order=2)]
        public Nullable<Int64> EqpCdGammeSvIdPk {get;set;}
        
        private EqpDscSv _eqpDscSv;
        public virtual EqpDscSv EqpDscSv 
        {
            get
            {
                return this._eqpDscSv;
                
            }
            set
            {
                this._eqpDscSv = value;
                this.CdPositEqpPosit = this._eqpDscSv.CdPositEqpPosit;
                this.DscSvEqpNumExploit = this._eqpDscSv.NumExploit;
            }
        }
        
        [Required()]
        [Column("DSC_SV_EQP_ID_PK",Order=3)]
        public Int64 EqpDscSvIdPk {get;set;}
        
        private EqpCdStypeSv _eqpCdStypeSv;
        public virtual EqpCdStypeSv EqpCdStypeSv 
        {
            get
            {
                return this._eqpCdStypeSv;
                
            }
            set
            {
                this._eqpCdStypeSv = value;
                this.CdFamSvEqpFamille = this._eqpCdStypeSv.CdFamSvEqpFamille;
                this.CdTypeSvEqpType = this._eqpCdStypeSv.CdTypeSvEqpType;
                this.CdStypeSvEqpSType = this._eqpCdStypeSv.SType;
            }
        }
        
        [Required()]
        [Column("CD_STYPE_SV_EQP_ID_PK",Order=4)]
        public Int64 EqpCdStypeSvIdPk {get;set;}
        
        private EqpCdMatSv _eqpCdMatSv;
        public virtual EqpCdMatSv EqpCdMatSv 
        {
            get
            {
                return this._eqpCdMatSv;
                
            }
            set
            {
                this._eqpCdMatSv = value;
                this.CdMatSvEqpMateriaux = this._eqpCdMatSv.Materiaux;
            }
        }
        
        [Column("CD_MAT_SV_EQP_ID_PK",Order=5)]
        public Nullable<Int64> EqpCdMatSvIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=6)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Position")]
        [Column("CD_POSIT_EQP__POSIT",Order=7)]
        [Required()]
        [MaxLength(60)] 
        public String CdPositEqpPosit { get; set; }
        
        [Description("N°  Exploitation")]
        [Column("DSC_SV_EQP__NUM_EXPLOIT",Order=8)]
        [Required()]
        [MaxLength(30)] 
        public String DscSvEqpNumExploit { get; set; }
        
        [Description("N° ORDRE")]
        [Column("ORDRE",Order=9)]
        [Required()]
        public Int64 Ordre { get; set; }
        
        [Description("Famille")]
        [Column("CD_FAM_SV_EQP__FAMILLE",Order=10)]
        [Required()]
        [MaxLength(6)] 
        public String CdFamSvEqpFamille { get; set; }
        
        [Description("Type")]
        [Column("CD_TYPE_SV_EQP__TYPE",Order=11)]
        [Required()]
        [MaxLength(12)] 
        public String CdTypeSvEqpType { get; set; }
        
        [Description("Sous type")]
        [Column("CD_STYPE_SV_EQP__S_TYPE",Order=12)]
        [Required()]
        [MaxLength(60)] 
        public String CdStypeSvEqpSType { get; set; }
        
        [Description("Gamme")]
        [Column("CD_GAMME_SV_EQP__GAMME",Order=13)]
        [MaxLength(20)] 
        public String CdGammeSvEqpGamme { get; set; }
        
        [Description("Classe du film")]
        [Column("CD_CLASSE_SV_EQP__CLASSE",Order=14)]
        [MaxLength(5)] 
        public String CdClasseSvEqpClasse { get; set; }
        
        [Description("Matériaux")]
        [Column("CD_MAT_SV_EQP__MATERIAUX",Order=15)]
        [MaxLength(60)] 
        public String CdMatSvEqpMateriaux { get; set; }
        
        [Description("Nom Fabricant")]
        [Column("CD_FABRICANT_EQP__NOM",Order=16)]
        [MaxLength(60)] 
        public String CdFabricantEqpNom { get; set; }
        
        [Description("Date MS")]
        [Column("DATE_MS",Order=17)]
        public Nullable<DateTime> DateMs { get; set; }
        
        [Description("Hauteur (mm)")]
        [Column("HAUTEUR",Order=18)]
        public Nullable<Int64> Hauteur { get; set; }
        
        [Description("Largeur (mm)")]
        [Column("LARGEUR",Order=19)]
        public Nullable<Int64> Largeur { get; set; }
        
        [Description("Réserve")]
        [Column("RESERVE",Order=20)]
        public Nullable<Int64> Reserve { get; set; }
        
        [Description("Anti Graffiti")]
        [Column("ANTI_GRAFFITI",Order=21)]
        public Nullable<int> AntiGraffitiValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> AntiGraffiti 
        {
            get
            {
                if (AntiGraffitiValueInt.HasValue) return Convert.ToBoolean(AntiGraffitiValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.AntiGraffitiValueInt = Convert.ToInt32(value.Value);}
                else {this.AntiGraffitiValueInt =null;}
            }
        }
        
        [Description("Mention")]
        [Column("MENTION",Order=22)]
        [MaxLength(255)] 
        public String Mention { get; set; }
        
    }
}
