using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_ENTP_CHS",Schema="CHS")]
    public partial class ChsCdEntp
    {
        public virtual ICollection<ChsPave> ChsPaves { get; set; }
        
        [Key]
        [Description("Entreprise")]
        [Column("ENTREPRISE",Order=0)]
        [Required()]
        [MaxLength(60)] 
        public String Entreprise { get; set; }
        
    }
}
