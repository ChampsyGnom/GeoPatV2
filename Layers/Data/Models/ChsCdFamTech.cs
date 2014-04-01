using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_FAM_TECH_CHS",Schema="CHS")]
    public partial class ChsCdFamTech
    {
        public virtual ICollection<ChsCdTech> ChsCdTechs { get; set; }
        
        [Key]
        [Description("Famille technique")]
        [Column("CODE",Order=0)]
        [Required()]
        [MaxLength(15)] 
        public String Code { get; set; }
        
    }
}
