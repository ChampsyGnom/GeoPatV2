using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_FAM_BSN",Schema="BSN")]
    public partial class BsnCdFam : ModelBase
    {
        public virtual ICollection<BsnDsc> BsnDscs { get; set; }
        
        public virtual ICollection<BsnDscTemp> BsnDscTemps { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Dénomination")]
        [Column("FAMILLE",Order=1)]
        [Required()]
        [MaxLength(60)] 
        public String Famille { get; set; }
        
        [Description("Libellé")]
        [Column("LIBELLE",Order=2)]
        [MaxLength(60)] 
        public String Libelle { get; set; }
        
    }
}
