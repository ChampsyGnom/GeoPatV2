using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_POTEAU_CL_EQP",Schema="EQP")]
    public partial class EqpCdPoteauCl : ModelBase
    {
        public virtual ICollection<EqpDscCl> EqpDscCls { get; set; }
        
        [Key]
        [Description("Poteaux")]
        [Column("POTEAUX",Order=0)]
        [Required()]
        [MaxLength(60)] 
        public String Poteaux { get; set; }
        
    }
}
