using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_COMPOSANT_GOT",Schema="GOT")]
    public partial class GotCdComposant : ModelBase
    {
        public virtual ICollection<GotCdEntete> GotCdEntetes { get; set; }
        
        [Key]
        [Description("Type")]
        [Column("TYPE_COMP",Order=0)]
        [Required()]
        [MaxLength(6)] 
        public String TypeComp { get; set; }
        
        [Description("Libellé")]
        [Column("LIBELLE",Order=1)]
        [MaxLength(60)] 
        public String Libelle { get; set; }
        
    }
}
