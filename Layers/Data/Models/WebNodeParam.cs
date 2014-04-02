using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("NODE_PARAM_WEB",Schema="WEB")]
    public partial class WebNodeParam : ModelBase
    {
        public virtual WebNode WebNode {get;set;}
        
        [Required()]
        [Column("NODE_WEB_ID_PK",Order=0)]
        public Int64 WebNodeIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant du noeud")]
        [Column("NODE_WEB__ID",Order=2)]
        [Required()]
        public Int64 NodeWebId { get; set; }
        
        [Description("Code du paramètre")]
        [Column("CODE",Order=3)]
        [Required()]
        [MaxLength(255)] 
        public String Code { get; set; }
        
        [Description("Valeur du paramètre")]
        [Column("VALEUR",Order=4)]
        [Required()]
        [MaxLength(255)] 
        public String Valeur { get; set; }
        
    }
}
