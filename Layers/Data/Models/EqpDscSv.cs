using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("DSC_SV_EQP",Schema="EQP")]
    public partial class EqpDscSv : ModelBase
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
        [Column("CD_POSIT_EQP_ID_PK",Order=1)]
        public Int64 EqpCdPositIdPk {get;set;}
        
        private EqpCdProtect _eqpCdProtect;
        public virtual EqpCdProtect EqpCdProtect 
        {
            get
            {
                return this._eqpCdProtect;
                
            }
            set
            {
                this._eqpCdProtect = value;
                this.CdProtectEqpProtect = this._eqpCdProtect.Protect;
            }
        }
        
        [Column("CD_PROTECT_EQP_ID_PK",Order=2)]
        public Nullable<Int64> EqpCdProtectIdPk {get;set;}
        
        private EqpCdSupportSv _eqpCdSupportSv;
        public virtual EqpCdSupportSv EqpCdSupportSv 
        {
            get
            {
                return this._eqpCdSupportSv;
                
            }
            set
            {
                this._eqpCdSupportSv = value;
                this.CdSupportSvEqpSupport = this._eqpCdSupportSv.Support;
            }
        }
        
        [Column("CD_SUPPORT_SV_EQP_ID_PK",Order=3)]
        public Nullable<Int64> EqpCdSupportSvIdPk {get;set;}
        
        private EqpCdFondation _eqpCdFondation;
        public virtual EqpCdFondation EqpCdFondation 
        {
            get
            {
                return this._eqpCdFondation;
                
            }
            set
            {
                this._eqpCdFondation = value;
                this.CdFondationEqpFondation = this._eqpCdFondation.Fondation;
            }
        }
        
        [Column("CD_FONDATION_EQP_ID_PK",Order=4)]
        public Nullable<Int64> EqpCdFondationIdPk {get;set;}
        
        private EqpCdFamSv _eqpCdFamSv;
        public virtual EqpCdFamSv EqpCdFamSv 
        {
            get
            {
                return this._eqpCdFamSv;
                
            }
            set
            {
                this._eqpCdFamSv = value;
                this.CdFamSvEqpFamille = this._eqpCdFamSv.Famille;
            }
        }
        
        [Required()]
        [Column("CD_FAM_SV_EQP_ID_PK",Order=5)]
        public Int64 EqpCdFamSvIdPk {get;set;}
        
        public virtual ICollection<EqpPanneau> EqpPanneaus { get; set; }
        
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
        [Column("NUM_EXPLOIT",Order=8)]
        [Required()]
        [MaxLength(30)] 
        public String NumExploit { get; set; }
        
        [Description("Type fondation")]
        [Column("CD_FONDATION_EQP__FONDATION",Order=9)]
        [MaxLength(60)] 
        public String CdFondationEqpFondation { get; set; }
        
        [Description("Entreprise")]
        [Column("CD_ENTP_EQP__ENTREPRISE",Order=10)]
        [MaxLength(60)] 
        public String CdEntpEqpEntreprise { get; set; }
        
        [Description("Type support")]
        [Column("CD_SUPPORT_SV_EQP__SUPPORT",Order=11)]
        [MaxLength(60)] 
        public String CdSupportSvEqpSupport { get; set; }
        
        [Description("Protection")]
        [Column("CD_PROTECT_EQP__PROTECT",Order=12)]
        [MaxLength(60)] 
        public String CdProtectEqpProtect { get; set; }
        
        [Description("Famille")]
        [Column("CD_FAM_SV_EQP__FAMILLE",Order=13)]
        [Required()]
        [MaxLength(6)] 
        public String CdFamSvEqpFamille { get; set; }
        
        [Description("Liaison")]
        [Column("LIAISON",Order=14)]
        [Required()]
        [MaxLength(15)] 
        public String Liaison { get; set; }
        
        [Description("Sens")]
        [Column("SENS",Order=15)]
        [Required()]
        [MaxLength(6)] 
        public String Sens { get; set; }
        
        [Description("PR Début")]
        [Column("ABS_DEB",Order=16)]
        [Required()]
        public Int64 AbsDeb { get; set; }
        
        [Description("Date MS")]
        [Column("DATE_MS",Order=17)]
        public Nullable<DateTime> DateMs { get; set; }
        
        [Description("Massif")]
        [Column("MASSIF",Order=18)]
        [MaxLength(20)] 
        public String Massif { get; set; }
        
        [Description("Nbre de support")]
        [Column("NBRE_SUPPORT",Order=19)]
        public Nullable<Int64> NbreSupport { get; set; }
        
        [Description("Classe de flexion")]
        [Column("RESIST",Order=20)]
        public Nullable<Int64> Resist { get; set; }
        
        [Description("Eclairage")]
        [Column("ECLAIRAGE",Order=21)]
        public Nullable<int> EclairageValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> Eclairage 
        {
            get
            {
                if (EclairageValueInt.HasValue) return Convert.ToBoolean(EclairageValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.EclairageValueInt = Convert.ToInt32(value.Value);}
                else {this.EclairageValueInt =null;}
            }
        }
        
        [Description("Accessibilité")]
        [Column("ACCESSIBILITE",Order=22)]
        public Nullable<int> AccessibiliteValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> Accessibilite 
        {
            get
            {
                if (AccessibiliteValueInt.HasValue) return Convert.ToBoolean(AccessibiliteValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.AccessibiliteValueInt = Convert.ToInt32(value.Value);}
                else {this.AccessibiliteValueInt =null;}
            }
        }
        
        [Description("Hauteur sous panneau (m)")]
        [Column("HAUTEUR_SP",Order=23)]
        public Nullable<Double> HauteurSp { get; set; }
        
        [Description("Commentaire")]
        [Column("COMMENTAIRE",Order=24)]
        [MaxLength(255)] 
        public String Commentaire { get; set; }
        
        [Description("X1")]
        [Column("X1",Order=25)]
        public Nullable<Double> X1 { get; set; }
        
        [Description("Y1")]
        [Column("Y1",Order=26)]
        public Nullable<Double> Y1 { get; set; }
        
        [Description("Z1")]
        [Column("Z1",Order=27)]
        public Nullable<Double> Z1 { get; set; }
        
        [Description("Date relevé")]
        [Column("DATE_RELEVE",Order=28)]
        public Nullable<DateTime> DateReleve { get; set; }
        
        [Description("Terrain")]
        [Column("TERRAIN",Order=29)]
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
