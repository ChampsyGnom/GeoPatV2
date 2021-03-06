using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_COU_CHS",Schema="CHS")]
    public partial class ChsCdCou : ModelBase
    {
        public virtual ICollection<ChsPave> ChsPaves { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Couche")]
        [Column("COUCHE",Order=1)]
        [Required()]
        [MaxLength(14)] 
        public String Couche { get; set; }
        
        [Description("Position")]
        [Column("POSIT",Order=2)]
        [Required()]
        public Int64 Posit { get; set; }
        
        [Description("Couleur")]
        [Column("COULEUR",Order=3)]
        [MaxLength(16)] 
        public String Couleur { get; set; }
        
    }
}
