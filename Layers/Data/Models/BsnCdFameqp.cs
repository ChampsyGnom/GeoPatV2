using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_FAMEQP_BSN",Schema="BSN")]
    public partial class BsnCdFameqp : ModelBase
    {
        public virtual ICollection<BsnCdTypeqp> BsnCdTypeqps { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Famille EQP")]
        [Column("FAM",Order=1)]
        [Required()]
        [MaxLength(25)] 
        public String Fam { get; set; }
        
    }
}
