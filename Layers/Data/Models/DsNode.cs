using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("NODE_DS",Schema="DS")]
    public partial class DsNode : ModelBase
    {
        private DsTree _dsTree;
        public virtual DsTree DsTree 
        {
            get
            {
                return this._dsTree;
                
            }
            set
            {
                this._dsTree = value;
                this.TreeDsId = this._dsTree.Id;
            }
        }
        
        [Required()]
        [Column("TREE_DS_ID_PK",Order=0)]
        public Int64 DsTreeIdPk {get;set;}
        
        public virtual ICollection<DsNodeParam> DsNodeParams { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("TREE_DS__ID")]
        [Column("TREE_DS__ID",Order=2)]
        [Required()]
        public Int64 TreeDsId { get; set; }
        
        [Description("NODE_DS__ID")]
        [Column("ID",Order=3)]
        [Required()]
        public Int64 Id { get; set; }
        
        [Description("NODE_DS__LIBELLE")]
        [Column("LIBELLE",Order=4)]
        [MaxLength(200)] 
        public String Libelle { get; set; }
        
        [Description("NODE_DS__TYPE")]
        [Column("TYPE",Order=5)]
        [Required()]
        [MaxLength(100)] 
        public String Type { get; set; }
        
        [Description("NODE_DS__PARENT_ID")]
        [Column("PARENT_ID",Order=6)]
        [Required()]
        public Int64 ParentId { get; set; }
        
        [Description("NODE_DS__TECHNIQUE")]
        [Column("TECHNIQUE",Order=7)]
        [MaxLength(100)] 
        public String Technique { get; set; }
        
        [Description("NODE_DS__STRUCTURE")]
        [Column("STRUCTURE",Order=8)]
        [MaxLength(100)] 
        public String Structure { get; set; }
        
        [Description("NODE_DS__NB_SI")]
        [Column("NB_SI",Order=9)]
        public Nullable<Int64> NbSi { get; set; }
        
        [Description("NODE_DS__IS_FOR_TRUE")]
        [Column("IS_FOR_TRUE",Order=10)]
        [Required()]
        public Int64 IsForTrue { get; set; }
        
    }
}
