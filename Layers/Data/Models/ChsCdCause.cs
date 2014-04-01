using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_CAUSE_CHS",Schema="CHS")]
    public partial class ChsCdCause : ModelBase
    {
        public virtual ICollection<ChsPave> ChsPaves { get; set; }
        
        [Key]
        [Description("Cause")]
        [Column("CAUSE",Order=0)]
        [Required()]
        [MaxLength(60)] 
        public String Cause { get; set; }
        
    }
}
