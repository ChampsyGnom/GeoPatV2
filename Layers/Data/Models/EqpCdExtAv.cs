using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_EXT_AV_EQP",Schema="EQP")]
    public partial class EqpCdExtAv : ModelBase
    {
        public virtual ICollection<EqpDscEs> EqpDscEss { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Extrémité fin")]
        [Column("EXT_FIN",Order=1)]
        [Required()]
        [MaxLength(60)] 
        public String ExtFin { get; set; }
        
    }
}
