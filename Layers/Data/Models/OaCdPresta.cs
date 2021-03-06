using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_PRESTA_OA",Schema="OA")]
    public partial class OaCdPresta : ModelBase
    {
        public virtual ICollection<OaCamp> OaCamps { get; set; }
        
        public virtual ICollection<OaInspecteur> OaInspecteurs { get; set; }
        
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
