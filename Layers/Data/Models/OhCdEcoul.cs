using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_ECOUL_OH",Schema="OH")]
    public partial class OhCdEcoul
    {
        public virtual ICollection<OhDsc> OhDscs { get; set; }
        
        public virtual ICollection<OhDscTemp> OhDscTemps { get; set; }
        
        [Key]
        [Description("Ecoulement")]
        [Column("ECOUL",Order=0)]
        [Required()]
        [MaxLength(60)] 
        public String Ecoul { get; set; }
        
    }
}
