using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_CONCLUSION__INSP_BSN",Schema="BSN")]
    public partial class BsnCdConclusionInsp : ModelBase
    {
        public virtual BsnInsp BsnInsp {get;set;}
        
        [Required()]
        [Column("INSP_BSN_ID_PK",Order=0)]
        public Int64 BsnInspIdPk {get;set;}
        
        public virtual BsnCdConclusion BsnCdConclusion {get;set;}
        
        [Required()]
        [Column("CD_CONCLUSION_BSN_ID_PK",Order=1)]
        public Int64 BsnCdConclusionIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant Campagne")]
        [Column("CAMP_BSN__ID_CAMP",Order=3)]
        [Required()]
        [MaxLength(100)] 
        public String CampBsnIdCamp { get; set; }
        
        [Description("N° Bassin")]
        [Column("DSC_BSN__NUM_BSN",Order=4)]
        [Required()]
        [MaxLength(20)] 
        public String DscBsnNumBsn { get; set; }
        
        [Description("Identifiant Conclusion")]
        [Column("CD_CONCLUSION_BSN__ID_CONC",Order=5)]
        [Required()]
        public Int64 CdConclusionBsnIdConc { get; set; }
        
        [Description("Contenu")]
        [Column("CONTENU",Order=6)]
        [MaxLength(1000)] 
        public String Contenu { get; set; }
        
    }
}
