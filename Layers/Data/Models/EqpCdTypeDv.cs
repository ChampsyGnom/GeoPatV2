using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_TYPE_DV_EQP",Schema="EQP")]
    public partial class EqpCdTypeDv : ModelBase
    {
        public virtual ICollection<EqpDscDv> EqpDscDvs { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Type")]
        [Column("CODE",Order=1)]
        [Required()]
        [MaxLength(15)] 
        public String Code { get; set; }
        
        [Description("Libellé")]
        [Column("LIBELLE",Order=2)]
        [Required()]
        [MaxLength(255)] 
        public String Libelle { get; set; }
        
    }
}
