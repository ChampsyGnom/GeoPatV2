using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_POSIT_INF",Schema="INF")]
    public partial class InfCdPosit
    {
        public virtual ICollection<InfSecurite> InfSecurites { get; set; }
        
        public virtual ICollection<InfEclairage> InfEclairages { get; set; }
        
        public virtual ICollection<InfEvt> InfEvts { get; set; }
        
        [Key]
        [Description("Position")]
        [Column("POSIT",Order=0)]
        [Required()]
        [MaxLength(12)] 
        public String Posit { get; set; }
        
        [Description("N° Ordre")]
        [Column("ORDRE",Order=1)]
        public Nullable<Int64> Ordre { get; set; }
        
    }
}
