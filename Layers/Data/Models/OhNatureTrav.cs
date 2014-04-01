using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("NATURE_TRAV_OH",Schema="OH")]
    public partial class OhNatureTrav : ModelBase
    {
        public virtual OhCdTravaux OhCdTravaux {get;set;}
        
        public virtual ICollection<OhTravaux> OhTravauxs { get; set; }
        
        [Key]
        [Description("Type travaux")]
        [Column("CD_TRAVAUX_OH__CODE",Order=0)]
        [Required()]
        [MaxLength(60)] 
        public String CdTravauxOhCode { get; set; }
        
        [Key]
        [Description("Nature travaux")]
        [Column("NATURE",Order=1)]
        [Required()]
        [MaxLength(100)] 
        public String Nature { get; set; }
        
    }
}
