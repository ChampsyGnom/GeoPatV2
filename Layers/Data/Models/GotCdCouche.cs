using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_COUCHE_GOT",Schema="GOT")]
    public partial class GotCdCouche : ModelBase
    {
        public virtual ICollection<GotCouche> GotCouches { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Code couche")]
        [Column("CODE",Order=1)]
        [Required()]
        [MaxLength(50)] 
        public String Code { get; set; }
        
        [Description("Position")]
        [Column("POSIT",Order=2)]
        public Nullable<Int64> Posit { get; set; }
        
        [Description("Couleur")]
        [Column("COULEUR",Order=3)]
        [MaxLength(16)] 
        public String Couleur { get; set; }
        
    }
}
