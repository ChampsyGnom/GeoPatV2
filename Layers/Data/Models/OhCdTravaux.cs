using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_TRAVAUX_OH",Schema="OH")]
    public partial class OhCdTravaux : ModelBase
    {
        public virtual ICollection<OhNatureTrav> OhNatureTravs { get; set; }
        
        public virtual ICollection<OhBpu> OhBpus { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Type travaux")]
        [Column("CODE",Order=1)]
        [Required()]
        [MaxLength(60)] 
        public String Code { get; set; }
        
    }
}
