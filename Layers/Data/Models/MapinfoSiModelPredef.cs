using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("SI_MODEL_PREDEF",Schema="MAPINFO")]
    public partial class MapinfoSiModelPredef : ModelBase
    {
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Si Model Predef  NomTable")]
        [Column("NOMTABLE",Order=1)]
        [Required()]
        [MaxLength(100)] 
        public String Nomtable { get; set; }
        
        [Description("Si Model Predef  NomSchema")]
        [Column("NOMSCHEMA",Order=2)]
        [Required()]
        [MaxLength(100)] 
        public String Nomschema { get; set; }
        
        [Description("Si Model Predef  NomModel")]
        [Column("NOM_MODEL",Order=3)]
        [Required()]
        [MaxLength(100)] 
        public String NomModel { get; set; }
        
    }
}
