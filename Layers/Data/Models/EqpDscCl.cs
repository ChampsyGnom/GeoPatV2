using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("DSC_CL_EQP",Schema="EQP")]
    public partial class EqpDscCl : ModelBase
    {
        private EqpCdCloture _eqpCdCloture;
        public virtual EqpCdCloture EqpCdCloture 
        {
            get
            {
                return this._eqpCdCloture;
                
            }
            set
            {
                this._eqpCdCloture = value;
                this.CdClotureEqpCloture = this._eqpCdCloture.Cloture;
            }
        }
        
        [Column("CD_CLOTURE_EQP_ID_PK",Order=0)]
        public Nullable<Int64> EqpCdClotureIdPk {get;set;}
        
        private EqpCdMaille _eqpCdMaille;
        public virtual EqpCdMaille EqpCdMaille 
        {
            get
            {
                return this._eqpCdMaille;
                
            }
            set
            {
                this._eqpCdMaille = value;
                this.CdMailleEqpMaille = this._eqpCdMaille.Maille;
            }
        }
        
        [Column("CD_MAILLE_EQP_ID_PK",Order=1)]
        public Nullable<Int64> EqpCdMailleIdPk {get;set;}
        
        private EqpCdFranch _eqpCdFranch;
        public virtual EqpCdFranch EqpCdFranch 
        {
            get
            {
                return this._eqpCdFranch;
                
            }
            set
            {
                this._eqpCdFranch = value;
                this.CdFranchEqpAntiFranch = this._eqpCdFranch.AntiFranch;
            }
        }
        
        [Column("CD_FRANCH_EQP_ID_PK",Order=2)]
        public Nullable<Int64> EqpCdFranchIdPk {get;set;}
        
        private EqpCdPoteauCl _eqpCdPoteauCl;
        public virtual EqpCdPoteauCl EqpCdPoteauCl 
        {
            get
            {
                return this._eqpCdPoteauCl;
                
            }
            set
            {
                this._eqpCdPoteauCl = value;
                this.CdPoteauClEqpPoteaux = this._eqpCdPoteauCl.Poteaux;
            }
        }
        
        [Column("CD_POTEAU_CL_EQP_ID_PK",Order=3)]
        public Nullable<Int64> EqpCdPoteauClIdPk {get;set;}
        
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
        
        [Column("CD_ENTP_EQP_ID_PK",Order=5)]
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
        
        [Column("CD_FABRICANT_EQP_ID_PK",Order=6)]
        public Nullable<Int64> EqpCdFabricantIdPk {get;set;}
        
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
        [Column("CD_POSIT_EQP_ID_PK",Order=7)]
        public Int64 EqpCdPositIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=8)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Position")]
        [Column("CD_POSIT_EQP__POSIT",Order=9)]
        [Required()]
        [MaxLength(60)] 
        public String CdPositEqpPosit { get; set; }
        
        [Description("Liaison")]
        [Column("LIAISON",Order=10)]
        [Required()]
        [MaxLength(15)] 
        public String Liaison { get; set; }
        
        [Description("Sens")]
        [Column("SENS",Order=11)]
        [Required()]
        [MaxLength(6)] 
        public String Sens { get; set; }
        
        [Description("PR début")]
        [Column("ABS_DEB",Order=12)]
        [Required()]
        public Int64 AbsDeb { get; set; }
        
        [Description("N° Exploitation")]
        [Column("NUM_EXPLOIT",Order=13)]
        [MaxLength(30)] 
        public String NumExploit { get; set; }
        
        [Description("Type fondation")]
        [Column("CD_FONDATION_EQP__FONDATION",Order=14)]
        [MaxLength(60)] 
        public String CdFondationEqpFondation { get; set; }
        
        [Description("Maille")]
        [Column("CD_MAILLE_EQP__MAILLE",Order=15)]
        [MaxLength(60)] 
        public String CdMailleEqpMaille { get; set; }
        
        [Description("Entreprise")]
        [Column("CD_ENTP_EQP__ENTREPRISE",Order=16)]
        [MaxLength(60)] 
        public String CdEntpEqpEntreprise { get; set; }
        
        [Description("Nom Fabricant")]
        [Column("CD_FABRICANT_EQP__NOM",Order=17)]
        [MaxLength(60)] 
        public String CdFabricantEqpNom { get; set; }
        
        [Description("Poteaux")]
        [Column("CD_POTEAU_CL_EQP__POTEAUX",Order=18)]
        [MaxLength(60)] 
        public String CdPoteauClEqpPoteaux { get; set; }
        
        [Description("Anti franchissement")]
        [Column("CD_FRANCH_EQP__ANTI_FRANCH",Order=19)]
        [MaxLength(60)] 
        public String CdFranchEqpAntiFranch { get; set; }
        
        [Description("Clôture")]
        [Column("CD_CLOTURE_EQP__CLOTURE",Order=20)]
        [MaxLength(60)] 
        public String CdClotureEqpCloture { get; set; }
        
        [Description("PR fin")]
        [Column("ABS_FIN",Order=21)]
        public Nullable<Int64> AbsFin { get; set; }
        
        [Description("Date MS")]
        [Column("DATE_MS",Order=22)]
        public Nullable<DateTime> DateMs { get; set; }
        
        [Description("Hauteur (m)")]
        [Column("HAUTEUR",Order=23)]
        public Nullable<Double> Hauteur { get; set; }
        
        [Description("Distance poteaux (m)")]
        [Column("DISTANCE",Order=24)]
        public Nullable<Double> Distance { get; set; }
        
        [Description("Commentaire")]
        [Column("COMMENTAIRE",Order=25)]
        [MaxLength(255)] 
        public String Commentaire { get; set; }
        
        [Description("X1")]
        [Column("X1",Order=26)]
        public Nullable<Double> X1 { get; set; }
        
        [Description("Y1")]
        [Column("Y1",Order=27)]
        public Nullable<Double> Y1 { get; set; }
        
        [Description("Z1")]
        [Column("Z1",Order=28)]
        public Nullable<Double> Z1 { get; set; }
        
        [Description("X2")]
        [Column("X2",Order=29)]
        public Nullable<Double> X2 { get; set; }
        
        [Description("Y2")]
        [Column("Y2",Order=30)]
        public Nullable<Double> Y2 { get; set; }
        
        [Description("Z2")]
        [Column("Z2",Order=31)]
        public Nullable<Double> Z2 { get; set; }
        
        [Description("Date relevé")]
        [Column("DATE_RELEVE",Order=32)]
        public Nullable<DateTime> DateReleve { get; set; }
        
        [Description("Terrain")]
        [Column("TERRAIN",Order=33)]
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
