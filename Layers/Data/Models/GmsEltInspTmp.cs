using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("ELT_INSP_TMP_GMS",Schema="GMS")]
    public partial class GmsEltInspTmp : ModelBase
    {
        public virtual GmsInspTmp GmsInspTmp {get;set;}
        
        [Required()]
        [Column("INSP_TMP_GMS_ID_PK",Order=0)]
        public Int64 GmsInspTmpIdPk {get;set;}
        
        public virtual GmsElt GmsElt {get;set;}
        
        [Required()]
        [Column("ELT_GMS_ID_PK",Order=1)]
        public Int64 GmsEltIdPk {get;set;}
        
        public virtual ICollection<GmsPhotoEltInspTmp> GmsPhotoEltInspTmps { get; set; }
        
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
        
        [Description("Identifiant Groupe")]
        [Column("GRP_GMS__ID_GRP",Order=5)]
        [Required()]
        public Int64 GrpGmsIdGrp { get; set; }
        
        [Description("Identifiant Partie")]
        [Column("PRT_GMS__ID_PRT",Order=6)]
        [Required()]
        public Int64 PrtGmsIdPrt { get; set; }
        
        [Description("Identifiant Sous Partie")]
        [Column("SPRT_GMS__ID_SPRT",Order=7)]
        [Required()]
        public Int64 SprtGmsIdSprt { get; set; }
        
        [Description("Identifiant élément")]
        [Column("ELT_GMS__ID_ELEM",Order=8)]
        [Required()]
        public Int64 EltGmsIdElem { get; set; }
        
        [Description("Indice")]
        [Column("INDICE",Order=9)]
        [Required()]
        public Int64 Indice { get; set; }
        
        [Description("Observation")]
        [Column("OBS",Order=10)]
        [MaxLength(255)] 
        public String Obs { get; set; }
        
    }
}
