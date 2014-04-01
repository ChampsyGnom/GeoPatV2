using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_PROTECT_EQP",Schema="EQP")]
    public partial class EqpCdProtect
    {
        public virtual ICollection<EqpDscSv> EqpDscSvs { get; set; }
        
        [Key]
        [Description("Protection")]
        [Column("PROTECT",Order=0)]
        [Required()]
        [MaxLength(60)] 
        public String Protect { get; set; }
        
    }
}
