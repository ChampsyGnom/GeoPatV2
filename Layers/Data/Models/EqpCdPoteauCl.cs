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
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Poteaux")]
        [Column("POTEAUX",Order=1)]
        [Required()]
        [MaxLength(60)] 
        public String Poteaux { get; set; }
        
    }
}
