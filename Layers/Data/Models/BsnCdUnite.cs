using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_UNITE_BSN",Schema="BSN")]
    public partial class BsnCdUnite : ModelBase
    {
        public virtual ICollection<BsnBpu> BsnBpus { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Unité")]
        [Column("UNITE",Order=1)]
        [Required()]
        [MaxLength(12)] 
        public String Unite { get; set; }
        
    }
}
