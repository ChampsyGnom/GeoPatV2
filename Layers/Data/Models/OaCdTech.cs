using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_TECH_OA",Schema="OA")]
    public partial class OaCdTech : ModelBase
    {
        public virtual ICollection<OaTablier> OaTabliers { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Technique")]
        [Column("TECHNIQUE",Order=1)]
        [Required()]
        [MaxLength(12)] 
        public String Technique { get; set; }
        
        [Description("Libellé")]
        [Column("LIBELLE",Order=2)]
        [MaxLength(60)] 
        public String Libelle { get; set; }
        
        [Description("Garantie (mois)")]
        [Column("GARANTIE",Order=3)]
        public Nullable<Int64> Garantie { get; set; }
        
        [Description("Durée de vie (mois)")]
        [Column("DVT",Order=4)]
        public Nullable<Int64> Dvt { get; set; }
        
    }
}
