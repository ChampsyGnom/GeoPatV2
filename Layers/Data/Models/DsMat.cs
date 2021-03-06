using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("MAT_DS",Schema="DS")]
    public partial class DsMat : ModelBase
    {
        public virtual ICollection<DsMatParam> DsMatParams { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("MAT_DS__CODE")]
        [Column("CODE",Order=1)]
        [Required()]
        [MaxLength(15)] 
        public String Code { get; set; }
        
        [Description("MAT_DS__LIBELLE")]
        [Column("LIBELLE",Order=2)]
        [Required()]
        [MaxLength(200)] 
        public String Libelle { get; set; }
        
        [Description("MAT_DS__AGR_X")]
        [Column("AGR_X",Order=3)]
        [MaxLength(15)] 
        public String AgrX { get; set; }
        
        [Description("MAT_DS__INDIC_X")]
        [Column("INDIC_X",Order=4)]
        [MaxLength(15)] 
        public String IndicX { get; set; }
        
        [Description("MAT_DS__AGR_Y")]
        [Column("AGR_Y",Order=5)]
        [MaxLength(15)] 
        public String AgrY { get; set; }
        
        [Description("MAT_DS__INDIC_Y")]
        [Column("INDIC_Y",Order=6)]
        [MaxLength(15)] 
        public String IndicY { get; set; }
        
    }
}
