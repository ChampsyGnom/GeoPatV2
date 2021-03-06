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
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("CODE")]
        [Column("CODE",Order=1)]
        [Required()]
        [MaxLength(25)] 
        public String Code { get; set; }
        
        [Description("VALEUR")]
        [Column("VALEUR",Order=2)]
        [MaxLength(500)] 
        public String Valeur { get; set; }
        
    }
}
