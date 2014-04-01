using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("SEUIL_QUALITE_OH",Schema="OH")]
    public partial class OhSeuilQualite : ModelBase
    {
        public virtual OhCdQualite OhCdQualite {get;set;}
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Niveau qualité")]
        [Column("CD_QUALITE_OH__QUALITE",Order=0)]
        [Required()]
        [MaxLength(25)] 
        public String CdQualiteOhQualite { get; set; }
        
        [Description("Indice urgence")]
        [Column("INDICE_URGENCE",Order=1)]
        [Required()]
        [MaxLength(5)] 
        public String IndiceUrgence { get; set; }
        
    }
}
