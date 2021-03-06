using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_TRAVAUX_CHS",Schema="CHS")]
    public partial class ChsCdTravaux : ModelBase
    {
        public virtual ICollection<ChsBpu> ChsBpus { get; set; }
        
        public virtual ICollection<ChsPave> ChsPaves { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Type Travaux")]
        [Column("CODE",Order=1)]
        [Required()]
        [MaxLength(60)] 
        public String Code { get; set; }
        
    }
}
