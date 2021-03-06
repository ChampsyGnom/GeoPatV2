using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("DSC_ES_EQP",Schema="EQP")]
    public partial class EqpDscEs : ModelBase
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
        
        [Column("CD_ENTP_EQP_ID_PK",Order=1)]
        public Nullable<Int64> EqpCdEntpIdPk {get;set;}
        
        private EqpCdRetenue _eqpCdRetenue;
        public virtual EqpCdRetenue EqpCdRetenue 
        {
            get
            {
                return this._eqpCdRetenue;
                
            }
            set
            {
                this._eqpCdRetenue = value;
                this.CdMateriauEqpMateriaux = this._eqpCdRetenue.CdMateriauEqpMateriaux;
                this.CdRetenueEqpDispositif = this._eqpCdRetenue.Dispositif;
            }
        }
        
        [Required()]
        [Column("CD_RETENUE_EQP_ID_PK",Order=2)]
        public Int64 EqpCdRetenueIdPk {get;set;}
        
        private EqpCdExtAm _eqpCdExtAm;
        public virtual EqpCdExtAm EqpCdExtAm 
        {
            get
            {
                return this._eqpCdExtAm;
                
            }
            set
            {
                this._eqpCdExtAm = value;
                this.CdExtAmEqpExtDeb = this._eqpCdExtAm.ExtDeb;
            }
        }
        
        [Column("CD_EXT_AM_EQP_ID_PK",Order=3)]
        public Nullable<Int64> EqpCdExtAmIdPk {get;set;}
        
        private EqpCdExtAv _eqpCdExtAv;
        public virtual EqpCdExtAv EqpCdExtAv 
        {
            get
            {
                return this._eqpCdExtAv;
                
            }
            set
            {
                this._eqpCdExtAv = value;
                this.CdExtAvEqpExtFin = this._eqpCdExtAv.ExtFin;
            }
        }
        
        [Column("CD_EXT_AV_EQP_ID_PK",Order=4)]
        public Nullable<Int64> EqpCdExtAvIdPk {get;set;}
        
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
        
        [Column("CD_FABRICANT_EQP_ID_PK",Order=5)]
        public Nullable<Int64> EqpCdFabricantIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=6)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Position")]
        [Column("CD_POSIT_EQP__POSIT",Order=7)]
        [Required()]
        [MaxLength(60)] 
        public String CdPositEqpPosit { get; set; }
        
        [Description("Liaison")]
        [Column("LIAISON",Order=8)]
        [Required()]
        [MaxLength(15)] 
        public String Liaison { get; set; }
        
        [Description("Sens")]
        [Column("SENS",Order=9)]
        [Required()]
        [MaxLength(6)] 
        public String Sens { get; set; }
        
        [Description("PR début")]
        [Column("ABS_DEB",Order=10)]
        [Required()]
        public Int64 AbsDeb { get; set; }
        
        [Description("N° Exploitation")]
        [Column("NUM_EXPLOIT",Order=11)]
        [MaxLength(30)] 
        public String NumExploit { get; set; }
        
        [Description("Entreprise")]
        [Column("CD_ENTP_EQP__ENTREPRISE",Order=12)]
        [MaxLength(60)] 
        public String CdEntpEqpEntreprise { get; set; }
        
        [Description("Extrémité fin")]
        [Column("CD_EXT_AV_EQP__EXT_FIN",Order=13)]
        [MaxLength(60)] 
        public String CdExtAvEqpExtFin { get; set; }
        
        [Description("Nom Fabricant")]
        [Column("CD_FABRICANT_EQP__NOM",Order=14)]
        [MaxLength(60)] 
        public String CdFabricantEqpNom { get; set; }
        
        [Description("Matériaux")]
        [Column("CD_MATERIAU_EQP__MATERIAUX",Order=15)]
        [Required()]
        [MaxLength(60)] 
        public String CdMateriauEqpMateriaux { get; set; }
        
        [Description("Type de Dispositif")]
        [Column("CD_RETENUE_EQP__DISPOSITIF",Order=16)]
        [Required()]
        [MaxLength(60)] 
        public String CdRetenueEqpDispositif { get; set; }
        
        [Description("Extrémité début")]
        [Column("CD_EXT_AM_EQP__EXT_DEB",Order=17)]
        [MaxLength(60)] 
        public String CdExtAmEqpExtDeb { get; set; }
        
        [Description("PR fin")]
        [Column("ABS_FIN",Order=18)]
        public Nullable<Int64> AbsFin { get; set; }
        
        [Description("Date MS")]
        [Column("DATE_MS",Order=19)]
        public Nullable<DateTime> DateMs { get; set; }
        
        [Description("Commentaire")]
        [Column("COMMENTAIRE",Order=20)]
        [MaxLength(255)] 
        public String Commentaire { get; set; }
        
        [Description("X1")]
        [Column("X1",Order=21)]
        public Nullable<Double> X1 { get; set; }
        
        [Description("Y1")]
        [Column("Y1",Order=22)]
        public Nullable<Double> Y1 { get; set; }
        
        [Description("Z1")]
        [Column("Z1",Order=23)]
        public Nullable<Double> Z1 { get; set; }
        
        [Description("X2")]
        [Column("X2",Order=24)]
        public Nullable<Double> X2 { get; set; }
        
        [Description("Y2")]
        [Column("Y2",Order=25)]
        public Nullable<Double> Y2 { get; set; }
        
        [Description("Z2")]
        [Column("Z2",Order=26)]
        public Nullable<Double> Z2 { get; set; }
        
        [Description("Date relevé")]
        [Column("DATE_RELEVE",Order=27)]
        public Nullable<DateTime> DateReleve { get; set; }
        
        [Description("Terrain")]
        [Column("TERRAIN",Order=28)]
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
