using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PREVISION_EQP",Schema="EQP")]
    public partial class EqpPrevision : ModelBase
    {
        private EqpBpu _eqpBpu;
        public virtual EqpBpu EqpBpu 
        {
            get
            {
                return this._eqpBpu;
                
            }
            set
            {
                this._eqpBpu = value;
                this.BpuEqpTechn = this._eqpBpu.Techn;
            }
        }
        
        [Required()]
        [Column("BPU_EQP_ID_PK",Order=0)]
        public Int64 EqpBpuIdPk {get;set;}
        
        private EqpCdType _eqpCdType;
        public virtual EqpCdType EqpCdType 
        {
            get
            {
                return this._eqpCdType;
                
            }
            set
            {
                this._eqpCdType = value;
                this.CdTypeEqpTypeEquip = this._eqpCdType.TypeEquip;
            }
        }
        
        [Required()]
        [Column("CD_TYPE_EQP_ID_PK",Order=1)]
        public Int64 EqpCdTypeIdPk {get;set;}
        
        private EqpCdContrainte _eqpCdContrainte;
        public virtual EqpCdContrainte EqpCdContrainte 
        {
            get
            {
                return this._eqpCdContrainte;
                
            }
            set
            {
                this._eqpCdContrainte = value;
                this.CdContrainteEqpType = this._eqpCdContrainte.Type;
            }
        }
        
        [Column("CD_CONTRAINTE_EQP_ID_PK",Order=2)]
        public Nullable<Int64> EqpCdContrainteIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=3)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Technique")]
        [Column("BPU_EQP__TECHN",Order=4)]
        [Required()]
        [MaxLength(250)] 
        public String BpuEqpTechn { get; set; }
        
        [Description("Type d'équipement")]
        [Column("CD_TYPE_EQP__TYPE_EQUIP",Order=5)]
        [Required()]
        [MaxLength(6)] 
        public String CdTypeEqpTypeEquip { get; set; }
        
        [Description("Identifiant Prévisions")]
        [Column("ID_PREV",Order=6)]
        [Required()]
        public Int64 IdPrev { get; set; }
        
        [Description("Contrainte exploit")]
        [Column("CD_CONTRAINTE_EQP__TYPE",Order=7)]
        [MaxLength(100)] 
        public String CdContrainteEqpType { get; set; }
        
        [Description("N° Ouvrage")]
        [Column("OUVRAGE",Order=8)]
        [MaxLength(30)] 
        public String Ouvrage { get; set; }
        
        [Description("Liaison")]
        [Column("LIAISON",Order=9)]
        [MaxLength(15)] 
        public String Liaison { get; set; }
        
        [Description("Sens")]
        [Column("SENS",Order=10)]
        [MaxLength(6)] 
        public String Sens { get; set; }
        
        [Description("Position")]
        [Column("POSITION",Order=11)]
        [MaxLength(60)] 
        public String Position { get; set; }
        
        [Description("du PR")]
        [Column("ABS_DEB",Order=12)]
        public Nullable<Int64> AbsDeb { get; set; }
        
        [Description("au PR")]
        [Column("ABS_FIN",Order=13)]
        public Nullable<Int64> AbsFin { get; set; }
        
        [Description("Date début")]
        [Column("DATE_DEBUT",Order=14)]
        [Required()]
        public DateTime DateDebut { get; set; }
        
        [Description("Coûts (€)")]
        [Column("MONTANT",Order=15)]
        public Nullable<Int64> Montant { get; set; }
        
        [Description("Date fin")]
        [Column("DATE_FIN",Order=16)]
        public Nullable<DateTime> DateFin { get; set; }
        
        [Description("Commentaire")]
        [Column("COMMENTAIRE",Order=17)]
        [MaxLength(255)] 
        public String Commentaire { get; set; }
        
        [Description("Réalisé")]
        [Column("REALISE",Order=18)]
        public Nullable<int> RealiseValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> Realise 
        {
            get
            {
                if (RealiseValueInt.HasValue) return Convert.ToBoolean(RealiseValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.RealiseValueInt = Convert.ToInt32(value.Value);}
                else {this.RealiseValueInt =null;}
            }
        }
        
    }
}
