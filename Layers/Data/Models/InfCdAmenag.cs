using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_AMENAG_INF",Schema="INF")]
    public partial class InfCdAmenag : ModelBase
    {
        public virtual ICollection<InfAmenagement> InfAmenagements { get; set; }
        
        [Key]
        [Description("Aménagement")]
        [Column("TYPE_AMENAG",Order=0)]
        [Required()]
        [MaxLength(60)] 
        public String TypeAmenag { get; set; }
        
    }
}
