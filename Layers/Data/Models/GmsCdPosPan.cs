using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_POS_PAN_GMS",Schema="GMS")]
    public partial class GmsCdPosPan : ModelBase
    {
        public virtual ICollection<GmsPanneau> GmsPanneaus { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Position")]
        [Column("POSIT",Order=1)]
        [Required()]
        [MaxLength(4)] 
        public String Posit { get; set; }
        
        [Description("Libellé")]
        [Column("LIBELLE",Order=2)]
        [MaxLength(60)] 
        public String Libelle { get; set; }
        
    }
}
