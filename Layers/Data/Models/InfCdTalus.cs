using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_TALUS_INF",Schema="INF")]
    public partial class InfCdTalus : ModelBase
    {
        public virtual ICollection<InfTalus> InfTaluss { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Type Talus")]
        [Column("TYPE",Order=1)]
        [Required()]
        [MaxLength(25)] 
        public String Type { get; set; }
        
    }
}
