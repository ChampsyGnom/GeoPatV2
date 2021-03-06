using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_MAT_OA",Schema="OA")]
    public partial class OaCdMat : ModelBase
    {
        public virtual ICollection<OaDsc> OaDscs { get; set; }
        
        public virtual ICollection<OaDscTemp> OaDscTemps { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Matériaux")]
        [Column("MATERIAUX",Order=1)]
        [Required()]
        [MaxLength(60)] 
        public String Materiaux { get; set; }
        
    }
}
