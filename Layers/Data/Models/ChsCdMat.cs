using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_MAT_CHS",Schema="CHS")]
    public partial class ChsCdMat : ModelBase
    {
        public virtual ICollection<ChsMat> ChsMats { get; set; }
        
        public virtual ICollection<ChsCdOrig> ChsCdOrigs { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Nature de matériaux")]
        [Column("CODE",Order=1)]
        [Required()]
        [MaxLength(12)] 
        public String Code { get; set; }
        
    }
}
