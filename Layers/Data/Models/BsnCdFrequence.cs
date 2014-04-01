using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_FREQUENCE_BSN",Schema="BSN")]
    public partial class BsnCdFrequence
    {
        public virtual ICollection<BsnDsc> BsnDscs { get; set; }
        
        public virtual ICollection<BsnDscTemp> BsnDscTemps { get; set; }
        
        [Key]
        [Description("Fréquence")]
        [Column("FREQ",Order=0)]
        [Required()]
        [MaxLength(25)] 
        public String Freq { get; set; }
        
    }
}
