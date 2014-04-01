using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("BM_SCHEMA",Schema="PRF")]
    public partial class PrfBmSchema
    {
        public virtual ICollection<PrfBmTable> PrfBmTables { get; set; }
        
        public virtual ICollection<PrfBmProfil> PrfBmProfils { get; set; }
        
        [Key]
        [Description("Code schéma")]
        [Column("SCHEMA",Order=0)]
        [Required()]
        [MaxLength(20)] 
        public String Schema { get; set; }
        
        [Description("Libellé")]
        [Column("LIBELLE",Order=1)]
        [Required()]
        [MaxLength(200)] 
        public String Libelle { get; set; }
        
    }
}
