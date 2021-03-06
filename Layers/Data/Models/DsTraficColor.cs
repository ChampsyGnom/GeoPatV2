using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("TRAFIC_COLOR_DS",Schema="DS")]
    public partial class DsTraficColor : ModelBase
    {
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("TRAFIC_COLOR_DS__CODE")]
        [Column("CODE",Order=1)]
        [Required()]
        [MaxLength(10)] 
        public String Code { get; set; }
        
        [Description("TRAFIC_COLOR_DS__COLOR")]
        [Column("COLOR",Order=2)]
        [MaxLength(11)] 
        public String Color { get; set; }
        
    }
}
