using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("BM_PARAM",Schema="PRF")]
    public partial class PrfBmParam : ModelBase
    {
        [Key]
        [Description("CODE")]
        [Column("CODE",Order=0)]
        [Required()]
        [MaxLength(25)] 
        public String Code { get; set; }
        
        [Description("VALEUR")]
        [Column("VALEUR",Order=1)]
        [MaxLength(500)] 
        public String Valeur { get; set; }
        
    }
}
