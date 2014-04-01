using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("SYS_USER_GMS",Schema="GMS")]
    public partial class GmsSysUser
    {
        [Key]
        [Description("SYS_USER_GMS__CODE_DBS")]
        [Column("CODE_DBS",Order=0)]
        [Required()]
        [MaxLength(50)] 
        public String CodeDbs { get; set; }
        
        [Key]
        [Description("SYS_USER_GMS__CODE_TABLE")]
        [Column("CODE_TABLE",Order=1)]
        [Required()]
        [MaxLength(100)] 
        public String CodeTable { get; set; }
        
        [Key]
        [Description("SYS_USER_GMS__CODE_COLONNE")]
        [Column("CODE_COLONNE",Order=2)]
        [Required()]
        [MaxLength(100)] 
        public String CodeColonne { get; set; }
        
        [Key]
        [Description("SYS_USER_GMS__NOM_USER")]
        [Column("NOM_USER",Order=3)]
        [Required()]
        [MaxLength(150)] 
        public String NomUser { get; set; }
        
        [Key]
        [Description("SYS_USER_GMS__CODE_PRP")]
        [Column("CODE_PRP",Order=4)]
        [Required()]
        [MaxLength(255)] 
        public String CodePrp { get; set; }
        
        [Description("SYS_USER_GMS__VAL_PRP")]
        [Column("VAL_PRP",Order=5)]
        [Required()]
        [MaxLength(500)] 
        public String ValPrp { get; set; }
        
    }
}
