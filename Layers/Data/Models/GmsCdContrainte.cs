using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_CONTRAINTE_GMS",Schema="GMS")]
    public partial class GmsCdContrainte : ModelBase
    {
        public virtual ICollection<GmsPrevision> GmsPrevisions { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Contrainte exploit")]
        [Column("TYPE",Order=1)]
        [Required()]
        [MaxLength(100)] 
        public String Type { get; set; }
        
    }
}
