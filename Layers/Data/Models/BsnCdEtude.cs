using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_ETUDE_BSN",Schema="BSN")]
    public partial class BsnCdEtude
    {
        public virtual ICollection<BsnInsp> BsnInsps { get; set; }
        
        public virtual ICollection<BsnInspTmp> BsnInspTmps { get; set; }
        
        [Key]
        [Description("Etude-Expertise")]
        [Column("ETUDE",Order=0)]
        [Required()]
        [MaxLength(65)] 
        public String Etude { get; set; }
        
    }
}
