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
        public virtual EqpCdFabricant EqpCdFabricant {get;set;}
        
        [Column("CD_FABRICANT_EQP_ID_PK",Order=0)]
        public Nullable<Int64> EqpCdFabricantIdPk {get;set;}
        
        public virtual EqpCdClasseSv EqpCdClasseSv {get;set;}
        
        [Column("CD_CLASSE_SV_EQP_ID_PK",Order=1)]
        public Nullable<Int64> EqpCdClasseSvIdPk {get;set;}
        
        public virtual EqpCdGammeSv EqpCdGammeSv {get;set;}
        
        [Column("CD_GAMME_SV_EQP_ID_PK",Order=2)]
        public Nullable<Int64> EqpCdGammeSvIdPk {get;set;}
        
        public virtual EqpDscSv EqpDscSv {get;set;}
        
        [Required()]
        [Column("DSC_SV_EQP_ID_PK",Order=3)]
        public Int64 EqpDscSvIdPk {get;set;}
        
        public virtual EqpCdStypeSv EqpCdStypeSv {get;set;}
        
        [Required()]
        [Column("CD_STYPE_SV_EQP_ID_PK",Order=4)]
        public Int64 EqpCdStypeSvIdPk {get;set;}
        
        public virtual EqpCdMatSv EqpCdMatSv {get;set;}
        
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
