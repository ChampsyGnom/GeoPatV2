using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("EVT_INF",Schema="INF")]
    public partial class InfEvt : ModelBase
    {
        private InfCdEvt _infCdEvt;
        public virtual InfCdEvt InfCdEvt 
        {
            get
            {
                return this._infCdEvt;
                
            }
            set
            {
                this._infCdEvt = value;
                this.CdEvtInfType = this._infCdEvt.Type;
            }
        }
        
        [Required()]
        [Column("CD_EVT_INF_ID_PK",Order=0)]
        public Int64 InfCdEvtIdPk {get;set;}
        
        private InfCdPosit _infCdPosit;
        public virtual InfCdPosit InfCdPosit 
        {
            get
            {
                return this._infCdPosit;
                
            }
            set
            {
                this._infCdPosit = value;
                this.CdPositInfPosit = this._infCdPosit.Posit;
            }
        }
        
        [Column("CD_POSIT_INF_ID_PK",Order=1)]
        public Nullable<Int64> InfCdPositIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Type événement")]
        [Column("CD_EVT_INF__TYPE",Order=3)]
        [Required()]
        [MaxLength(25)] 
        public String CdEvtInfType { get; set; }
        
        [Description("Identifiant Evénement")]
        [Column("ID_EVT",Order=4)]
        [Required()]
        public Int64 IdEvt { get; set; }
        
        [Description("Position")]
        [Column("CD_POSIT_INF__POSIT",Order=5)]
        [MaxLength(12)] 
        public String CdPositInfPosit { get; set; }
        
        [Description("Nom Table")]
        [Column("NOM_TABLE",Order=6)]
        [Required()]
        [MaxLength(60)] 
        public String NomTable { get; set; }
        
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
        
        [Description("PR début")]
        [Column("ABS_DEB",Order=9)]
        [Required()]
        public Int64 AbsDeb { get; set; }
        
        [Description("PR fin")]
        [Column("ABS_FIN",Order=10)]
        public Nullable<Int64> AbsFin { get; set; }
        
        [Description("Date Relevé")]
        [Column("DATE_REL",Order=11)]
        [Required()]
        public DateTime DateRel { get; set; }
        
        [Description("Observation")]
        [Column("OBSV",Order=12)]
        [MaxLength(255)] 
        public String Obsv { get; set; }
        
        [Description("Date Traitement")]
        [Column("DATE_TRT",Order=13)]
        public Nullable<DateTime> DateTrt { get; set; }
        
    }
}
