using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_PLACE_INF",Schema="INF")]
    public partial class InfCdPlace : ModelBase
    {
        public virtual ICollection<InfAirePlace> InfAirePlaces { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Type Parking")]
        [Column("PARKING",Order=1)]
        [Required()]
        [MaxLength(60)] 
        public String Parking { get; set; }
        
    }
}
