using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("TREE_RESULT_PAVE_VOIE_DS",Schema="DS")]
    public partial class DsTreeResultPaveVoie : ModelBase
    {
        private DsTreeResultPave _dsTreeResultPave;
        public virtual DsTreeResultPave DsTreeResultPave 
        {
            get
            {
                return this._dsTreeResultPave;
                
            }
            set
            {
                this._dsTreeResultPave = value;
                this.TreeDsId = this._dsTreeResultPave.TreeDsId;
                this.TreeResultDsId = this._dsTreeResultPave.TreeResultDsId;
                this.TreeResultPaveDsLiaison = this._dsTreeResultPave.Liaison;
                this.TreeResultPaveDsSens = this._dsTreeResultPave.Sens;
                this.TreeResultPaveDsAbsDeb = this._dsTreeResultPave.AbsDeb;
            }
        }
        
        [Required()]
        [Column("TREE_RESULT_PAVE_DS_ID_PK",Order=0)]
        public Int64 DsTreeResultPaveIdPk {get;set;}
        
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
        [Column("TREE_RESULT_PAVE_DS__LIAISON",Order=4)]
        [Required()]
        [MaxLength(15)] 
        public String TreeResultPaveDsLiaison { get; set; }
        
        [Description("TREE_RESULT_PAVE_DS__SENS")]
        [Column("TREE_RESULT_PAVE_DS__SENS",Order=5)]
        [Required()]
        [MaxLength(6)] 
        public String TreeResultPaveDsSens { get; set; }
        
        [Description("TREE_RESULT_PAVE_DS__ABS_DEB")]
        [Column("TREE_RESULT_PAVE_DS__ABS_DEB",Order=6)]
        [Required()]
        public Int64 TreeResultPaveDsAbsDeb { get; set; }
        
        [Description("TREE_RESULT_PAVE_VOIE_DS__VOIE")]
        [Column("VOIE",Order=7)]
        [Required()]
        [MaxLength(6)] 
        public String Voie { get; set; }
        
        [Description("TREE_RESULT_PAVE_VOIE_DS__ABS_DEB")]
        [Column("ABS_DEB",Order=8)]
        [Required()]
        public Int64 AbsDeb { get; set; }
        
        [Description("TREE_RESULT_PAVE_VOIE_DS__ABS_FIN")]
        [Column("ABS_FIN",Order=9)]
        [Required()]
        public Int64 AbsFin { get; set; }
        
    }
}
