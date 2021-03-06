using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_FAM_SV_EQP",Schema="EQP")]
    public partial class EqpCdFamSv : ModelBase
    {
        public virtual ICollection<EqpDscSv> EqpDscSvs { get; set; }
        
        public virtual ICollection<EqpCdTypeSv> EqpCdTypeSvs { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Famille")]
        [Column("FAMILLE",Order=1)]
        [Required()]
        [MaxLength(6)] 
        public String Famille { get; set; }
        
        [Description("Libellé")]
        [Column("LIBELLE",Order=2)]
        [MaxLength(60)] 
        public String Libelle { get; set; }
        
    }
}
