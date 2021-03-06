using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_TYPE_PV_BSN",Schema="BSN")]
    public partial class BsnCdTypePv : ModelBase
    {
        public virtual ICollection<BsnCamp> BsnCamps { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Type de PV")]
        [Column("CODE",Order=1)]
        [Required()]
        [MaxLength(15)] 
        public String Code { get; set; }
        
        [Description("Libellé")]
        [Column("LIBELLE",Order=2)]
        [Required()]
        [MaxLength(60)] 
        public String Libelle { get; set; }
        
        [Description("Cycle")]
        [Column("CYCLE",Order=3)]
        public Nullable<Int64> Cycle { get; set; }
        
        [Description("Coût unitaire")]
        [Column("COUT",Order=4)]
        public Nullable<Int64> Cout { get; set; }
        
    }
}
