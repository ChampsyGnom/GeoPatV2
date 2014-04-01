using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("TB_MAP_METIER_CFG",Schema="MAPINFO")]
    public partial class MapinfoTbMapMetierCfg : ModelBase
    {
        public virtual MapinfoTbMapMetier MapinfoTbMapMetier {get;set;}
        
        [Key]
        [Description("Tb Map Metier  Schema Name")]
        [Column("TB_MAP_METIER__SCHEMA_NAME",Order=0)]
        [Required()]
        [MaxLength(20)] 
        public String TbMapMetierSchemaName { get; set; }
        
        [Key]
        [Description("Tb Map Metier  Table Name")]
        [Column("TB_MAP_METIER__TABLE_NAME",Order=1)]
        [Required()]
        [MaxLength(50)] 
        public String TbMapMetierTableName { get; set; }
        
        [Key]
        [Description("Tb Map Metier Cfg  Usercode")]
        [Column("USERCODE",Order=2)]
        [Required()]
        [MaxLength(50)] 
        public String Usercode { get; set; }
        
        [Key]
        [Description("Tb Map Metier Cfg  Code Prp")]
        [Column("CODE_PRP",Order=3)]
        [Required()]
        [MaxLength(50)] 
        public String CodePrp { get; set; }
        
        [Description("Tb Map Metier Cfg  Val Prp")]
        [Column("VAL_PRP",Order=4)]
        [Required()]
        [MaxLength(254)] 
        public String ValPrp { get; set; }
        
    }
}
