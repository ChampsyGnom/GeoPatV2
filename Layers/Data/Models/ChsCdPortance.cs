using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_PORTANCE_CHS",Schema="CHS")]
    public partial class ChsCdPortance : ModelBase
    {
        public virtual ICollection<ChsPlateforme> ChsPlateformes { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Classe portance")]
        [Column("CLASSE",Order=1)]
        [Required()]
        [MaxLength(6)] 
        public String Classe { get; set; }
        
    }
}
