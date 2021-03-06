using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_FAM_TECH_CHS",Schema="CHS")]
    public partial class ChsCdFamTech : ModelBase
    {
        public virtual ICollection<ChsCdTech> ChsCdTechs { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Famille technique")]
        [Column("CODE",Order=1)]
        [Required()]
        [MaxLength(15)] 
        public String Code { get; set; }
        
    }
}
