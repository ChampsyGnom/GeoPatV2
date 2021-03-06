using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_UNITE_GOT",Schema="GOT")]
    public partial class GotCdUnite : ModelBase
    {
        public virtual ICollection<GotBpu> GotBpus { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Unité")]
        [Column("UNITE",Order=1)]
        [Required()]
        [MaxLength(12)] 
        public String Unite { get; set; }
        
    }
}
