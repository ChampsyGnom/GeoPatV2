using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_MODELE_WEB",Schema="WEB")]
    public partial class WebCdModele : ModelBase
    {
        public virtual ICollection<WebModele> WebModeles { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Code du type de modèle (SIG_REF_DETAIL SIG_REF_SCHEMA)")]
        [Column("CODE",Order=1)]
        [Required()]
        [MaxLength(50)] 
        public String Code { get; set; }
        
        [Description("Nom du type de modele (detail synoptique schématique)")]
        [Column("LIBELLE",Order=2)]
        [Required()]
        [MaxLength(255)] 
        public String Libelle { get; set; }
        
    }
}
