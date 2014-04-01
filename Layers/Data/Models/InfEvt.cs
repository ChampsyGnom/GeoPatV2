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
        public virtual InfCdEvt InfCdEvt {get;set;}
        
        public virtual InfCdPosit InfCdPosit {get;set;}
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Type événement")]
        [Column("CD_EVT_INF__TYPE",Order=0)]
        [Required()]
        [MaxLength(25)] 
        public String CdEvtInfType { get; set; }
        
        [Description("Identifiant Evénement")]
        [Column("ID_EVT",Order=1)]
        [Required()]
        public Int64 IdEvt { get; set; }
        
        [Description("Position")]
        [Column("CD_POSIT_INF__POSIT",Order=2)]
        [MaxLength(12)] 
        public String CdPositInfPosit { get; set; }
        
        [Description("Nom Table")]
        [Column("NOM_TABLE",Order=3)]
        [Required()]
        [MaxLength(60)] 
        public String NomTable { get; set; }
        
        [Description("Liaison")]
        [Column("LIAISON",Order=4)]
        [Required()]
        [MaxLength(15)] 
        public String Liaison { get; set; }
        
        [Description("Sens")]
        [Column("SENS",Order=5)]
        [Required()]
        [MaxLength(6)] 
        public String Sens { get; set; }
        
        [Description("PR début")]
        [Column("ABS_DEB",Order=6)]
        [Required()]
        public Int64 AbsDeb { get; set; }
        
        [Description("PR fin")]
        [Column("ABS_FIN",Order=7)]
        public Nullable<Int64> AbsFin { get; set; }
        
        [Description("Date Relevé")]
        [Column("DATE_REL",Order=8)]
        [Required()]
        public DateTime DateRel { get; set; }
        
        [Description("Observation")]
        [Column("OBSV",Order=9)]
        [MaxLength(255)] 
        public String Obsv { get; set; }
        
        [Description("Date Traitement")]
        [Column("DATE_TRT",Order=10)]
        public Nullable<DateTime> DateTrt { get; set; }
        
    }
}
