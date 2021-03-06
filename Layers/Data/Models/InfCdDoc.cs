using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_DOC_INF",Schema="INF")]
    public partial class InfCdDoc : ModelBase
    {
        public virtual ICollection<InfDoc> InfDocs { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Code document")]
        [Column("CODE",Order=1)]
        [Required()]
        [MaxLength(15)] 
        public String Code { get; set; }
        
        [Description("Répertoire")]
        [Column("PATH",Order=2)]
        [Required()]
        [MaxLength(255)] 
        public String Path { get; set; }
        
        [Description("Libellé")]
        [Column("LIBELLE",Order=3)]
        [Required()]
        [MaxLength(60)] 
        public String Libelle { get; set; }
        
    }
}
