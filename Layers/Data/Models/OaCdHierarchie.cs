using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_HIERARCHIE_OA",Schema="OA")]
    public partial class OaCdHierarchie : ModelBase
    {
        public virtual ICollection<OaDsc> OaDscs { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Caractère stratégique")]
        [Column("HIERARCHIE",Order=1)]
        [Required()]
        [MaxLength(60)] 
        public String Hierarchie { get; set; }
        
    }
}
