using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("FAM_DEC_INF",Schema="INF")]
    public partial class InfFamDec : ModelBase
    {
        public virtual ICollection<InfCdDec> InfCdDecs { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Code famille")]
        [Column("FAM_DEC",Order=1)]
        [Required()]
        [MaxLength(6)] 
        public String FamDec { get; set; }
        
        [Description("Libellé")]
        [Column("LIBELLE",Order=2)]
        [Required()]
        [MaxLength(60)] 
        public String Libelle { get; set; }
        
    }
}
