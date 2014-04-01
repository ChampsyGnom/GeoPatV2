using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("DICTIONNAIRE_BSN",Schema="BSN")]
    public partial class BsnDictionnaire : ModelBase
    {
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Nom")]
        [Column("NOM",Order=0)]
        [Required()]
        [MaxLength(100)] 
        public String Nom { get; set; }
        
        [Description("Description")]
        [Column("DESCRIPTION",Order=1)]
        [MaxLength(255)] 
        public String Description { get; set; }
        
        [Description("Définition")]
        [Column("DEFINITION",Order=2)]
        [MaxLength(500)] 
        public String Definition { get; set; }
        
        [Description("Mots clés")]
        [Column("MOTSCLES",Order=3)]
        [MaxLength(255)] 
        public String Motscles { get; set; }
        
    }
}
