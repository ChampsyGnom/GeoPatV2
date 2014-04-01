using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_POS_PAN_GMS",Schema="GMS")]
    public partial class GmsCdPosPan
    {
        public virtual ICollection<GmsPanneau> GmsPanneaus { get; set; }
        
        [Key]
        [Description("Position")]
        [Column("POSIT",Order=0)]
        [Required()]
        [MaxLength(4)] 
        public String Posit { get; set; }
        
        [Description("Libellé")]
        [Column("LIBELLE",Order=1)]
        [MaxLength(60)] 
        public String Libelle { get; set; }
        
    }
}
