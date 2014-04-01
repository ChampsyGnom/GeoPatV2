using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("EVT_CHS",Schema="CHS")]
    public partial class ChsEvt : ModelBase
    {
        public virtual ChsCdEvt ChsCdEvt {get;set;}
        
        public virtual ChsCdPosit ChsCdPosit {get;set;}
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Type événement")]
        [Column("CD_EVT_CHS__TYPE",Order=0)]
        [Required()]
        [MaxLength(25)] 
        public String CdEvtChsType { get; set; }
        
        [Description("Identifiant Evénement")]
        [Column("ID_EVT",Order=1)]
        [Required()]
        public Int64 IdEvt { get; set; }
        
        [Description("Position")]
        [Column("CD_POSIT_CHS__POSIT",Order=2)]
        [MaxLength(60)] 
        public String CdPositChsPosit { get; set; }
        
        [Description("Liaison")]
        [Column("LIAISON",Order=3)]
        [Required()]
        [MaxLength(15)] 
        public String Liaison { get; set; }
        
        [Description("Sens")]
        [Column("SENS",Order=4)]
        [Required()]
        [MaxLength(6)] 
        public String Sens { get; set; }
        
        [Description("PR début")]
        [Column("ABS_DEB",Order=5)]
        [Required()]
        public Int64 AbsDeb { get; set; }
        
        [Description("PR fin")]
        [Column("ABS_FIN",Order=6)]
        [Required()]
        public Int64 AbsFin { get; set; }
        
        [Description("Date Relevé")]
        [Column("DATE_REL",Order=7)]
        [Required()]
        public DateTime DateRel { get; set; }
        
        [Description("Visite annuelle")]
        [Column("VSTA",Order=8)]
        public Nullable<int> VstaValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> Vsta 
        {
            get
            {
                if (VstaValueInt.HasValue) return Convert.ToBoolean(VstaValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.VstaValueInt = Convert.ToInt32(value.Value);}
                else {this.VstaValueInt =null;}
            }
        }
        
        [Description("Observation")]
        [Column("OBSV",Order=9)]
        [MaxLength(255)] 
        public String Obsv { get; set; }
        
        [Description("Date Traitement")]
        [Column("DATE_TRT",Order=10)]
        public Nullable<DateTime> DateTrt { get; set; }
        
    }
}
