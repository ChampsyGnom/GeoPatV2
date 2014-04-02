using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_CONCLUSION__INSP_TMP_GMS",Schema="GMS")]
    public partial class GmsCdConclusionInspTmp : ModelBase
    {
        public virtual GmsCdConclusion GmsCdConclusion {get;set;}
        
        [Required()]
        [Column("CD_CONCLUSION_GMS_ID_PK",Order=0)]
        public Int64 GmsCdConclusionIdPk {get;set;}
        
        public virtual GmsInspTmp GmsInspTmp {get;set;}
        
        [Required()]
        [Column("INSP_TMP_GMS_ID_PK",Order=1)]
        public Int64 GmsInspTmpIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant")]
        [Column("CAMP_GMS__ID_CAMP",Order=3)]
        [Required()]
        [MaxLength(100)] 
        public String CampGmsIdCamp { get; set; }
        
        [Description("No GMS")]
        [Column("DSC_TEMP_GMS__NUM_GMS",Order=4)]
        [Required()]
        [MaxLength(17)] 
        public String DscTempGmsNumGms { get; set; }
        
        [Description("Identifiant Conclusion")]
        [Column("CD_CONCLUSION_GMS__ID_CONC",Order=5)]
        [Required()]
        public Int64 CdConclusionGmsIdConc { get; set; }
        
        [Description("Contenu")]
        [Column("CONTENU",Order=6)]
        [MaxLength(1000)] 
        public String Contenu { get; set; }
        
    }
}
