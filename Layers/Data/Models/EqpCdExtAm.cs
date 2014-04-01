using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_EXT_AM_EQP",Schema="EQP")]
    public partial class EqpCdExtAm : ModelBase
    {
        public virtual ICollection<EqpDscEs> EqpDscEss { get; set; }
        
        [Key]
        [Description("Extrémité début")]
        [Column("EXT_DEB",Order=0)]
        [Required()]
        [MaxLength(60)] 
        public String ExtDeb { get; set; }
        
    }
}
