using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("INSPECTEUR_OA",Schema="OA")]
    public partial class OaInspecteur : ModelBase
    {
        public virtual OaCdPresta OaCdPresta {get;set;}
        
        public virtual ICollection<OaInsp> OaInsps { get; set; }
        
        public virtual ICollection<OaVst> OaVsts { get; set; }
        
        public virtual ICollection<OaInspTmp> OaInspTmps { get; set; }
        
        [Key]
        [Description("Nom inspecteur")]
        [Column("NOM",Order=0)]
        [Required()]
        [MaxLength(60)] 
        public String Nom { get; set; }
        
        [Description("Prestataire")]
        [Column("CD_PRESTA_OA__PRESTATAIRE",Order=1)]
        [Required()]
        [MaxLength(50)] 
        public String CdPrestaOaPrestataire { get; set; }
        
        [Description("Fonction")]
        [Column("FONC",Order=2)]
        [MaxLength(60)] 
        public String Fonc { get; set; }
        
    }
}
