using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_ORIGIN_GMS",Schema="GMS")]
    public partial class GmsCdOrigin : ModelBase
    {
        public virtual ICollection<GmsHistoNote> GmsHistoNotes { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Origine Note")]
        [Column("ORIGINE",Order=1)]
        [Required()]
        [MaxLength(20)] 
        public String Origine { get; set; }
        
    }
}
