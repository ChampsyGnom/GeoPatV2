using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("NODE_PARAM_DS",Schema="DS")]
    public partial class DsNodeParam : ModelBase
    {
        private DsNode _dsNode;
        public virtual DsNode DsNode 
        {
            get
            {
                return this._dsNode;
                
            }
            set
            {
                this._dsNode = value;
                this.TreeDsId = this._dsNode.TreeDsId;
                this.NodeDsId = this._dsNode.Id;
            }
        }
        
        [Required()]
        [Column("NODE_DS_ID_PK",Order=0)]
        public Int64 DsNodeIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("TREE_DS__ID")]
        [Column("TREE_DS__ID",Order=2)]
        [Required()]
        public Int64 TreeDsId { get; set; }
        
        [Description("NODE_DS__ID")]
        [Column("NODE_DS__ID",Order=3)]
        [Required()]
        public Int64 NodeDsId { get; set; }
        
        [Description("NODE_PARAM_DS__ID")]
        [Column("ID",Order=4)]
        [Required()]
        public Int64 Id { get; set; }
        
        [Description("NODE_PARAM_DS__AGR")]
        [Column("AGR",Order=5)]
        [MaxLength(20)] 
        public String Agr { get; set; }
        
        [Description("NODE_PARAM_DS__INDIC")]
        [Column("INDIC",Order=6)]
        [MaxLength(20)] 
        public String Indic { get; set; }
        
        [Description("NODE_PARAM_DS__COMPARE_VALUE")]
        [Column("COMPARE_VALUE",Order=7)]
        public Nullable<Int64> CompareValue { get; set; }
        
        [Description("NODE_PARAM_DS__COMPARE_OP")]
        [Column("COMPARE_OP",Order=8)]
        [MaxLength(50)] 
        public String CompareOp { get; set; }
        
    }
}
