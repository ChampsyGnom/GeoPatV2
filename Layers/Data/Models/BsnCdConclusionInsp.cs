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
        
        public virtual BsnCdConclusion BsnCdConclusion {get;set;}
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant Campagne")]
        [Column("CAMP_BSN__ID_CAMP",Order=0)]
        [Required()]
        [MaxLength(100)] 
        public String CampBsnIdCamp { get; set; }
        
        [Description("N° Bassin")]
        [Column("DSC_BSN__NUM_BSN",Order=1)]
        [Required()]
        [MaxLength(20)] 
        public String DscBsnNumBsn { get; set; }
        
        [Description("Identifiant Conclusion")]
        [Column("CD_CONCLUSION_BSN__ID_CONC",Order=2)]
        [Required()]
        public Int64 CdConclusionBsnIdConc { get; set; }
        
        [Description("Contenu")]
        [Column("CONTENU",Order=3)]
        [MaxLength(1000)] 
        public String Contenu { get; set; }
        
    }
}
