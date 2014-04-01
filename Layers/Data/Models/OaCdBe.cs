using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_BE_OA",Schema="OA")]
    public partial class OaCdBe
    {
        public virtual ICollection<OaDsc> OaDscs { get; set; }
        
        public virtual ICollection<OaDscTemp> OaDscTemps { get; set; }
        
        [Key]
        [Description("Bureau d'étude")]
        [Column("BUREAU",Order=0)]
        [Required()]
        [MaxLength(60)] 
        public String Bureau { get; set; }
        
    }
}
