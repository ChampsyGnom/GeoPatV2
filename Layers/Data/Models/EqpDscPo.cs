using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("DSC_PO_EQP",Schema="EQP")]
    public partial class EqpDscPo : ModelBase
    {
        private EqpCdPortail _eqpCdPortail;
        public virtual EqpCdPortail EqpCdPortail 
        {
            get
            {
                return this._eqpCdPortail;
                
            }
            set
            {
                this._eqpCdPortail = value;
                this.CdPortailEqpPortail = this._eqpCdPortail.Portail;
            }
        }
        
        [Required()]
        [Column("CD_PORTAIL_EQP_ID_PK",Order=0)]
        public Int64 EqpCdPortailIdPk {get;set;}
        
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
        
        [Column("CD_POSIT_EQP_ID_PK",Order=3)]
        public Nullable<Int64> EqpCdPositIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=4)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("N° d'exploitation")]
        [Column("NUM_EXPLOIT",Order=5)]
        [Required()]
        [MaxLength(30)] 
        public String NumExploit { get; set; }
        
        [Description("Entreprise")]
        [Column("CD_ENTP_EQP__ENTREPRISE",Order=6)]
        [MaxLength(60)] 
        public String CdEntpEqpEntreprise { get; set; }
        
        [Description("Portail")]
        [Column("CD_PORTAIL_EQP__PORTAIL",Order=7)]
        [Required()]
        [MaxLength(60)] 
        public String CdPortailEqpPortail { get; set; }
        
        [Description("Nom Fabricant")]
        [Column("CD_FABRICANT_EQP__NOM",Order=8)]
        [MaxLength(60)] 
        public String CdFabricantEqpNom { get; set; }
        
        [Description("Position")]
        [Column("CD_POSIT_EQP__POSIT",Order=9)]
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
        
        [Description("Date MS")]
        [Column("DATE_MS",Order=13)]
        public Nullable<DateTime> DateMs { get; set; }
        
        [Description("Largeur (m)")]
        [Column("LARGEUR",Order=14)]
        public Nullable<Double> Largeur { get; set; }
        
        [Description("Hauteur (m)")]
        [Column("HAUTEUR",Order=15)]
        public Nullable<Double> Hauteur { get; set; }
        
        [Description("Dispositif accès")]
        [Column("DISPO_ACCES",Order=16)]
        public Nullable<int> DispoAccesValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> DispoAcces 
        {
            get
            {
                if (DispoAccesValueInt.HasValue) return Convert.ToBoolean(DispoAccesValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.DispoAccesValueInt = Convert.ToInt32(value.Value);}
                else {this.DispoAccesValueInt =null;}
            }
        }
        
        [Description("Commentaire")]
        [Column("COMMENTAIRE",Order=17)]
        [MaxLength(255)] 
        public String Commentaire { get; set; }
        
        [Description("X1")]
        [Column("X1",Order=18)]
        public Nullable<Double> X1 { get; set; }
        
        [Description("Y1")]
        [Column("Y1",Order=19)]
        public Nullable<Double> Y1 { get; set; }
        
        [Description("Z1")]
        [Column("Z1",Order=20)]
        public Nullable<Double> Z1 { get; set; }
        
        [Description("Date relevé")]
        [Column("DATE_RELEVE",Order=21)]
        public Nullable<DateTime> DateReleve { get; set; }
        
        [Description("Terrain")]
        [Column("TERRAIN",Order=22)]
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
