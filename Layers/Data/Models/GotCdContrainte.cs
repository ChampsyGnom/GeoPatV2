using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_CONTRAINTE_GOT",Schema="GOT")]
    public partial class GotCdContrainte : ModelBase
    {
        public virtual ICollection<GotPrevision> GotPrevisions { get; set; }
        
        [Key]
        [Description("Contrainte exploit")]
        [Column("TYPE",Order=0)]
        [Required()]
        [MaxLength(100)] 
        public String Type { get; set; }
        
    }
}
