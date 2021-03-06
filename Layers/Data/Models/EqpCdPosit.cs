using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_POSIT_EQP",Schema="EQP")]
    public partial class EqpCdPosit : ModelBase
    {
        public virtual ICollection<EqpDscSv> EqpDscSvs { get; set; }
        
        public virtual ICollection<EqpDscEs> EqpDscEss { get; set; }
        
        public virtual ICollection<EqpDscPo> EqpDscPos { get; set; }
        
        public virtual ICollection<EqpDscSh> EqpDscShs { get; set; }
        
        public virtual ICollection<EqpDscCl> EqpDscCls { get; set; }
        
        public virtual ICollection<EqpEvt> EqpEvts { get; set; }
        
        public virtual ICollection<EqpDscDv> EqpDscDvs { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Position")]
        [Column("POSIT",Order=1)]
        [Required()]
        [MaxLength(60)] 
        public String Posit { get; set; }
        
    }
}
