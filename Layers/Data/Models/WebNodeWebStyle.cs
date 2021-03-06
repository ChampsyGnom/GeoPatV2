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
        private WebNode _webNode;
        public virtual WebNode WebNode 
        {
            get
            {
                return this._webNode;
                
            }
            set
            {
                this._webNode = value;
                this.NodeWebId = this._webNode.Id;
            }
        }
        
        [Required()]
        [Column("NODE_WEB_ID_PK",Order=0)]
        public Int64 WebNodeIdPk {get;set;}
        
        private WebStyle _webStyle;
        public virtual WebStyle WebStyle 
        {
            get
            {
                return this._webStyle;
                
            }
            set
            {
                this._webStyle = value;
                this.StyleWebId = this._webStyle.Id;
            }
        }
        
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
