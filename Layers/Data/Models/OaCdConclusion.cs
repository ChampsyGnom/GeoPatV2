using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_CONCLUSION_OA",Schema="OA")]
    public partial class OaCdConclusion : ModelBase
    {
        public virtual ICollection<OaCdConclusionInsp> OaCdConclusionInsps { get; set; }
        
        public virtual ICollection<OaCdConclusionInspTmp> OaCdConclusionInspTmps { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant conclusion")]
        [Column("ID_CONC",Order=1)]
        [Required()]
        public Int64 IdConc { get; set; }
        
        [Description("Libellé conclusion")]
        [Column("LIBELLE",Order=2)]
        [Required()]
        [MaxLength(500)] 
        public String Libelle { get; set; }
        
        [Description("N° ordre conclusion")]
        [Column("ORDRE",Order=3)]
        [Required()]
        public Int64 Ordre { get; set; }
        
    }
}
