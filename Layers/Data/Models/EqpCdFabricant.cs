using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_FABRICANT_EQP",Schema="EQP")]
    public partial class EqpCdFabricant : ModelBase
    {
        public virtual ICollection<EqpDscSh> EqpDscShs { get; set; }
        
        public virtual ICollection<EqpDscPo> EqpDscPos { get; set; }
        
        public virtual ICollection<EqpPanneau> EqpPanneaus { get; set; }
        
        public virtual ICollection<EqpDscCl> EqpDscCls { get; set; }
        
        public virtual ICollection<EqpDscEs> EqpDscEss { get; set; }
        
        public virtual ICollection<EqpDscDv> EqpDscDvs { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Nom Fabricant")]
        [Column("NOM",Order=1)]
        [Required()]
        [MaxLength(60)] 
        public String Nom { get; set; }
        
    }
}
