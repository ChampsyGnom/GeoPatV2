using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_TRAITEMENT_GOT",Schema="GOT")]
    public partial class GotCdTraitement : ModelBase
    {
        public virtual ICollection<GotCouche> GotCouches { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Traitement")]
        [Column("TYPE",Order=1)]
        [Required()]
        [MaxLength(25)] 
        public String Type { get; set; }
        
    }
}
