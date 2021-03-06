using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_AGREGE_CHS",Schema="CHS")]
    public partial class ChsCdAgrege : ModelBase
    {
        public virtual ICollection<ChsAgrege> ChsAgreges { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Valeur")]
        [Column("VALEUR",Order=1)]
        [Required()]
        public Int64 Valeur { get; set; }
        
        [Description("Libellé")]
        [Column("LIBELLE",Order=2)]
        [MaxLength(50)] 
        public String Libelle { get; set; }
        
        [Description("Couleur")]
        [Column("COULEUR",Order=3)]
        [MaxLength(15)] 
        public String Couleur { get; set; }
        
    }
}
