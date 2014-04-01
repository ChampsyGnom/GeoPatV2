using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_MARQUAGE_SH_EQP",Schema="EQP")]
    public partial class EqpCdMarquageSh : ModelBase
    {
        public virtual EqpCdModSh EqpCdModSh {get;set;}
        
        public virtual ICollection<EqpDscSh> EqpDscShs { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Modulation")]
        [Column("CD_MOD_SH_EQP__MOD",Order=0)]
        [Required()]
        [MaxLength(6)] 
        public String CdModShEqpMod { get; set; }
        
        [Description("Marquage")]
        [Column("MARQUAGE",Order=1)]
        [Required()]
        [MaxLength(255)] 
        public String Marquage { get; set; }
        
        [Description("Largeur (xU)")]
        [Column("LARGEUR",Order=2)]
        public Nullable<Int64> Largeur { get; set; }
        
    }
}
