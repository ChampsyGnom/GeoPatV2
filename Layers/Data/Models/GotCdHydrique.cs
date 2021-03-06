using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_HYDRIQUE_GOT",Schema="GOT")]
    public partial class GotCdHydrique : ModelBase
    {
        public virtual ICollection<GotCouche> GotCouches { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Etat hydrique")]
        [Column("ETAT",Order=1)]
        [Required()]
        [MaxLength(25)] 
        public String Etat { get; set; }
        
    }
}
