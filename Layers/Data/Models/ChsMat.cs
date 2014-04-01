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
        public virtual ChsCdMat ChsCdMat {get;set;}
        
        public virtual ICollection<ChsMatPave> ChsMatPaves { get; set; }
        
        [Key]
        [Description("Matériaux")]
        [Column("MAT",Order=0)]
        [Required()]
        [MaxLength(60)] 
        public String Mat { get; set; }
        
        [Description("Nature de matériaux")]
        [Column("CD_MAT_CHS__CODE",Order=1)]
        [Required()]
        [MaxLength(12)] 
        public String CdMatChsCode { get; set; }
        
    }
}
