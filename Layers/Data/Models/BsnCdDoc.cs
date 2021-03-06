using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_DOC_BSN",Schema="BSN")]
    public partial class BsnCdDoc : ModelBase
    {
        public virtual ICollection<BsnDoc> BsnDocs { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Code")]
        [Column("CODE",Order=1)]
        [Required()]
        [MaxLength(15)] 
        public String Code { get; set; }
        
        [Description("Libellé")]
        [Column("LIBELLE",Order=2)]
        [MaxLength(60)] 
        public String Libelle { get; set; }
        
        [Description("Répertoire")]
        [Column("PATH",Order=3)]
        [MaxLength(255)] 
        public String Path { get; set; }
        
    }
}
