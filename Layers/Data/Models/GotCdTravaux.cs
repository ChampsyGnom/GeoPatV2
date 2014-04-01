using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_TRAVAUX_GOT",Schema="GOT")]
    public partial class GotCdTravaux
    {
        public virtual ICollection<GotNatureTrav> GotNatureTravs { get; set; }
        
        public virtual ICollection<GotBpu> GotBpus { get; set; }
        
        [Key]
        [Description("Type Travaux")]
        [Column("CODE",Order=0)]
        [Required()]
        [MaxLength(60)] 
        public String Code { get; set; }
        
    }
}
