using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_EVT_GMS",Schema="GMS")]
    public partial class GmsCdEvt
    {
        public virtual ICollection<GmsEvt> GmsEvts { get; set; }
        
        [Key]
        [Description("Type événement")]
        [Column("TYPE",Order=0)]
        [Required()]
        [MaxLength(25)] 
        public String Type { get; set; }
        
        [Description("Impact métier")]
        [Column("IMPACT",Order=1)]
        public Nullable<int> Impact { get; set; }
        
    }
}
