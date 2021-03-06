using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("NODE_WEB",Schema="WEB")]
    public partial class WebNode : ModelBase
    {
        private WebCdNode _webCdNode;
        public virtual WebCdNode WebCdNode 
        {
            get
            {
                return this._webCdNode;
                
            }
            set
            {
                this._webCdNode = value;
                this.CdNodeWebName = this._webCdNode.Name;
            }
        }
        
        [Required()]
        [Column("CD_NODE_WEB_ID_PK",Order=0)]
        public Int64 WebCdNodeIdPk {get;set;}
        
        public virtual ICollection<WebNodeParam> WebNodeParams { get; set; }
        
        public virtual ICollection<WebModeleWebNode> WebModeleWebNodes { get; set; }
        
        public virtual ICollection<WebNodeWebStyle> WebNodeWebStyles { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant du noeud")]
        [Column("ID",Order=2)]
        [Required()]
        public Int64 Id { get; set; }
        
        [Description("Type de noeud")]
        [Column("CD_NODE_WEB__NAME",Order=3)]
        [Required()]
        [MaxLength(255)] 
        public String CdNodeWebName { get; set; }
        
        [Description("Libellé")]
        [Column("LIBELLE",Order=4)]
        [Required()]
        [MaxLength(255)] 
        public String Libelle { get; set; }
        
        [Description("Identifiant du noeud parent")]
        [Column("PARENT_ID",Order=5)]
        public Nullable<Int64> ParentId { get; set; }
        
        [Description("Ordre du noeud dans le parent")]
        [Column("TREE_ORDER",Order=6)]
        public Nullable<Int64> TreeOrder { get; set; }
        
    }
}
