using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PHOTO_SPRT_VST_OA",Schema="OA")]
    public partial class OaPhotoSprtVst : ModelBase
    {
        public virtual OaSprtVst OaSprtVst {get;set;}
        
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
        
        [Description("Identifiant de la photo")]
        [Column("ID",Order=4)]
        [Required()]
        [MaxLength(50)] 
        public String Id { get; set; }
        
        [Description("Commentaire")]
        [Column("COMMENTAIRE",Order=5)]
        [MaxLength(100)] 
        public String Commentaire { get; set; }
        
    }
}
