using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_CLASS_TRAF_INF",Schema="INF")]
    public partial class InfCdClassTraf : ModelBase
    {
        public virtual ICollection<InfSectionTrafic> InfSectionTrafics { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Classe de trafic")]
        [Column("CODE",Order=1)]
        [Required()]
        [MaxLength(6)] 
        public String Code { get; set; }
        
    }
}
