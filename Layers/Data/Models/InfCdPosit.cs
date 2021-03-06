using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_POSIT_INF",Schema="INF")]
    public partial class InfCdPosit : ModelBase
    {
        public virtual ICollection<InfSecurite> InfSecurites { get; set; }
        
        public virtual ICollection<InfEclairage> InfEclairages { get; set; }
        
        public virtual ICollection<InfEvt> InfEvts { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Position")]
        [Column("POSIT",Order=1)]
        [Required()]
        [MaxLength(12)] 
        public String Posit { get; set; }
        
        [Description("N° Ordre")]
        [Column("ORDRE",Order=2)]
        public Nullable<Int64> Ordre { get; set; }
        
    }
}
