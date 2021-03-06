using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_AIRE_INF",Schema="INF")]
    public partial class InfCdAire : ModelBase
    {
        public virtual ICollection<InfAire> InfAires { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Type Aire")]
        [Column("TYPE",Order=1)]
        [Required()]
        [MaxLength(60)] 
        public String Type { get; set; }
        
    }
}
