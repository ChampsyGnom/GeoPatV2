using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("MAT_CHS",Schema="CHS")]
    public partial class ChsMat : ModelBase
    {
        private ChsCdMat _chsCdMat;
        public virtual ChsCdMat ChsCdMat 
        {
            get
            {
                return this._chsCdMat;
                
            }
            set
            {
                this._chsCdMat = value;
                this.CdMatChsCode = this._chsCdMat.Code;
            }
        }
        
        [Required()]
        [Column("CD_MAT_CHS_ID_PK",Order=0)]
        public Int64 ChsCdMatIdPk {get;set;}
        
        public virtual ICollection<ChsMatPave> ChsMatPaves { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Matériaux")]
        [Column("MAT",Order=2)]
        [Required()]
        [MaxLength(60)] 
        public String Mat { get; set; }
        
        [Description("Nature de matériaux")]
        [Column("CD_MAT_CHS__CODE",Order=3)]
        [Required()]
        [MaxLength(12)] 
        public String CdMatChsCode { get; set; }
        
    }
}
