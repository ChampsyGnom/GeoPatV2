using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_METEO_GOT",Schema="GOT")]
    public partial class GotCdMeteo : ModelBase
    {
        public virtual ICollection<GotInsp> GotInsps { get; set; }
        
        public virtual ICollection<GotInspTmp> GotInspTmps { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Condition météo")]
        [Column("METEO",Order=1)]
        [Required()]
        [MaxLength(60)] 
        public String Meteo { get; set; }
        
    }
}
