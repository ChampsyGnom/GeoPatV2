using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_PRESTA_GMS",Schema="GMS")]
    public partial class GmsCdPresta
    {
        public virtual ICollection<GmsCamp> GmsCamps { get; set; }
        
        public virtual ICollection<GmsInspecteur> GmsInspecteurs { get; set; }
        
        [Key]
        [Description("Prestataire")]
        [Column("PRESTATAIRE",Order=0)]
        [Required()]
        [MaxLength(50)] 
        public String Prestataire { get; set; }
        
    }
}
