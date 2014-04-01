using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_PRESTA_GOT",Schema="GOT")]
    public partial class GotCdPresta : ModelBase
    {
        public virtual ICollection<GotCamp> GotCamps { get; set; }
        
        public virtual ICollection<GotInspecteur> GotInspecteurs { get; set; }
        
        [Key]
        [Description("Prestataire")]
        [Column("PRESTATAIRE",Order=0)]
        [Required()]
        [MaxLength(50)] 
        public String Prestataire { get; set; }
        
    }
}
