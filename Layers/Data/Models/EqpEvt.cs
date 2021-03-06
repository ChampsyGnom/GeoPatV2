using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("EVT_EQP",Schema="EQP")]
    public partial class EqpEvt : ModelBase
    {
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
        [Column("CD_TYPE_EQP_ID_PK",Order=0)]
        public Int64 EqpCdTypeIdPk {get;set;}
        
        private EqpCdEvt _eqpCdEvt;
        public virtual EqpCdEvt EqpCdEvt 
        {
            get
            {
                return this._eqpCdEvt;
                
            }
            set
            {
                this._eqpCdEvt = value;
                this.CdEvtEqpType = this._eqpCdEvt.Type;
            }
        }
        
        [Required()]
        [Column("CD_EVT_EQP_ID_PK",Order=1)]
        public Int64 EqpCdEvtIdPk {get;set;}
        
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
        
        [Column("CD_POSIT_EQP_ID_PK",Order=2)]
        public Nullable<Int64> EqpCdPositIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=3)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Type d'équipement")]
        [Column("CD_TYPE_EQP__TYPE_EQUIP",Order=4)]
        [Required()]
        [MaxLength(6)] 
        public String CdTypeEqpTypeEquip { get; set; }
        
        [Description("Type événement")]
        [Column("CD_EVT_EQP__TYPE",Order=5)]
        [Required()]
        [MaxLength(25)] 
        public String CdEvtEqpType { get; set; }
        
        [Description("Identifiant Evénement")]
        [Column("ID_EVT",Order=6)]
        [Required()]
        public Int64 IdEvt { get; set; }
        
        [Description("Position")]
        [Column("CD_POSIT_EQP__POSIT",Order=7)]
        [MaxLength(60)] 
        public String CdPositEqpPosit { get; set; }
        
        [Description("N° Exploitation")]
        [Column("OUVRAGE",Order=8)]
        [MaxLength(30)] 
        public String Ouvrage { get; set; }
        
        [Description("Liaison")]
        [Column("LIAISON",Order=9)]
        [Required()]
        [MaxLength(15)] 
        public String Liaison { get; set; }
        
        [Description("Sens")]
        [Column("SENS",Order=10)]
        [Required()]
        [MaxLength(6)] 
        public String Sens { get; set; }
        
        [Description("PR début")]
        [Column("ABS_DEB",Order=11)]
        [Required()]
        public Int64 AbsDeb { get; set; }
        
        [Description("PR fin")]
        [Column("ABS_FIN",Order=12)]
        [Required()]
        public Int64 AbsFin { get; set; }
        
        [Description("Date Relevé")]
        [Column("DATE_REL",Order=13)]
        [Required()]
        public DateTime DateRel { get; set; }
        
        [Description("Observation")]
        [Column("OBSV",Order=14)]
        [MaxLength(255)] 
        public String Obsv { get; set; }
        
        [Description("Date Traitement")]
        [Column("DATE_TRT",Order=15)]
        public Nullable<DateTime> DateTrt { get; set; }
        
    }
}
