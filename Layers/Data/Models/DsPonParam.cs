using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PON_PARAM_DS",Schema="DS")]
    public partial class DsPonParam
    {
        public virtual DsPon DsPon {get;set;}
        
        [Key]
        [Description("PON_DS__CODE")]
        [Column("PON_DS__CODE",Order=0)]
        [Required()]
        [MaxLength(15)] 
        public String PonDsCode { get; set; }
        
        [Key]
        [Description("PON_PARAM_DS__INDIC")]
        [Column("INDIC",Order=1)]
        [Required()]
        [MaxLength(12)] 
        public String Indic { get; set; }
        
        [Description("PON_PARAM_DS__POID")]
        [Column("POID",Order=2)]
        [Required()]
        public Int64 Poid { get; set; }
        
    }
}
