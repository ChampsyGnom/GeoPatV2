using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_ORIGIN_OA",Schema="OA")]
    public partial class OaCdOrigin : ModelBase
    {
        public virtual ICollection<OaHistoNote> OaHistoNotes { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Origine")]
        [Column("ORIGINE",Order=1)]
        [Required()]
        [MaxLength(20)] 
        public String Origine { get; set; }
        
    }
}
