using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("SYS_USER_WEB",Schema="WEB")]
    public partial class WebSysUser : ModelBase
    {
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Code dbs")]
        [Column("CODE_DBS",Order=1)]
        [Required()]
        [MaxLength(50)] 
        public String CodeDbs { get; set; }
        
        [Description("Code table")]
        [Column("CODE_TABLE",Order=2)]
        [Required()]
        [MaxLength(200)] 
        public String CodeTable { get; set; }
        
        [Description("Code colonne")]
        [Column("CODE_COLONNE",Order=3)]
        [Required()]
        [MaxLength(200)] 
        public String CodeColonne { get; set; }
        
        [Description("Code utilisateur")]
        [Column("NOM_USER",Order=4)]
        [Required()]
        [MaxLength(200)] 
        public String NomUser { get; set; }
        
        [Description("Code propriétée")]
        [Column("CODE_PRP",Order=5)]
        [Required()]
        [MaxLength(255)] 
        public String CodePrp { get; set; }
        
        [Description("Valeur propriétée")]
        [Column("VAL_PRP",Order=6)]
        [Required()]
        [MaxLength(255)] 
        public String ValPrp { get; set; }
        
    }
}
