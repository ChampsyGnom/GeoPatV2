using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("SEUIL_QUALITE_GOT",Schema="GOT")]
    public partial class GotSeuilQualite : ModelBase
    {
        public virtual GotCdQualite GotCdQualite {get;set;}
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Niveau qualité")]
        [Column("CD_QUALITE_GOT__QUALITE",Order=0)]
        [Required()]
        [MaxLength(25)] 
        public String CdQualiteGotQualite { get; set; }
        
        [Description("Indice urgence")]
        [Column("INDICE_URGENCE",Order=1)]
        [Required()]
        [MaxLength(5)] 
        public String IndiceUrgence { get; set; }
        
    }
}
