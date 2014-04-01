using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("SI_MODEL",Schema="MAPINFO")]
    public partial class MapinfoSiModel
    {
        public virtual ICollection<MapinfoSiZone> MapinfoSiZones { get; set; }
        
        [Key]
        [Description("Si Model  Nom Model")]
        [Column("NOM_MODEL",Order=0)]
        [Required()]
        [MaxLength(100)] 
        public String NomModel { get; set; }
        
    }
}
