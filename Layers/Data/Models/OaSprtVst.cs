using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("SPRT_VST_OA",Schema="OA")]
    public partial class OaSprtVst : ModelBase
    {
        public virtual OaVst OaVst {get;set;}
        
        public virtual OaCdLigne OaCdLigne {get;set;}
        
        public virtual ICollection<OaPhotoSprtVst> OaPhotoSprtVsts { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("NumOA")]
        [Column("DSC_OA__NUM_OA",Order=0)]
        [Required()]
        [MaxLength(20)] 
        public String DscOaNumOa { get; set; }
        
        [Description("Identifiant campagne")]
        [Column("CAMP_OA__ID_CAMP",Order=1)]
        [Required()]
        [MaxLength(100)] 
        public String CampOaIdCamp { get; set; }
        
        [Description("Identifiant chapitre")]
        [Column("CD_CHAPITRE_OA__ID_CHAP",Order=2)]
        [Required()]
        public Int64 CdChapitreOaIdChap { get; set; }
        
        [Description("Identifiant ligne")]
        [Column("CD_LIGNE_OA__ID_LIGNE",Order=3)]
        [Required()]
        public Int64 CdLigneOaIdLigne { get; set; }
        
        [Description("Indice")]
        [Column("INDICE",Order=4)]
        [Required()]
        public Int64 Indice { get; set; }
        
        [Description("Observations")]
        [Column("OBS",Order=5)]
        [MaxLength(500)] 
        public String Obs { get; set; }
        
    }
}
