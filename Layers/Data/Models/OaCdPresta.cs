using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_PRESTA_OA",Schema="OA")]
    public partial class OaCdPresta
    {
        public virtual ICollection<OaCamp> OaCamps { get; set; }
        
        public virtual ICollection<OaInspecteur> OaInspecteurs { get; set; }
        
        [Key]
        [Description("Prestataire")]
        [Column("PRESTATAIRE",Order=0)]
        [Required()]
        [MaxLength(50)] 
        public String Prestataire { get; set; }
        
    }
}
