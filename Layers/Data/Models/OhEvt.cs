using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("EVT_OH",Schema="OH")]
    public partial class OhEvt : ModelBase
    {
        public virtual OhCdEvt OhCdEvt {get;set;}
        
        public virtual OhDsc OhDsc {get;set;}
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Type événement")]
        [Column("CD_EVT_OH__TYPE",Order=0)]
        [Required()]
        [MaxLength(25)] 
        public String CdEvtOhType { get; set; }
        
        [Description("NumOH")]
        [Column("DSC_OH__NUM_OH",Order=1)]
        [Required()]
        [MaxLength(20)] 
        public String DscOhNumOh { get; set; }
        
        [Description("Date Relevé")]
        [Column("DATE_REL",Order=2)]
        [Required()]
        public DateTime DateRel { get; set; }
        
        [Description("Date Traitement")]
        [Column("DATE_TRT",Order=3)]
        public Nullable<DateTime> DateTrt { get; set; }
        
        [Description("Observation")]
        [Column("OBSV",Order=4)]
        [MaxLength(255)] 
        public String Obsv { get; set; }
        
    }
}
