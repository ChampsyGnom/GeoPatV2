using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_FRANCH_EQP",Schema="EQP")]
    public partial class EqpCdFranch : ModelBase
    {
        public virtual ICollection<EqpDscCl> EqpDscCls { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Anti franchissement")]
        [Column("ANTI_FRANCH",Order=1)]
        [Required()]
        [MaxLength(60)] 
        public String AntiFranch { get; set; }
        
    }
}
