using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_FREQUENCE_BSN",Schema="BSN")]
    public partial class BsnCdFrequence : ModelBase
    {
        public virtual ICollection<BsnDsc> BsnDscs { get; set; }
        
        public virtual ICollection<BsnDscTemp> BsnDscTemps { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Fréquence")]
        [Column("FREQ",Order=1)]
        [Required()]
        [MaxLength(25)] 
        public String Freq { get; set; }
        
    }
}
