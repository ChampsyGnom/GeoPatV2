using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_PRESTA_BSN",Schema="BSN")]
    public partial class BsnCdPresta : ModelBase
    {
        public virtual ICollection<BsnCamp> BsnCamps { get; set; }
        
        public virtual ICollection<BsnInspecteur> BsnInspecteurs { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Prestataire")]
        [Column("PRESTATAIRE",Order=1)]
        [Required()]
        [MaxLength(50)] 
        public String Prestataire { get; set; }
        
    }
}
