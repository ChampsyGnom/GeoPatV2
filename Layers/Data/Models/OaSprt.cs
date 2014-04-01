using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("SPRT_OA",Schema="OA")]
    public partial class OaSprt : ModelBase
    {
        public virtual OaPrt OaPrt {get;set;}
        
        public virtual ICollection<OaElt> OaElts { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant Groupe")]
        [Column("GRP_OA__ID_GRP",Order=0)]
        [Required()]
        public Int64 GrpOaIdGrp { get; set; }
        
        [Description("Identifiant Partie")]
        [Column("PRT_OA__ID_PRT",Order=1)]
        [Required()]
        public Int64 PrtOaIdPrt { get; set; }
        
        [Description("Identifiant Sous Partie")]
        [Column("ID_SPRT",Order=2)]
        [Required()]
        public Int64 IdSprt { get; set; }
        
        [Description("Sous Partie")]
        [Column("LIBS",Order=3)]
        [Required()]
        [MaxLength(500)] 
        public String Libs { get; set; }
        
        [Description("No Ordre")]
        [Column("ORDRE",Order=4)]
        [Required()]
        public Int64 Ordre { get; set; }
        
    }
}
