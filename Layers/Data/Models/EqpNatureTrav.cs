using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("NATURE_TRAV_EQP",Schema="EQP")]
    public partial class EqpNatureTrav
    {
        public virtual EqpCdTravaux EqpCdTravaux {get;set;}
        
        public virtual ICollection<EqpTravaux> EqpTravauxs { get; set; }
        
        [Key]
        [Description("Type travaux")]
        [Column("CD_TRAVAUX_EQP__CODE",Order=0)]
        [Required()]
        [MaxLength(60)] 
        public String CdTravauxEqpCode { get; set; }
        
        [Key]
        [Description("Nature travaux")]
        [Column("NATURE",Order=1)]
        [Required()]
        [MaxLength(100)] 
        public String Nature { get; set; }
        
    }
}
