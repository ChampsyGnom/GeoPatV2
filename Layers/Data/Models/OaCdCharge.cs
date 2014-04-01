using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_CHARGE_OA",Schema="OA")]
    public partial class OaCdCharge
    {
        public virtual ICollection<OaDsc> OaDscs { get; set; }
        
        public virtual ICollection<OaDscTemp> OaDscTemps { get; set; }
        
        [Key]
        [Description("Surcharge")]
        [Column("SURCHARGE",Order=0)]
        [Required()]
        [MaxLength(60)] 
        public String Surcharge { get; set; }
        
    }
}
