using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_PRESTA_GMS",Schema="GMS")]
    public partial class GmsCdPresta : ModelBase
    {
        public virtual ICollection<GmsCamp> GmsCamps { get; set; }
        
        public virtual ICollection<GmsInspecteur> GmsInspecteurs { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Prestataire")]
        [Column("PRESTATAIRE",Order=1)]
        [Required()]
        [MaxLength(50)] 
        public String Prestataire { get; set; }
        
    }
}
