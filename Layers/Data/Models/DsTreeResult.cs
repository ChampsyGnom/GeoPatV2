using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("TREE_RESULT_DS",Schema="DS")]
    public partial class DsTreeResult : ModelBase
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
        
        public virtual ICollection<DsTreeResultPave> DsTreeResultPaves { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("TREE_DS__ID")]
        [Column("TREE_DS__ID",Order=2)]
        [Required()]
        public Int64 TreeDsId { get; set; }
        
        [Description("TREE_RESULT_DS__ID")]
        [Column("ID",Order=3)]
        [Required()]
        public Int64 Id { get; set; }
        
        [Description("TREE_RESULT_DS__LIBELLE")]
        [Column("LIBELLE",Order=4)]
        [Required()]
        [MaxLength(100)] 
        public String Libelle { get; set; }
        
    }
}
