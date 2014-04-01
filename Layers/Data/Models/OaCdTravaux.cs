using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_TRAVAUX_OA",Schema="OA")]
    public partial class OaCdTravaux : ModelBase
    {
        public virtual ICollection<OaBpu> OaBpus { get; set; }
        
        public virtual ICollection<OaNatureTrav> OaNatureTravs { get; set; }
        
        [Key]
        [Description("Type Travaux")]
        [Column("CODE",Order=0)]
        [Required()]
        [MaxLength(60)] 
        public String Code { get; set; }
        
    }
}
