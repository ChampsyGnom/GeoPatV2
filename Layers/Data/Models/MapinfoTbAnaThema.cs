using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("TB_ANA_THEMA",Schema="MAPINFO")]
    public partial class MapinfoTbAnaThema : ModelBase
    {
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Nom User")]
        [Column("USERCODE",Order=1)]
        [Required()]
        [MaxLength(50)] 
        public String Usercode { get; set; }
        
        [Description("Carte")]
        [Column("MAP",Order=2)]
        [Required()]
        [MaxLength(50)] 
        public String Map { get; set; }
        
        [Description("Nom Modele")]
        [Column("MODELE",Order=3)]
        [Required()]
        [MaxLength(100)] 
        public String Modele { get; set; }
        
        [Description("Code Prp")]
        [Column("CODE_PRP",Order=4)]
        [Required()]
        [MaxLength(50)] 
        public String CodePrp { get; set; }
        
        [Description("Valeur Prp")]
        [Column("VAL_PRP",Order=5)]
        [MaxLength(254)] 
        public String ValPrp { get; set; }
        
    }
}
