using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_NOM_EAU_OH",Schema="OH")]
    public partial class OhCdNomEau : ModelBase
    {
        public virtual ICollection<OhDsc> OhDscs { get; set; }
        
        public virtual ICollection<OhDscTemp> OhDscTemps { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Nom cours d'eau")]
        [Column("NOM",Order=1)]
        [Required()]
        [MaxLength(60)] 
        public String Nom { get; set; }
        
    }
}
