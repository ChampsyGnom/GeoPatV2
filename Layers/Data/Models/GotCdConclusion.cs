using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_CONCLUSION_GOT",Schema="GOT")]
    public partial class GotCdConclusion : ModelBase
    {
        public virtual ICollection<GotCdConclusionInsp> GotCdConclusionInsps { get; set; }
        
        public virtual ICollection<GotCdConclusionInspTmp> GotCdConclusionInspTmps { get; set; }
        
        [Key]
        [Description("Identifiant conclusion")]
        [Column("ID_CONC",Order=0)]
        [Required()]
        public Int64 IdConc { get; set; }
        
        [Description("Libellé conclusion")]
        [Column("LIBELLE",Order=1)]
        [Required()]
        [MaxLength(500)] 
        public String Libelle { get; set; }
        
        [Description("N° Ordre conclusion")]
        [Column("ORDRE",Order=2)]
        [Required()]
        public Int64 Ordre { get; set; }
        
    }
}
