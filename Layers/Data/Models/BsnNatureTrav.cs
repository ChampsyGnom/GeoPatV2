using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("NATURE_TRAV_BSN",Schema="BSN")]
    public partial class BsnNatureTrav
    {
        public virtual BsnCdTravaux BsnCdTravaux {get;set;}
        
        public virtual ICollection<BsnTravaux> BsnTravauxs { get; set; }
        
        [Key]
        [Description("Type travaux")]
        [Column("CD_TRAVAUX_BSN__CODE",Order=0)]
        [Required()]
        [MaxLength(60)] 
        public String CdTravauxBsnCode { get; set; }
        
        [Key]
        [Description("Nature travaux")]
        [Column("NATURE",Order=1)]
        [Required()]
        [MaxLength(100)] 
        public String Nature { get; set; }
        
    }
}
