using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_MOTS_RESERVE",Schema="MAPINFO")]
    public partial class MapinfoCdMotsReserve : ModelBase
    {
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Mot clef")]
        [Column("KEYWORD",Order=1)]
        [Required()]
        [MaxLength(50)] 
        public String Keyword { get; set; }
        
    }
}
