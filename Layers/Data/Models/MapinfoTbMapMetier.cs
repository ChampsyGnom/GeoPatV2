using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("TB_MAP_METIER",Schema="MAPINFO")]
    public partial class MapinfoTbMapMetier : ModelBase
    {
        public virtual ICollection<MapinfoTbMapMetierCfg> MapinfoTbMapMetierCfgs { get; set; }
        
        public virtual ICollection<MapinfoTbMapMetierColumns> MapinfoTbMapMetierColumnss { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Tb Map Metier  Schema Name")]
        [Column("SCHEMA_NAME",Order=1)]
        [Required()]
        [MaxLength(20)] 
        public String SchemaName { get; set; }
        
        [Description("Tb Map Metier  Table Name")]
        [Column("TABLE_NAME",Order=2)]
        [Required()]
        [MaxLength(50)] 
        public String TableName { get; set; }
        
        [Description("Tb Map Metier  Title")]
        [Column("TITLE",Order=3)]
        [MaxLength(50)] 
        public String Title { get; set; }
        
        [Description("Tb Map Metier  Map Order")]
        [Column("MAP_ORDER",Order=4)]
        public Nullable<Int64> MapOrder { get; set; }
        
        [Description("Tb Map Metier  Rang")]
        [Column("RANG",Order=5)]
        public Nullable<Int64> Rang { get; set; }
        
        [Description("Tb Map Metier  ObjType")]
        [Column("OBJTYPE",Order=6)]
        public Nullable<Int64> Objtype { get; set; }
        
    }
}
