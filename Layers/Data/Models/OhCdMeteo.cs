using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_METEO_OH",Schema="OH")]
    public partial class OhCdMeteo : ModelBase
    {
        public virtual ICollection<OhInsp> OhInsps { get; set; }
        
        public virtual ICollection<OhInspTmp> OhInspTmps { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Météo")]
        [Column("METEO",Order=1)]
        [Required()]
        [MaxLength(60)] 
        public String Meteo { get; set; }
        
    }
}
