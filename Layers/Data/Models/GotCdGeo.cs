using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_GEO_GOT",Schema="GOT")]
    public partial class GotCdGeo : ModelBase
    {
        public virtual ICollection<GotDsc> GotDscs { get; set; }
        
        public virtual ICollection<GotDscTemp> GotDscTemps { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Géologie")]
        [Column("GEOLOGIE",Order=1)]
        [Required()]
        [MaxLength(60)] 
        public String Geologie { get; set; }
        
    }
}
