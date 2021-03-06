using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_SERVICE_INF",Schema="INF")]
    public partial class InfCdService : ModelBase
    {
        public virtual ICollection<InfAireService> InfAireServices { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Type Service")]
        [Column("SERVICE",Order=1)]
        [Required()]
        [MaxLength(60)] 
        public String Service { get; set; }
        
    }
}
