using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("TREE_DS",Schema="DS")]
    public partial class DsTree : ModelBase
    {
        public virtual ICollection<DsNode> DsNodes { get; set; }
        
        public virtual ICollection<DsTreeResult> DsTreeResults { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("TREE_DS__ID")]
        [Column("ID",Order=1)]
        [Required()]
        public Int64 Id { get; set; }
        
        [Description("TREE_DS__LIBELLE")]
        [Column("LIBELLE",Order=2)]
        [MaxLength(200)] 
        public String Libelle { get; set; }
        
    }
}
