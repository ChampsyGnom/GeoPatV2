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
        private MapinfoTbMapMetier _mapinfoTbMapMetier;
        public virtual MapinfoTbMapMetier MapinfoTbMapMetier 
        {
            get
            {
                return this._mapinfoTbMapMetier;
                
            }
            set
            {
                this._mapinfoTbMapMetier = value;
                this.TbMapMetierSchemaName = this._mapinfoTbMapMetier.SchemaName;
                this.TbMapMetierTableName = this._mapinfoTbMapMetier.TableName;
            }
        }
        
        [Required()]
        [Column("TB_MAP_METIER_ID_PK",Order=0)]
        public Int64 MapinfoTbMapMetierIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Tb Map Metier  Schema Name")]
        [Column("TB_MAP_METIER__SCHEMA_NAME",Order=2)]
        [Required()]
        [MaxLength(20)] 
        public String TbMapMetierSchemaName { get; set; }
        
        [Description("Tb Map Metier  Table Name")]
        [Column("TB_MAP_METIER__TABLE_NAME",Order=3)]
        [Required()]
        [MaxLength(50)] 
        public String TbMapMetierTableName { get; set; }
        
        [Description("Tb Map Metier Cfg  Usercode")]
        [Column("USERCODE",Order=4)]
        [Required()]
        [MaxLength(50)] 
        public String Usercode { get; set; }
        
        [Description("Tb Map Metier Cfg  Code Prp")]
        [Column("CODE_PRP",Order=5)]
        [Required()]
        [MaxLength(50)] 
        public String CodePrp { get; set; }
        
        [Description("Tb Map Metier Cfg  Val Prp")]
        [Column("VAL_PRP",Order=6)]
        [Required()]
        [MaxLength(254)] 
        public String ValPrp { get; set; }
        
    }
}
