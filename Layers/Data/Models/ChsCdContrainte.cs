using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_CONTRAINTE_CHS",Schema="CHS")]
    public partial class ChsCdContrainte
    {
        public virtual ICollection<ChsPrevision> ChsPrevisions { get; set; }
        
        [Key]
        [Description("Contrainte")]
        [Column("TYPE",Order=0)]
        [Required()]
        [MaxLength(100)] 
        public String Type { get; set; }
        
    }
}
