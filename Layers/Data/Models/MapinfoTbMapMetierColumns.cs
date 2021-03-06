using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("TB_MAP_METIER_COLUMNS",Schema="MAPINFO")]
    public partial class MapinfoTbMapMetierColumns : ModelBase
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
        
        [Description("Tb Map Metier Columns  Col Name")]
        [Column("COL_NAME",Order=4)]
        [Required()]
        [MaxLength(100)] 
        public String ColName { get; set; }
        
        [Description("Tb Map Metier Columns  Col Libelle")]
        [Column("COL_LIBELLE",Order=5)]
        [Required()]
        [MaxLength(50)] 
        public String ColLibelle { get; set; }
        
        [Description("Tb Map Metier Columns  Col Order")]
        [Column("COL_ORDER",Order=6)]
        public Nullable<Int64> ColOrder { get; set; }
        
        [Description("Tb Map Metier Columns  Col Visible")]
        [Column("COL_VISIBLE",Order=7)]
        public Nullable<Int64> ColVisible { get; set; }
        
    }
}
