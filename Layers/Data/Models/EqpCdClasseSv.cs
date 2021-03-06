using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_CLASSE_SV_EQP",Schema="EQP")]
    public partial class EqpCdClasseSv : ModelBase
    {
        public virtual ICollection<EqpPanneau> EqpPanneaus { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Classe du film")]
        [Column("CLASSE",Order=1)]
        [Required()]
        [MaxLength(5)] 
        public String Classe { get; set; }
        
    }
}
