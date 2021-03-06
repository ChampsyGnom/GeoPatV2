using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_ACCES_BSN",Schema="BSN")]
    public partial class BsnCdAcces : ModelBase
    {
        public virtual ICollection<BsnDsc> BsnDscs { get; set; }
        
        public virtual ICollection<BsnDscTemp> BsnDscTemps { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Voie d'accès")]
        [Column("VACCES",Order=1)]
        [Required()]
        [MaxLength(60)] 
        public String Vacces { get; set; }
        
    }
}
