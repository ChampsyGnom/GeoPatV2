using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_QUALITE_BSN",Schema="BSN")]
    public partial class BsnCdQualite : ModelBase
    {
        public virtual ICollection<BsnSeuilQualite> BsnSeuilQualites { get; set; }
        
        public virtual ICollection<BsnDsc> BsnDscs { get; set; }
        
        [Key]
        [Description("Niveau qualité")]
        [Column("QUALITE",Order=0)]
        [Required()]
        [MaxLength(25)] 
        public String Qualite { get; set; }
        
    }
}
