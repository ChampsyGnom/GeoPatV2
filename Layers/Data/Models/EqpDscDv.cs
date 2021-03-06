using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("DSC_DV_EQP",Schema="EQP")]
    public partial class EqpDscDv : ModelBase
    {
        private EqpCdPosit _eqpCdPosit;
        public virtual EqpCdPosit EqpCdPosit 
        {
            get
            {
                return this._eqpCdPosit;
                
            }
            set
            {
                this._eqpCdPosit = value;
                this.CdPositEqpPosit = this._eqpCdPosit.Posit;
            }
        }
        
        [Required()]
        [Column("CD_POSIT_EQP_ID_PK",Order=0)]
        public Int64 EqpCdPositIdPk {get;set;}
        
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
        
        [Column("CD_FABRICANT_EQP_ID_PK",Order=1)]
        public Nullable<Int64> EqpCdFabricantIdPk {get;set;}
        
        private EqpCdEntp _eqpCdEntp;
        public virtual EqpCdEntp EqpCdEntp 
        {
            get
            {
                return this._eqpCdEntp;
                
            }
            set
            {
                this._eqpCdEntp = value;
                this.CdEntpEqpEntreprise = this._eqpCdEntp.Entreprise;
            }
        }
        
        [Column("CD_ENTP_EQP_ID_PK",Order=2)]
        public Nullable<Int64> EqpCdEntpIdPk {get;set;}
        
        private EqpCdTypeDv _eqpCdTypeDv;
        public virtual EqpCdTypeDv EqpCdTypeDv 
        {
            get
            {
                return this._eqpCdTypeDv;
                
            }
            set
            {
                this._eqpCdTypeDv = value;
                this.CdTypeDvEqpCode = this._eqpCdTypeDv.Code;
            }
        }
        
        [Required()]
        [Column("CD_TYPE_DV_EQP_ID_PK",Order=3)]
        public Int64 EqpCdTypeDvIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=4)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Position")]
        [Column("CD_POSIT_EQP__POSIT",Order=5)]
        [Required()]
        [MaxLength(60)] 
        public String CdPositEqpPosit { get; set; }
        
        [Description("Type")]
        [Column("CD_TYPE_DV_EQP__CODE",Order=6)]
        [Required()]
        [MaxLength(15)] 
        public String CdTypeDvEqpCode { get; set; }
        
        [Description("Liaison")]
        [Column("LIAISON",Order=7)]
        [Required()]
        [MaxLength(15)] 
        public String Liaison { get; set; }
        
        [Description("Sens")]
        [Column("SENS",Order=8)]
        [Required()]
        [MaxLength(6)] 
        public String Sens { get; set; }
        
        [Description("Pr début")]
        [Column("ABS_DEB",Order=9)]
        [Required()]
        public Int64 AbsDeb { get; set; }
        
        [Description("N° d'exploitation")]
        [Column("NUM_EXPLOIT",Order=10)]
        [MaxLength(30)] 
        public String NumExploit { get; set; }
        
        [Description("Entreprise")]
        [Column("CD_ENTP_EQP__ENTREPRISE",Order=11)]
        [MaxLength(60)] 
        public String CdEntpEqpEntreprise { get; set; }
        
        [Description("Nom Fabricant")]
        [Column("CD_FABRICANT_EQP__NOM",Order=12)]
        [MaxLength(60)] 
        public String CdFabricantEqpNom { get; set; }
        
        [Description("Pr fin")]
        [Column("ABS_FIN",Order=13)]
        [Required()]
        public Int64 AbsFin { get; set; }
        
        [Description("Date MS")]
        [Column("DATE_MS",Order=14)]
        public Nullable<DateTime> DateMs { get; set; }
        
        [Description("Alimentation")]
        [Column("ALIMENTATION",Order=15)]
        [MaxLength(60)] 
        public String Alimentation { get; set; }
        
        [Description("Commentaire")]
        [Column("COMMENTAIRE",Order=16)]
        [MaxLength(255)] 
        public String Commentaire { get; set; }
        
    }
}
