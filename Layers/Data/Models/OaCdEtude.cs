using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_ETUDE_OA",Schema="OA")]
    public partial class OaCdEtude : ModelBase
    {
        public virtual ICollection<OaInsp> OaInsps { get; set; }
        
        public virtual ICollection<OaInspTmp> OaInspTmps { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Etude-Expertise")]
        [Column("ETUDE",Order=1)]
        [Required()]
        [MaxLength(60)] 
        public String Etude { get; set; }
        
    }
}
