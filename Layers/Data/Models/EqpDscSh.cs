using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("DSC_SH_EQP",Schema="EQP")]
    public partial class EqpDscSh : ModelBase
    {
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
        
        [Column("CD_ENTP_EQP_ID_PK",Order=0)]
        public Nullable<Int64> EqpCdEntpIdPk {get;set;}
        
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
        
        private EqpCdProduitSh _eqpCdProduitSh;
        public virtual EqpCdProduitSh EqpCdProduitSh 
        {
            get
            {
                return this._eqpCdProduitSh;
                
            }
            set
            {
                this._eqpCdProduitSh = value;
                this.CdProduitShEqpProduit = this._eqpCdProduitSh.Produit;
            }
        }
        
        [Column("CD_PRODUIT_SH_EQP_ID_PK",Order=2)]
        public Nullable<Int64> EqpCdProduitShIdPk {get;set;}
        
        private EqpCdBarretteSh _eqpCdBarretteSh;
        public virtual EqpCdBarretteSh EqpCdBarretteSh 
        {
            get
            {
                return this._eqpCdBarretteSh;
                
            }
            set
            {
                this._eqpCdBarretteSh = value;
                this.CdBarretteShEqpBarette = this._eqpCdBarretteSh.Barette;
            }
        }
        
        [Column("CD_BARRETTE_SH_EQP_ID_PK",Order=3)]
        public Nullable<Int64> EqpCdBarretteShIdPk {get;set;}
        
        private EqpCdMarquageSh _eqpCdMarquageSh;
        public virtual EqpCdMarquageSh EqpCdMarquageSh 
        {
            get
            {
                return this._eqpCdMarquageSh;
                
            }
            set
            {
                this._eqpCdMarquageSh = value;
                this.CdModShEqpMod = this._eqpCdMarquageSh.CdModShEqpMod;
                this.CdMarquageShEqpMarquage = this._eqpCdMarquageSh.Marquage;
            }
        }
        
        [Required()]
        [Column("CD_MARQUAGE_SH_EQP_ID_PK",Order=4)]
        public Int64 EqpCdMarquageShIdPk {get;set;}
        
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
        [Column("CD_POSIT_EQP_ID_PK",Order=5)]
        public Int64 EqpCdPositIdPk {get;set;}
        
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
        
        [Description("PR début")]
        [Column("ABS_DEB",Order=9)]
        [Required()]
        public Int64 AbsDeb { get; set; }
        
        [Description("Sens")]
        [Column("SENS",Order=10)]
        [Required()]
        [MaxLength(6)] 
        public String Sens { get; set; }
        
        [Description("N° Exploitation")]
        [Column("NUM_EXPLOIT",Order=11)]
        [MaxLength(30)] 
        public String NumExploit { get; set; }
        
        [Description("Modulation")]
        [Column("CD_MOD_SH_EQP__MOD",Order=12)]
        [Required()]
        [MaxLength(6)] 
        public String CdModShEqpMod { get; set; }
        
        [Description("Marquage")]
        [Column("CD_MARQUAGE_SH_EQP__MARQUAGE",Order=13)]
        [Required()]
        [MaxLength(255)] 
        public String CdMarquageShEqpMarquage { get; set; }
        
        [Description("Entreprise")]
        [Column("CD_ENTP_EQP__ENTREPRISE",Order=14)]
        [MaxLength(60)] 
        public String CdEntpEqpEntreprise { get; set; }
        
        [Description("Barette")]
        [Column("CD_BARRETTE_SH_EQP__BARETTE",Order=15)]
        [MaxLength(60)] 
        public String CdBarretteShEqpBarette { get; set; }
        
        [Description("Produit")]
        [Column("CD_PRODUIT_SH_EQP__PRODUIT",Order=16)]
        [MaxLength(60)] 
        public String CdProduitShEqpProduit { get; set; }
        
        [Description("Nom Fabricant")]
        [Column("CD_FABRICANT_EQP__NOM",Order=17)]
        [MaxLength(60)] 
        public String CdFabricantEqpNom { get; set; }
        
        [Description("PR fin")]
        [Column("ABS_FIN",Order=18)]
        public Nullable<Int64> AbsFin { get; set; }
        
        [Description("Date MS")]
        [Column("DATE_MS",Order=19)]
        public Nullable<DateTime> DateMs { get; set; }
        
        [Description("Revêtement VNTP")]
        [Column("REVETEMENT_VNTP",Order=20)]
        public Nullable<int> RevetementVntpValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> RevetementVntp 
        {
            get
            {
                if (RevetementVntpValueInt.HasValue) return Convert.ToBoolean(RevetementVntpValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.RevetementVntpValueInt = Convert.ToInt32(value.Value);}
                else {this.RevetementVntpValueInt =null;}
            }
        }
        
        [Description("Produit Saupoudrage")]
        [Column("SAUPOUDRAGE",Order=21)]
        public Nullable<int> SaupoudrageValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> Saupoudrage 
        {
            get
            {
                if (SaupoudrageValueInt.HasValue) return Convert.ToBoolean(SaupoudrageValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.SaupoudrageValueInt = Convert.ToInt32(value.Value);}
                else {this.SaupoudrageValueInt =null;}
            }
        }
        
        [Description("Commentaire")]
        [Column("COMMENTAIRE",Order=22)]
        [MaxLength(255)] 
        public String Commentaire { get; set; }
        
        [Description("X1")]
        [Column("X1",Order=23)]
        public Nullable<Double> X1 { get; set; }
        
        [Description("Y1")]
        [Column("Y1",Order=24)]
        public Nullable<Double> Y1 { get; set; }
        
        [Description("Z1")]
        [Column("Z1",Order=25)]
        public Nullable<Double> Z1 { get; set; }
        
        [Description("X2")]
        [Column("X2",Order=26)]
        public Nullable<Double> X2 { get; set; }
        
        [Description("Y2")]
        [Column("Y2",Order=27)]
        public Nullable<Double> Y2 { get; set; }
        
        [Description("Z2")]
        [Column("Z2",Order=28)]
        public Nullable<Double> Z2 { get; set; }
        
        [Description("Date relevé")]
        [Column("DATE_RELEVE",Order=29)]
        public Nullable<DateTime> DateReleve { get; set; }
        
        [Description("Terrain")]
        [Column("TERRAIN",Order=30)]
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
