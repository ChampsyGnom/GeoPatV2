using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_SUPPORT_SV_EQP",Schema="EQP")]
    public partial class EqpCdSupportSv : ModelBase
    {
        public virtual ICollection<EqpDscSv> EqpDscSvs { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Type support")]
        [Column("SUPPORT",Order=1)]
        [Required()]
        [MaxLength(60)] 
        public String Support { get; set; }
        
        [Description("Garantie")]
        [Column("GARANTIE",Order=2)]
        public Nullable<Int64> Garantie { get; set; }
        
        [Description("Durée de vie (mois)")]
        [Column("DVT",Order=3)]
        public Nullable<Int64> Dvt { get; set; }
        
    }
}
