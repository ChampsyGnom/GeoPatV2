using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_TYPE_EQP",Schema="EQP")]
    public partial class EqpCdType : ModelBase
    {
        public virtual ICollection<EqpTravaux> EqpTravauxs { get; set; }
        
        public virtual ICollection<EqpPrevision> EqpPrevisions { get; set; }
        
        public virtual ICollection<EqpEvt> EqpEvts { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Type d'équipement")]
        [Column("TYPE_EQUIP",Order=1)]
        [Required()]
        [MaxLength(6)] 
        public String TypeEquip { get; set; }
        
        [Description("Libellé")]
        [Column("LIBELLE",Order=2)]
        [MaxLength(60)] 
        public String Libelle { get; set; }
        
    }
}
