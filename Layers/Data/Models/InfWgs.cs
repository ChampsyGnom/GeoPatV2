using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("WGS_INF",Schema="INF")]
    public partial class InfWgs : ModelBase
    {
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Index ligne")]
        [Column("LINE_INDEX",Order=1)]
        [Required()]
        public Int64 LineIndex { get; set; }
        
        [Description("Modèle")]
        [Column("LAYER_NAME",Order=2)]
        [Required()]
        [MaxLength(100)] 
        public String LayerName { get; set; }
        
        [Description("Liaison")]
        [Column("LIAISON",Order=3)]
        [Required()]
        [MaxLength(16)] 
        public String Liaison { get; set; }
        
        [Description("Sens")]
        [Column("SENS",Order=4)]
        [Required()]
        [MaxLength(6)] 
        public String Sens { get; set; }
        
        [Description("Début")]
        [Column("ABS_DEB",Order=5)]
        [Required()]
        public Int64 AbsDeb { get; set; }
        
        [Description("Fin")]
        [Column("ABS_FIN",Order=6)]
        [Required()]
        public Int64 AbsFin { get; set; }
        
        [Description("X1")]
        [Column("X1",Order=7)]
        [Required()]
        public Double X1 { get; set; }
        
        [Description("Y1")]
        [Column("Y1",Order=8)]
        [Required()]
        public Double Y1 { get; set; }
        
        [Description("X2")]
        [Column("X2",Order=9)]
        [Required()]
        public Double X2 { get; set; }
        
        [Description("Y2")]
        [Column("Y2",Order=10)]
        [Required()]
        public Double Y2 { get; set; }
        
    }
}
