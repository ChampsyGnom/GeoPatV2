using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_FONDATION_EQP",Schema="EQP")]
    public partial class EqpCdFondation
    {
        public virtual ICollection<EqpDscSv> EqpDscSvs { get; set; }
        
        public virtual ICollection<EqpDscCl> EqpDscCls { get; set; }
        
        [Key]
        [Description("Type fondation")]
        [Column("FONDATION",Order=0)]
        [Required()]
        [MaxLength(60)] 
        public String Fondation { get; set; }
        
    }
}
