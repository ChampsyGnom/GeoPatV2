using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_EVT_EQP",Schema="EQP")]
    public partial class EqpCdEvt
    {
        public virtual ICollection<EqpEvt> EqpEvts { get; set; }
        
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
