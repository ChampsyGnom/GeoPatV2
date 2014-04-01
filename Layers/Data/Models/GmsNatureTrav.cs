using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("NATURE_TRAV_GMS",Schema="GMS")]
    public partial class GmsNatureTrav : ModelBase
    {
        public virtual GmsCdTravaux GmsCdTravaux {get;set;}
        
        public virtual ICollection<GmsTravaux> GmsTravauxs { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Type Travaux")]
        [Column("CD_TRAVAUX_GMS__CODE",Order=0)]
        [Required()]
        [MaxLength(60)] 
        public String CdTravauxGmsCode { get; set; }
        
        [Description("Nature travaux")]
        [Column("NATURE",Order=1)]
        [Required()]
        [MaxLength(255)] 
        public String Nature { get; set; }
        
    }
}
