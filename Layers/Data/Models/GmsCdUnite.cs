using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_UNITE_GMS",Schema="GMS")]
    public partial class GmsCdUnite : ModelBase
    {
        public virtual ICollection<GmsBpu> GmsBpus { get; set; }
        
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
