using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("SYS_USER_INF",Schema="INF")]
    public partial class InfSysUser : ModelBase
    {
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("SYS_USER_INF__CODE_DBS")]
        [Column("CODE_DBS",Order=1)]
        [Required()]
        [MaxLength(50)] 
        public String CodeDbs { get; set; }
        
        [Description("SYS_USER_INF__CODE_TABLE")]
        [Column("CODE_TABLE",Order=2)]
        [Required()]
        [MaxLength(100)] 
        public String CodeTable { get; set; }
        
        [Description("SYS_USER_INF__CODE_COLONNE")]
        [Column("CODE_COLONNE",Order=3)]
        [Required()]
        [MaxLength(100)] 
        public String CodeColonne { get; set; }
        
        [Description("SYS_USER_INF__NOM_USER")]
        [Column("NOM_USER",Order=4)]
        [Required()]
        [MaxLength(150)] 
        public String NomUser { get; set; }
        
        [Description("SYS_USER_INF__CODE_PRP")]
        [Column("CODE_PRP",Order=5)]
        [Required()]
        [MaxLength(255)] 
        public String CodePrp { get; set; }
        
        [Description("SYS_USER_INF__VAL_PRP")]
        [Column("VAL_PRP",Order=6)]
        [Required()]
        [MaxLength(500)] 
        public String ValPrp { get; set; }
        
    }
}
