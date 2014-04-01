using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_TETE_AV_OH",Schema="OH")]
    public partial class OhCdTeteAv : ModelBase
    {
        public virtual ICollection<OhDsc> OhDscs { get; set; }
        
        public virtual ICollection<OhDscTemp> OhDscTemps { get; set; }
        
        [Key]
        [Description("Tête aval")]
        [Column("TETE_AV",Order=0)]
        [Required()]
        [MaxLength(60)] 
        public String TeteAv { get; set; }
        
    }
}
