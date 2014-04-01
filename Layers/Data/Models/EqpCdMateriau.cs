using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_MATERIAU_EQP",Schema="EQP")]
    public partial class EqpCdMateriau
    {
        public virtual ICollection<EqpCdRetenue> EqpCdRetenues { get; set; }
        
        [Key]
        [Description("Matériaux")]
        [Column("MATERIAUX",Order=0)]
        [Required()]
        [MaxLength(60)] 
        public String Materiaux { get; set; }
        
    }
}
