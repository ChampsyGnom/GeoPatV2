using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_LIAISON_INF",Schema="INF")]
    public partial class InfCdLiaison : ModelBase
    {
        public virtual ICollection<InfLiaison> InfLiaisons { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Code")]
        [Column("CD_LIAISON",Order=1)]
        [Required()]
        [MaxLength(5)] 
        public String CdLiaison { get; set; }
        
        [Description("Libellé")]
        [Column("LIBELLE",Order=2)]
        [Required()]
        [MaxLength(60)] 
        public String Libelle { get; set; }
        
    }
}
