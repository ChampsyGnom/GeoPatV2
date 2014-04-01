using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_OCCUPANT_OA",Schema="OA")]
    public partial class OaCdOccupant
    {
        public virtual ICollection<OaOccupation> OaOccupations { get; set; }
        
        [Key]
        [Description("Nom occupant")]
        [Column("NOM",Order=0)]
        [Required()]
        [MaxLength(60)] 
        public String Nom { get; set; }
        
    }
}
