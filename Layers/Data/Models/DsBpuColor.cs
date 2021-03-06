using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("BPU_COLOR_DS",Schema="DS")]
    public partial class DsBpuColor : ModelBase
    {
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("BPU_COLOR_DS__CODE")]
        [Column("CODE",Order=1)]
        [Required()]
        [MaxLength(30)] 
        public String Code { get; set; }
        
        [Description("BPU_COLOR_DS__COLOR")]
        [Column("COLOR",Order=2)]
        [MaxLength(11)] 
        public String Color { get; set; }
        
    }
}
