using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_GAMME_SV_EQP",Schema="EQP")]
    public partial class EqpCdGammeSv : ModelBase
    {
        public virtual ICollection<EqpPanneau> EqpPanneaus { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Gamme")]
        [Column("GAMME",Order=1)]
        [Required()]
        [MaxLength(20)] 
        public String Gamme { get; set; }
        
        [Description("Dimension (mm)")]
        [Column("DIMENSION",Order=2)]
        public Nullable<Int64> Dimension { get; set; }
        
    }
}
