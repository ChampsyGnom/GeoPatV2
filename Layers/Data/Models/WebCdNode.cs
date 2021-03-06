using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_NODE_WEB",Schema="WEB")]
    public partial class WebCdNode : ModelBase
    {
        public virtual ICollection<WebNode> WebNodes { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Type de noeud")]
        [Column("NAME",Order=1)]
        [Required()]
        [MaxLength(255)] 
        public String Name { get; set; }
        
    }
}
