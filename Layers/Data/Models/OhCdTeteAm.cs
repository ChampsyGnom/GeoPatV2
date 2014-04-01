using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_TETE_AM_OH",Schema="OH")]
    public partial class OhCdTeteAm : ModelBase
    {
        public virtual ICollection<OhDsc> OhDscs { get; set; }
        
        public virtual ICollection<OhDscTemp> OhDscTemps { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Tête amont")]
        [Column("TETE_AM",Order=0)]
        [Required()]
        [MaxLength(60)] 
        public String TeteAm { get; set; }
        
    }
}
