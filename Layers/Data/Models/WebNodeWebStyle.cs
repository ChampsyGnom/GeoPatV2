using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("NODE_WEB__STYLE_WEB",Schema="WEB")]
    public partial class WebNodeWebStyle : ModelBase
    {
        public virtual WebNode WebNode {get;set;}
        
        [Required()]
        [Column("NODE_WEB_ID_PK",Order=0)]
        public Int64 WebNodeIdPk {get;set;}
        
        public virtual WebStyle WebStyle {get;set;}
        
        [Required()]
        [Column("STYLE_WEB_ID_PK",Order=1)]
        public Int64 WebStyleIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant du noeud")]
        [Column("NODE_WEB__ID",Order=3)]
        [Required()]
        public Int64 NodeWebId { get; set; }
        
        [Description("Identifiant du style")]
        [Column("STYLE_WEB__ID",Order=4)]
        [Required()]
        public Int64 StyleWebId { get; set; }
        
    }
}
