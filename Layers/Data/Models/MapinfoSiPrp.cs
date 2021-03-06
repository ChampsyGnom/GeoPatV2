using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("SI_PRP",Schema="MAPINFO")]
    public partial class MapinfoSiPrp : ModelBase
    {
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Si Prp  Code Prp")]
        [Column("CODE_PRP",Order=1)]
        [Required()]
        [MaxLength(50)] 
        public String CodePrp { get; set; }
        
        [Description("Si Prp  Val Prp")]
        [Column("VAL_PRP",Order=2)]
        [Required()]
        [MaxLength(1024)] 
        public String ValPrp { get; set; }
        
    }
}
