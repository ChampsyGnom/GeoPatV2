using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_METEO_GMS",Schema="GMS")]
    public partial class GmsCdMeteo : ModelBase
    {
        public virtual ICollection<GmsInsp> GmsInsps { get; set; }
        
        public virtual ICollection<GmsInspTmp> GmsInspTmps { get; set; }
        
        [Key]
        [Description("Condition météo")]
        [Column("METEO",Order=0)]
        [Required()]
        [MaxLength(60)] 
        public String Meteo { get; set; }
        
    }
}
