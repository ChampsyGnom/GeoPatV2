using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("TREE_RESULT_PAVE_DS",Schema="DS")]
    public partial class DsTreeResultPave : ModelBase
    {
        private DsTreeResult _dsTreeResult;
        public virtual DsTreeResult DsTreeResult 
        {
            get
            {
                return this._dsTreeResult;
                
            }
            set
            {
                this._dsTreeResult = value;
                this.TreeDsId = this._dsTreeResult.TreeDsId;
                this.TreeResultDsId = this._dsTreeResult.Id;
            }
        }
        
        [Required()]
        [Column("TREE_RESULT_DS_ID_PK",Order=0)]
        public Int64 DsTreeResultIdPk {get;set;}
        
        public virtual ICollection<DsTreeResultPaveVoie> DsTreeResultPaveVoies { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("TREE_DS__ID")]
        [Column("TREE_DS__ID",Order=2)]
        [Required()]
        public Int64 TreeDsId { get; set; }
        
        [Description("TREE_RESULT_DS__ID")]
        [Column("TREE_RESULT_DS__ID",Order=3)]
        [Required()]
        public Int64 TreeResultDsId { get; set; }
        
        [Description("TREE_RESULT_PAVE_DS__LIAISON")]
        [Column("LIAISON",Order=4)]
        [Required()]
        [MaxLength(15)] 
        public String Liaison { get; set; }
        
        [Description("TREE_RESULT_PAVE_DS__SENS")]
        [Column("SENS",Order=5)]
        [Required()]
        [MaxLength(6)] 
        public String Sens { get; set; }
        
        [Description("TREE_RESULT_PAVE_DS__ABS_DEB")]
        [Column("ABS_DEB",Order=6)]
        [Required()]
        public Int64 AbsDeb { get; set; }
        
        [Description("TREE_RESULT_PAVE_DS__ABS_FIN")]
        [Column("ABS_FIN",Order=7)]
        [Required()]
        public Int64 AbsFin { get; set; }
        
        [Description("TREE_RESULT_PAVE_DS__TECHNIQUE")]
        [Column("TECHNIQUE",Order=8)]
        [Required()]
        [MaxLength(25)] 
        public String Technique { get; set; }
        
    }
}
