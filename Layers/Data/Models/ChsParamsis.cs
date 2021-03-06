using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PARAMSIS",Schema="CHS")]
    public partial class ChsParamsis : ModelBase
    {
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("ENTREE")]
        [Column("ENTREE",Order=1)]
        [Required()]
        [MaxLength(50)] 
        public String Entree { get; set; }
        
        [Description("PARAMETRE")]
        [Column("PARAMETRE",Order=2)]
        [Required()]
        [MaxLength(50)] 
        public String Parametre { get; set; }
        
        [Description("TYPE")]
        [Column("TYPE",Order=3)]
        [Required()]
        [MaxLength(50)] 
        public String Type { get; set; }
        
        [Description("VALEUR")]
        [Column("VALEUR",Order=4)]
        [MaxLength(50)] 
        public String Valeur { get; set; }
        
    }
}
