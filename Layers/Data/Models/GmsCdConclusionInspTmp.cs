using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_CONCLUSION__INSP_TMP_GMS",Schema="GMS")]
    public partial class GmsCdConclusionInspTmp
    {
        public virtual GmsCdConclusion GmsCdConclusion {get;set;}
        
        public virtual GmsInspTmp GmsInspTmp {get;set;}
        
        [Key]
        [Description("Identifiant")]
        [Column("CAMP_GMS__ID_CAMP",Order=0)]
        [Required()]
        [MaxLength(100)] 
        public String CampGmsIdCamp { get; set; }
        
        [Key]
        [Description("No GMS")]
        [Column("DSC_TEMP_GMS__NUM_GMS",Order=1)]
        [Required()]
        [MaxLength(17)] 
        public String DscTempGmsNumGms { get; set; }
        
        [Key]
        [Description("Identifiant Conclusion")]
        [Column("CD_CONCLUSION_GMS__ID_CONC",Order=2)]
        [Required()]
        public Int64 CdConclusionGmsIdConc { get; set; }
        
        [Description("Contenu")]
        [Column("CONTENU",Order=3)]
        [MaxLength(1000)] 
        public String Contenu { get; set; }
        
    }
}
